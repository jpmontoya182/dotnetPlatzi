using System;
using System.Collections.Generic;
using SchoolCore.Entities;
using System.Linq;

namespace SchoolCore.App
{
    public sealed class SchoolEngine
    {
        public School school { get; set; }
        public SchoolEngine()
        {

        }

        public void InitValues()
        {
            school = new School("Platzi Academy",
                        2012,
                        SchoolType.Primaria,
                        City: "Medellin"
                    );

            LoadCourses();
            LoadSubjects();
            GenerateGradesPerStudent();
        }

        private void GenerateGradesPerStudent()
        {
            var list = new List<Test>();
            foreach (var course in school.Courses)
            {
                foreach (var subjects in course.Subject)
                {
                    foreach (var student in course.Student)                    
                    {
                        var rnd = new Random(System.Environment.TickCount);

                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Test
                            {
                                subject = subjects,
                                Name = $"{subjects.Name} Ev#{i + 1}",
                                grade = (float)(5* rnd.NextDouble()), 
                                student = student
                            };
                            student.Tests.Add(ev);
                        }                        
                    }    
                }
            }
        }

        private List<Student> GenerateAleatoryStudents(int quantity)
        {
           string[] firstName = {"Juan", "Pablo", "Camilo", "Andres", "Alba"};
           string[] lastname = {"Montoya", "Cardona", "Restrepo", "Ramirez", "Goez"};

           var StudentList = (from n1 in firstName
                            from l1 in lastname
                            select new Student{Name = $"{n1} {l1}"});

           return  StudentList.OrderBy((al)=> al.Id).Take(quantity).ToList();
        }

        private void LoadSubjects()
        {             
            foreach (var course in school.Courses)
            {
                var subjectsList = new List<Subject>(){
                    new Subject{Name = "Math"},
                    new Subject{Name = "Physics"},
                    new Subject{Name = "Spain"},
                    new Subject{Name = "Sciences"}
                };
                course.Subject = subjectsList; 
            }
        }

        private void LoadCourses()
        {            
            school.Courses = new List<Course>(){
                new Course() { Name = "101", WorkingDay = WorkingDayType.Morning },
                new Course() { Name = "201",WorkingDay = WorkingDayType.Morning },
                new Course() { Name = "301", WorkingDay = WorkingDayType.Morning },
                new Course() { Name = "401", WorkingDay = WorkingDayType.Afternoon },
                new Course() { Name = "501",WorkingDay = WorkingDayType.Afternoon }
            };

            Random rnd = new Random();
            foreach (var c in school.Courses)
            {                
                int randomNumber = rnd.Next(5, 20);
                c.Student = GenerateAleatoryStudents(randomNumber);
            }
        }
    }
}