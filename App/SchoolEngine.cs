using System;
using System.Collections.Generic;
using SchoolCore.Entities;
using System.Linq;

namespace SchoolCore.App
{
    public class SchoolEngine
    {
        public School school { get; set; }
        public SchoolEngine()
        {

        }

        public void InitValues()
        {
            school = new School("Platzi Academy",
                        2012,
                        SchoolTypes.Primaria,
                        City: "Medellin"
                    );

            LoadCourses();
            LoadSubjects();
            GenerateGradesPerStudent();
        }

        private void GenerateGradesPerStudent()
        {
            Random rnd = new Random();
            foreach (var course in school.Courses)
            {
                foreach (var subjects in course.Subjects)
                {
                    foreach (var student in course.Students)
                    {
                        var insert = new GradesByStudentAndSubject(){
                            StudentId = student.StudentId,
                            StudentName = student.StudentName,
                            SubjectId = subjects.SubjectId, 
                            SubjectName = subjects.SubjectName,
                            Grade = (float)(5* rnd.NextDouble())
                        };
                        course.GradesByStudentAndSubject.Add(insert);
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
                            select new Student{StudentName = $"{n1} {l1}"});

           return  StudentList.OrderBy((al)=> al.StudentId).Take(quantity).ToList();
        }

        private void LoadSubjects()
        {             
            foreach (var course in school.Courses)
            {
                var subjectsList = new List<Subject>(){
                    new Subject{SubjectName = "Math"},
                    new Subject{SubjectName = "Physics"},
                    new Subject{SubjectName = "Spain"},
                    new Subject{SubjectName = "Sciences"}
                };
                course.Subjects = subjectsList; 
            }
        }

        private void LoadCourses()
        {            
            school.Courses = new List<Course>(){
                new Course() { CourseName = "101", WorkingDay = WorkingDayTypes.Morning },
                new Course() { CourseName = "201",WorkingDay = WorkingDayTypes.Morning },
                new Course() { CourseName = "301", WorkingDay = WorkingDayTypes.Morning },
                new Course() { CourseName = "401", WorkingDay = WorkingDayTypes.Afternoon },
                new Course() { CourseName = "501",WorkingDay = WorkingDayTypes.Afternoon }
            };

            Random rnd = new Random();
            foreach (var c in school.Courses)
            {                
                int randomNumber = rnd.Next(5, 20);
                c.Students = GenerateAleatoryStudents(randomNumber);
            }
        }
    }
}