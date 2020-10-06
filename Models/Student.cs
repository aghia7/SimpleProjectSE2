using SimpleProjectSE2.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProjectSE2.Models
{
    public class Student
    {
        public Student()
        {

        }

        public Student(StudentDto s) 
        {
            Id = Guid.NewGuid();
            Name = s.Name;
            Surname = s.Surname;
            Birthday = s.Birthday;
            GroupId = s.GroupId;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime? Birthday { get; set; }
        public Guid GroupId { get; set; }
        public Group Group { get; set; }
        public string Role { get; set; }
    }
}
