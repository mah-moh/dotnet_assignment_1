using assignment_1_webapi.Data;
using assignment_1_webapi.DTOs;
using assignment_1_webapi.Entities;
using AutoMapper;

namespace assignment_1_webapi.Services;

public interface ISemesterService
{
    public void AddSemester (SemesterAddDto semester);
}

public class SemesterService : ISemesterService
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    public SemesterService ( 
        ApplicationDbContext context,
        IMapper mapper
    ){
        _context = context;
        _mapper = mapper;
    }
    public void AddSemester(SemesterAddDto semester)
    {
        if ( _context.studentModels.Find(semester.studentId) == null )
            throw new KeyNotFoundException($"No student with id : {semester.studentId}");

        _context.semesterModels.Add(_mapper.Map<SemesterModel>(semester));
        _context.SaveChanges();
    }
}
