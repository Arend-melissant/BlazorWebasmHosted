using Microsoft.Extensions.Logging;  
using System.Collections.Generic;  
using System.Linq;  
using BlazorWebasmHosted.Shared;
using Microsoft.EntityFrameworkCore;
  
namespace BlazorWebasmHosted.Server
{  
    public class StudentDataAccessPostgreSqlProvider : IStudentDataAccessProvider  
    {  
        private readonly gxcjdenpContext _context;  
        private readonly ILogger _logger;  
  
        public StudentDataAccessPostgreSqlProvider(gxcjdenpContext context, ILoggerFactory loggerFactory)  
        {  
            _context = context;  
            _logger = loggerFactory.CreateLogger("DataAccessPostgreSqlProvider");  
        }  
  
        public void AddStudentRecord(Student student)  
        {  
            _context.Students.Add(student);  
            _context.SaveChanges();  
        }  
  
        public void UpdateStudentRecord(Student student)  
        {  
            _context.Students.Update(student);  
            _context.SaveChanges();  
        }  
  
        public void DeleteStudentRecord(int id)  
        {  
            var entity = _context.Students.First(t => t.Id == id);  
            _context.Students.Remove(entity);  
            _context.SaveChanges();  
        }  
  
        public Student GetStudentSingleRecord(int id)  
        {  
            return _context.Students.First(t => t.Id == id);  
        }  
  
        public List<Student> GetAllStudents()  
        {  
            return _context.Students.Include(s => s.Class).ToList();  
        }  
  
    }  
}  