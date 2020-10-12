using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleProjectSE2.Dtos;
using SimpleProjectSE2.Models;
using SimpleProjectSE2.Repositories.Interfaces;

namespace SimpleProjectSE2.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [Authorize(Roles = Role.LeaderOfGroup)]
        [HttpGet]
        public async Task<ActionResult<ICollection<StudentDto>>> GetStudents()
        {
            IEnumerable<Student> innerStudents = await _studentRepository.GetStudents();
            ICollection<StudentDto> students = new LinkedList<StudentDto>();

            foreach (Student s in innerStudents)
            {
                students.Add(new StudentDto()
                {
                    Name = s.Name,
                    Surname = s.Surname,
                    Birthday = s.Birthday,
                    GroupId = s.GroupId
                });
            }
            return Ok(students);
        }

        [HttpPost]
        public async Task<ActionResult> AddStudent(StudentDto s)
        {
            Student st = new Student(s);
            if (await _studentRepository.AddStudent(st))
            {
                return Ok("A new user was added successfully!");
            }

            return BadRequest("Oops, somthing wring happened!");
        }
    }
}
