using System;
using System.Collections.Generic;
using SchoolCore.Entities;
using SchoolCore.App;
using SchoolCore.Utilities;
using static System.Console;


namespace SchoolCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new SchoolEngine();
            engine.InitValues();
            printCourses(engine.school);
            
            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.DrawLine(20);

            var studentTest = new Student{
                Name ="claire UnderWood"
            };

        }

        private static void printCourses(School school)
        {
            if (school?.Courses != null)
            {
                Printer.DrawTitle(school.ToString());               

                foreach (var item in school.Courses)
                {
                    WriteLine($"HashCode : {item.GetHashCode()}, NameCourse: {item.Name} , IdCourse: {item.Id}, WorkingDay: {item.WorkingDay}");
                }
            }
            // Printer.PrinterBeep();

        }
    }
}
