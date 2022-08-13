using FourTierArchitectureExample.Domain.Courses.Models;
using FourTierArchitectureExample.Domain.Courses.Services;
using FourTierArchitectureExample.Domain.Groups.Models;
using FourTierArchitectureExample.Domain.Groups.Services;
using FourTierArchitectureExample.Domain.Users.Instructors.Repositories;
using FourTierArchitectureExample.Domain.Users.Instructors.Services;
using Microsoft.AspNetCore.Mvc;

namespace FourTierArchitectureExample.Controllers.Courses.PublishCourse;

[ApiController]
[Route("api/course/publish")]
public class PublishCourseController : Controller
{
    private readonly IInstructorService _instructorService;
    private readonly ICourseService _courseService;
    private readonly IGroupsService _groupsService;

    public PublishCourseController(IInstructorService instructorService, ICourseService courseService,
        IGroupsService groupsService)
    {
        _instructorService = instructorService;
        _courseService = courseService;
        _groupsService = groupsService;
    }


    [HttpPost(Name = "publish_course")]
    public async Task<Course?> PublishCourse(string instructorId, string courseId)
    {
        var instructor = await _instructorService.GetById(instructorId);
        var course = await _courseService.GetById(courseId);
        var isSubscribed = _instructorService.IsInstructorSubscribed(instructor);
        if (isSubscribed)
        {
            var group = await _groupsService.CreateCourseGroup(new Group(), course);
            _courseService.SetCourseGroup(course, group);
            _courseService.SetCourseAsPublished(course);
            await _courseService.Update(course);
            // TODO add notification to instructor
            return course;
        }

        return null;
    }
}