using assignment_1_webapi.Data;
using assignment_1_webapi.DTOs;
using assignment_1_webapi.Entities;
using AutoMapper;

namespace assignment_1_webapi.Services;

public interface IStudentService
{
    public void CreateStudent ( StudentModel student );
    public void GetStudentById ( string studentId );
    public void DeleteStudent ( string studentId );
}

public class StudentService : IStudentService
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public StudentService ( ApplicationDbContext context, IMapper mapper )
    {
        _context = context;
        _mapper = mapper;
    }
    public void CreateStudent(StudentModel newStudent)
    {
        _context.studentModels.Add(newStudent);
        _context.SaveChanges();
    }

    public void DeleteStudent(string studentId)
    {
        var student = _context.studentModels.Find(studentId);
        if (student != null)
        {
            _context.studentModels.Remove(student); 
            _context.SaveChanges();
        }    
        else
            throw new KeyNotFoundException($"No student with id: {studentId}");
    }

    public void GetStudentById(string studentId)
    {
        throw new NotImplementedException();
    }
}

