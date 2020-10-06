using SimpleProjectSE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProjectSE2.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        bool AddStudent(Student s);
    }
}
