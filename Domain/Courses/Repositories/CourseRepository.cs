using FourTierArchitectureExample.Domain.Courses.Models;
using FourTierArchitectureExample.Persistence;

namespace FourTierArchitectureExample.Domain.Courses.Repositories;

public interface ICourseRepository
{
    Task<Course?> Get(string id);
    Task<IEnumerable<Course>> GetAll();
    Task<Course> Add(Course course);
    Task<Course> Update(Course course);
    Task<Course> Delete(Course course);
}

public class CourseRepository : ICourseRepository
{
    private readonly ICouchBaseRepository _couchBaseRepository;

    public CourseRepository(ICouchBaseRepository couchBaseRepository)
    {
        _couchBaseRepository = couchBaseRepository;
    }


    public async Task<Course?> Get(string id)
    {
        var instructorCollection = await _couchBaseRepository.TenantCollection("courses");
        var course = (await instructorCollection.GetAsync(id)).ContentAs<Course>();
        return course;
    }

    public async Task<IEnumerable<Course>> GetAll()
    {
        const string query = "SELECT * FROM `meet-db`.`_default`.`courses`";
        var result = await _couchBaseRepository.Cluster.QueryAsync<Course>(
            query
        );
        return await result.ToListAsync();
    }

    public async Task<Course> Add(Course course)
    {
        var courseCollection = await _couchBaseRepository.TenantCollection("courses");
        await courseCollection.InsertAsync(course.Id, course);
        return course;
    }

    public async Task<Course> Update(Course course)
    {
        var courseCollection = await _couchBaseRepository.TenantCollection("courses");
        await courseCollection.UpsertAsync(course.Id, course);
        return course;
    }

    public Task<Course> Delete(Course course)
    {
        throw new NotImplementedException();
    }
}