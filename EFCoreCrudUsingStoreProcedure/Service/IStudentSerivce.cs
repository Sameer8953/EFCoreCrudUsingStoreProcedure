using EFCoreCrudUsingStoreProcedure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCrudUsingStoreProcedure.Service
{
    public interface IStudentSerivce
    {
        List<Student> GetStudents(string name);

        void SaveOrUpdate(Student student);

        void Delete(int studentId);
    }
}
