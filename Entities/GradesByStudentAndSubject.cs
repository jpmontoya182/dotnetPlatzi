using System;

namespace SchoolCore.Entities
{
    public class GradesByStudentAndSubject
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string GradesByStudentAndSubjectId { get; private set; }
        public float Grade { get; set; }
        public GradesByStudentAndSubject() => GradesByStudentAndSubjectId = Guid.NewGuid().ToString();
    }
}