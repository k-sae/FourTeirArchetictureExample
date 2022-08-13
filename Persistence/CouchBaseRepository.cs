using Couchbase;
using Couchbase.KeyValue;

namespace FourTierArchitectureExample.Persistence;

public static class StringExtension
{
    public static string DefaultIfEmpty(this string? str, string defaultValue)
        => string.IsNullOrWhiteSpace(str) ? defaultValue : str;
}

public interface ICouchBaseRepository
{
    ICluster Cluster { get; }
    IBucket MeetBucket { get; }
    public Task<ICouchbaseCollection> TenantCollection(string tenant, string collection);
    public Task<ICouchbaseCollection> TenantCollection(string collection);
}

public class CouchBaseRepository : ICouchBaseRepository
{
    public ICluster Cluster { get; private set; }
    public IBucket MeetBucket { get; private set; }
    public CouchBaseRepository()
    {
        // TODO: get these variables via DI, possibly overriding config in appsettings.json
        var cbHost = Environment.GetEnvironmentVariable("CB_HOST").DefaultIfEmpty("localhost");
        var cbUser = Environment.GetEnvironmentVariable("CB_USER").DefaultIfEmpty("Administrator");
        var cbPswd = Environment.GetEnvironmentVariable("CB_PSWD").DefaultIfEmpty("password");

        Console.WriteLine(
            $"Connecting to couchbase://{cbHost} with {cbUser} / {cbPswd}");

        try
        {
             var task = Task.Run(async Task? () =>
            {
                var cluster = await Couchbase.Cluster.ConnectAsync(
                    $"couchbase://{cbHost}",
                    cbUser,
                    cbPswd);

                Cluster = cluster;
                MeetBucket = await Cluster.BucketAsync("meet-db");
                Console.WriteLine("connected");
            });
            task.Wait();
        }
        catch (AggregateException ae)
        {
            ae.Handle((x) => throw x);
        }
    }

    public async Task<ICouchbaseCollection> TenantCollection(string tenant, string collection)
    {
        var tenantScope = await MeetBucket.ScopeAsync(tenant);
        var tenantCollection = await tenantScope.CollectionAsync(collection);
        return tenantCollection;
    }
    public async Task<ICouchbaseCollection> TenantCollection(string collection)
    {
        return await TenantCollection("_default", collection);
    }
}
