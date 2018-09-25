using System;

namespace SchoolCore.Entities
{
    public class Subject
    {
        public string SubjectId { get; private set; }
        public string SubjectName { get; set; }

        public Subject() => SubjectId = Guid.NewGuid().ToString();
    }    
}