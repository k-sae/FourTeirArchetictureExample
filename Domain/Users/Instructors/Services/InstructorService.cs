using FourTierArchitectureExample.Domain.Users.Instructors.Models;
using FourTierArchitectureExample.Domain.Users.Instructors.Repositories;

namespace FourTierArchitectureExample.Domain.Users.Instructors.Services;

public interface IInstructorService
{
    Task<Instructor?> GetById(string id);
    Task<Instructor?> GetByEmail(string email);
    Task<Instructor?> GetByEmailAndPassword(string email, string password);
    Task<Instructor?> Create(Instructor instructor);
    Task<Instructor?> Update(Instructor instructor);
    Task<Instructor?> Delete(int id);

    bool IsInstructorSubscribed(Instructor? instructor);
}

public class InstructorService : IInstructorService
{
    private readonly IInstructorRepository _instructorRepository;

    public InstructorService(IInstructorRepository instructorRepository)
    {
        _instructorRepository = instructorRepository;
    }
    
    public async Task<Instructor?> GetById(string id)
    {
        return await _instructorRepository.GetById(id);
    }

    public bool IsInstructorSubscribed(Instructor? instructor)
    {
        return instructor != null && instructor.InstructorPackages.Any();
    }

    
    public Task<Instructor?> GetByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public Task<Instructor?> GetByEmailAndPassword(string email, string password)
    {
        throw new NotImplementedException();
    }

    public async Task<Instructor?> Create(Instructor instructor)
    {
        instructor.Id = Guid.NewGuid().ToString();
        return await _instructorRepository.Add(instructor);
    }

    public Task<Instructor?> Update(Instructor instructor)
    {
        throw new NotImplementedException();
    }

    public Task<Instructor?> Delete(int id)
    {
        throw new NotImplementedException();
    }
}