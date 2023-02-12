using EFCoreCrudUsingStoreProcedure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCrudUsingStoreProcedure.Context
{
    public class DatabaseContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = string.Format(@"Data Source=LAPTOP-TQ8J9D90;Initial Catalog=SchoolDB;Integrated Security=True");
            options.UseSqlServer(connectionString);

        }

        public DbSet<Student> Students { get; set; }
    }
}
