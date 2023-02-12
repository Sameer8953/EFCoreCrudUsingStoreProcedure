using EFCoreCrudUsingStoreProcedure.Context;
using EFCoreCrudUsingStoreProcedure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCrudUsingStoreProcedure.Service
{
    public class StudentService : IStudentSerivce
    {
        DatabaseContext _dbContext = null;

        public StudentService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Delete(int studentId)
        {
            _dbContext.Database.ExecuteSqlRaw($"DeleteStudent { studentId }");
            //Test
            var students = _dbContext.Students.ToList();
        }

        public List<Student> GetStudents(string name)
        {
            var students = _dbContext.Students.FromSqlRaw($"GETStudents {name}").ToList();
            return students;
        }

        public void SaveOrUpdate(Student student)
        {
            _dbContext.Database.ExecuteSqlRaw($"SaveOrUpdateStudent {student.StudentId},{student.Name},{student.Age}");

            //Test
            var students = _dbContext.Students.ToList();
        }
    }
}
