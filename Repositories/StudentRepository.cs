using Microsoft.EntityFrameworkCore;
using SimpleProjectSE2.Data;
using SimpleProjectSE2.Models;
using SimpleProjectSE2.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProjectSE2.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;

        public StudentRepository(DataContext context)
        {
            _context = context;
        }
        public bool AddStudent(Student s)
        {
            _context.StudentList.Add(s);
            return _context.SaveChanges() > 0;
        }

        public IEnumerable<Student> GetStudents()
        {
            return _context.StudentList.Include(x => x.Group).OrderBy(x => x.Name);
        }
    }
}


