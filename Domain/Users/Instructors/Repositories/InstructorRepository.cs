using FourTierArchitectureExample.Domain.Users.Instructors.Models;
using FourTierArchitectureExample.Persistence;

namespace FourTierArchitectureExample.Domain.Users.Instructors.Repositories;

public interface IInstructorRepository
{
    Task<Instructor> Add(Instructor instructor);
    void Update(Instructor instructor);
    void Remove(Instructor instructor);
    Task<Instructor?> GetById(string id);
    Task<Instructor> GetByEmail(string email);
    Task<IEnumerable<Instructor>> GetAll();
}

public class InstructorRepository : IInstructorRepository
{
    private readonly ICouchBaseRepository _couchBaseRepository;

    public InstructorRepository(ICouchBaseRepository couchBaseRepository)
    {
        _couchBaseRepository = couchBaseRepository;
    }

    public async Task<Instructor> Add(Instructor instructor)
    {
        var instructorCollection = await _couchBaseRepository.TenantCollection("users");
        await instructorCollection.InsertAsync(instructor.Id, instructor);
        return instructor;
    }

    public void Update(Instructor instructor)
    {
        throw new NotImplementedException();
    }

    public void Remove(Instructor instructor)
    {
        throw new NotImplementedException();
    }

    public async Task<Instructor?> GetById(string id)
    {
        var instructorCollection = await _couchBaseRepository.TenantCollection("users");
        var instructor = (await instructorCollection.GetAsync(id)).ContentAs<Instructor>();
        return instructor;
    }

    public Task<Instructor> GetByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Instructor>> GetAll()
    {
        throw new NotImplementedException();
    }
}