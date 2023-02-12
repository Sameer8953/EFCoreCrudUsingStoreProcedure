using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCrudUsingStoreProcedure.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; } = 0;
        public String Name { get; set; } = "";
        public int Age { get; set; } = 0;

    }
}
