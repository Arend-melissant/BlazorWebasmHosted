using System;
using System.Collections.Generic;
using BlazorWebasmHosted.Shared;


namespace BlazorWebasmHosted.Server
{  
    public interface IStudentDataAccessProvider  
    {  
        void AddStudentRecord(Student student);  
        void UpdateStudentRecord(Student student);  
        void DeleteStudentRecord(int id);  
        Student GetStudentSingleRecord(int id);  
        List<Student> GetAllStudents();  
    }  
}  