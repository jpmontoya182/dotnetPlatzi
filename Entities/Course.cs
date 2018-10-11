using System;
using System.Collections.Generic;
using SchoolCore.Utilities;

namespace SchoolCore.Entities
{
    public class Course : SchoolObjBase, IPlace
    {
        public WorkingDayType WorkingDay { get; set; }
        public List<Subject> Subject {get; set;}
        public List<Student> Student {get; set;}    
        public string Address { get; set; }

        public void CleanPlace()
        {
            Printer.DrawLine();
            Console.WriteLine("Cleaning Course...");
        }
    }
}