using FourTierArchitectureExample.Domain.Groups.Models;
using FourTierArchitectureExample.Persistence;

namespace FourTierArchitectureExample.Domain.Groups.Repositories;

public interface IGroupRepository
{
    Task<Group> GetById(string id);
    Task<Group> GetByName(string name);
    Task<Group>  Add(Group group);
    Task<Group>  Update(Group group);
    Task<Group>  Delete(Group group);
}

public class GroupRepository : IGroupRepository
{
    
    private readonly ICouchBaseRepository _couchBaseRepository;

    public GroupRepository(ICouchBaseRepository couchBaseRepository)
    {
        _couchBaseRepository = couchBaseRepository;
    }

    public Task<Group> GetById(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Group> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public async Task<Group> Add(Group group)
    {
        var groupCollection = await _couchBaseRepository.TenantCollection("exams");
        await groupCollection.InsertAsync(group.Id, group);
        return group;
    }

    public Task<Group>  Update(Group group)
    {
        throw new NotImplementedException();
    }

    public Task<Group>  Delete(Group group)
    {
        throw new NotImplementedException();
    }
}