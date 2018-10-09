using System;

namespace SchoolCore.Entities
{
    public class Test : SchoolObjBase
    {
        public Student student { get; set; }
        public Subject subject { get; set; }
        public float grade { get; set; }

        public override string ToString()
        {
            return $"{grade}, {student.Name}, subject : {subject.Name}";
        }
    }
}