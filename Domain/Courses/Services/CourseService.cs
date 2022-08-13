using FourTierArchitectureExample.Domain.Courses.Models;
using FourTierArchitectureExample.Domain.Courses.Repositories;
using FourTierArchitectureExample.Domain.Groups.Models;

namespace FourTierArchitectureExample.Domain.Courses.Services;

public interface ICourseService
{
    Task<Course?> GetById(string id);
    Task<IEnumerable<Course>> GetAll();
    Task<Course> Create(Course course);
    Task<Course> Update(Course course);
    Task Delete(string id);
    Course SetCourseGroup(Course course, Group group);
    Course SetCourseAsPublished(Course course);
}

public class CourseService : ICourseService
{
    
    private readonly ICourseRepository _courseRepository;
    
    public CourseService(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }
    public async Task<Course?> GetById(string id)
    {
        return await _courseRepository.Get(id);
    }

    public Task<IEnumerable<Course>> GetAll()
    {
        return _courseRepository.GetAll();
    }

    public async Task<Course> Create(Course course)
    {
        course.Id = Guid.NewGuid().ToString();
        return await _courseRepository.Add(course);
    }

    public async Task<Course> Update(Course course)
    {
       return await _courseRepository.Update(course);
    }

    public Task Delete(string id)
    {
        throw new NotImplementedException();
    }

    public Course SetCourseGroup(Course course, Group group)
    {
        course.GroupId = group.Id;
        return course;
    }

    public Course SetCourseAsPublished(Course course)
    {
        course.State = CourseState.Published;
        return course;
    }
}