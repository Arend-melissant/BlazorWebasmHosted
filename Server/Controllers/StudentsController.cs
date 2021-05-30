using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc; 
using BlazorWebasmHosted.Shared;

  
namespace BlazorWebasmHosted.Server.Controllers
{  
    [ApiController]
//    [Route("[controller]")]
    public class StudentsController : Controller  
    {  
        private readonly IStudentDataAccessProvider _dataAccessProvider;  
  
        public StudentsController(IStudentDataAccessProvider dataAccessProvider)  
        {  
            _dataAccessProvider = dataAccessProvider;  
        }  
  
        [HttpGet]  
        [Route("api/Students/Get")]  
        public IEnumerable<Student> Get()  
        {  
            return _dataAccessProvider.GetAllStudents();  
        }  
  
        [HttpPost]  
        [Route("api/Students/Create")]  
        public void Create([FromBody]Student patient)  
        {  
            if (ModelState.IsValid)  
            {  
                _dataAccessProvider.AddStudentRecord(patient);  
            }  
        }  
  
        [HttpGet]  
        [Route("api/Students/Details/{id}")]  
        public Student Details(int id)  
        {  
            return _dataAccessProvider.GetStudentSingleRecord(id);  
        }  
  
        [HttpPut]  
        [Route("api/Students/Edit")]  
        public void Edit([FromBody]Student student)  
        {  
            if (ModelState.IsValid)  
            {  
                _dataAccessProvider.UpdateStudentRecord(student);  
            }  
        }  
  
        [HttpDelete]  
        [Route("api/Students/Delete/{id}")]  
        public void DeleteConfirmed(int id)  
        {  
            _dataAccessProvider.DeleteStudentRecord(id);  
        }  
    }  
}  
