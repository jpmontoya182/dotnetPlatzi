using System;
using System.Collections.Generic;

namespace SchoolCore.Entities
{
    public class Student : SchoolObjBase
    {
        public List<Test> Tests {get; set;}
        public Student(){
            Tests = new List<Test>();
        }
    }    
}