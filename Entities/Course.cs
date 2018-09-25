using System;
using System.Collections.Generic;

namespace SchoolCore.Entities
{
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseId { get; private set; }
        public WorkingDayTypes WorkingDay { get; set; }
        public List<Subject> Subjects {get; set;}
        public List<Student> Students {get; set;}    
        public List<GradesByStudentAndSubject>  GradesByStudentAndSubject {get; set;}
        public Course() 
        {
            CourseId = Guid.NewGuid().ToString();
            GradesByStudentAndSubject = new List<GradesByStudentAndSubject>();
        }
    }
}