using FourTierArchitectureExample.Domain.Courses.Models;
using FourTierArchitectureExample.Domain.Courses.Services;
using Microsoft.AspNetCore.Mvc;

namespace FourTierArchitectureExample.Domain.Courses.Controllers;

[ApiController]
[Route("api/test/courses")]
public class CourseController : Controller
{
    private readonly ICourseService _courseService;

    public CourseController(ICourseService courseService)
    {
        _courseService = courseService;
    }

    [HttpGet("index")]
    public Task<IEnumerable<Course>> Index()
    {
       return _courseService.GetAll();
    }
    
    [HttpPost("create")]
    public Task<Course> Create()
    {
       return _courseService.Create(new Course()
       {
           Id = "Id",
           Name = "course",
           State = CourseState.Drafted
       });
    }
}