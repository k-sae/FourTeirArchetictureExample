
using FourTierArchitectureExample.Domain.Courses.Models;
using FourTierArchitectureExample.Domain.Groups.Models;
using FourTierArchitectureExample.Domain.Groups.Repositories;

namespace FourTierArchitectureExample.Domain.Groups.Services;

public interface IGroupsService
{
    Task<Group> GetById(string id);
    Task<IEnumerable<Group>> GetAll();
    Task<Group> Create(Group group);
    Task<Group> Update(Group group);
    Task Remove(string id);
    Task<Group> CreateCourseGroup(Group group, Course course);
}   

public class GroupService : IGroupsService
{
    private readonly IGroupRepository _groupRepository;
    
    public GroupService(IGroupRepository groupRepository)
    {
        _groupRepository = groupRepository;
    }
    
    public Task<Group> GetById(string id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Group>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Group> Create(Group group)
    {
        group.Id = Guid.NewGuid().ToString();
        return await _groupRepository.Add(group);
    }

    public async Task<Group> CreateCourseGroup(Group group, Course course)
    {
        group.Name = course.Name;
        group.Description = course.Description;
        group.Image = course.Image;
        group.AdminUser = course.InstructorId;
        return await Create(group);
    }

    
    public Task<Group> Update(Group @group)
    {
        throw new NotImplementedException();
    }

    public Task Remove(string id)
    {
        throw new NotImplementedException();
    }
}