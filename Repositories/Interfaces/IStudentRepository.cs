using SimpleProjectSE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProjectSE2.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<bool> AddStudent(Student s);
    }
}
