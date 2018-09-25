using System;

namespace SchoolCore.Entities
{
    public class Test
    {
        public string TestId { get; private set; }
        public string TestName { get; set; } 
        public Student student {get; set;}
        public Subject subject {get; set;}
        public float grade {get; set;}

        public Test() => TestId = Guid.NewGuid().ToString();
    }    
}