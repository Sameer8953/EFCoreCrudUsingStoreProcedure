using EFCoreCrudUsingStoreProcedure.Models;
using EFCoreCrudUsingStoreProcedure.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCrudUsingStoreProcedure.Controllers
{
    public class StudentsController : Controller
    {
        IStudentSerivce _studentSerivce = null;
        public StudentsController(IStudentSerivce studentSerivce)
        {
            _studentSerivce = studentSerivce;
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<Student> GetStudents(string name)
        {
            return _studentSerivce.GetStudents(name);
        }

        public  void SaveOrUpdate(Student student)
        {
            _studentSerivce.SaveOrUpdate(student);
        }

       public void Delete(int studentId)
       {
            _studentSerivce.Delete(studentId);
       }
    }
}
