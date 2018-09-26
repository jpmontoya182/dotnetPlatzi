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
            var ObjectList = engine.getShcoolObjects();

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
