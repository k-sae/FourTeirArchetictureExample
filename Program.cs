using FourTierArchitectureExample.Domain.Courses.Repositories;
using FourTierArchitectureExample.Domain.Courses.Services;
using FourTierArchitectureExample.Domain.Groups.Repositories;
using FourTierArchitectureExample.Domain.Groups.Services;
using FourTierArchitectureExample.Domain.Notifications.Services;
using FourTierArchitectureExample.Domain.Users.Instructors.Repositories;
using FourTierArchitectureExample.Domain.Users.Instructors.Services;
using FourTierArchitectureExample.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ICouchBaseRepository, CouchBaseRepository>();
builder.Services.AddSingleton<INotificationService, NotificationService>();



builder.Services.AddSingleton<IInstructorRepository, InstructorRepository>();
builder.Services.AddSingleton<IInstructorService, InstructorService>();

builder.Services.AddSingleton<ICourseRepository, CourseRepository>();
builder.Services.AddSingleton<ICourseService, CourseService>();


builder.Services.AddSingleton<IGroupRepository, GroupRepository>();
builder.Services.AddSingleton<IGroupsService, GroupService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
