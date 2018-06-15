using System;
using System.Collections.Generic;
using WcfService.Models;

namespace WcfService
{
    public class StudentOperation : IStudentOperation
    {
        public List<Student> GetStudents() => new List<Student>() {
            new Student() { ID = Guid.NewGuid(), Name = "Pan", Sex = Student.SexEnum.Girl, Birthday = new DateTime(2001, 1, 2) },
            new Student() { ID = Guid.NewGuid(), Name = "Yuan", Sex = Student.SexEnum.Girl, Birthday = new DateTime(2001, 11, 12) },
        };
    }
}
