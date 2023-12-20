using assignment_1_webapi.Data;
using assignment_1_webapi.DTOs;
using assignment_1_webapi.Entities;
using AutoMapper;

namespace assignment_1_webapi.Services;

public interface IStudentService
{
    public void CreateStudent ( CreateStudentDto newStudent );
    public StudentModel GetStudentById ( string studentId );
    public List<StudentModel> GetAllStudents ();
    public void DeleteStudent ( string studentId );
}

public class StudentService : IStudentService
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public StudentService 
        ( ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    public void CreateStudent(CreateStudentDto newStudent)
    {
        _context.studentModels.Add(_mapper.Map<StudentModel>(newStudent));
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

    public List<StudentModel> GetAllStudents()
    {
        return _context.studentModels.ToList();
    }

    public StudentModel GetStudentById(string studentId)
    {
        var student = _context.studentModels.Find(studentId);
        if ( student == null )
            throw new KeyNotFoundException ( $"No student with id : {studentId}");

        Console.WriteLine(_context.semesterModels.Where( semester => semester.studentId == studentId).ToList());
        

        return student;
    }
}

