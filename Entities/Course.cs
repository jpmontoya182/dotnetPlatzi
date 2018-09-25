using System;
using System.Collections.Generic;

namespace SchoolCore.Entities
{
    public class Course : SchoolObjBase
    {
        public WorkingDayType WorkingDay { get; set; }
        public List<Subject> Subject {get; set;}
        public List<Student> Student {get; set;}    
    }
}