using Microsoft.EntityFrameworkCore;
using SimpleProjectSE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SimpleProjectSE2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Student> StudentList { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
