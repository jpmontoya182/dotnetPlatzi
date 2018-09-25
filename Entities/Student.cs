using System;

namespace SchoolCore.Entities
{
    public class Student
    {
        public string StudentId { get; private set; }
        public string StudentName { get; set; }

        public Student() => StudentId = Guid.NewGuid().ToString();
    }    
}