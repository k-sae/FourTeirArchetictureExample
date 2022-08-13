using FourTierArchitectureExample.Domain.Users.Instructors.Models;
using FourTierArchitectureExample.Domain.Users.Instructors.Services;
using Microsoft.AspNetCore.Mvc;

namespace FourTierArchitectureExample.Domain.Users.Instructors.controllers;

[ApiController]
[Route("api/test/instructors")]
public class InstructorController : Controller
{
    private readonly IInstructorService _instructorService;

    public InstructorController(IInstructorService instructorService)
    {
        _instructorService = instructorService;
    }

    [HttpGet("index")]
    public Task<IEnumerable<Instructor>> Index()
    {
        throw new Exception();
    }
    
    [HttpPost("create")]
    public Task<Instructor?> Create()
    {
       return _instructorService.Create(new Instructor()
       {
           Id = "Id",
           Username = "Username",
           InstructorPackages = new List<string>()
           {
               "Package1",
           }
       });
    }
}