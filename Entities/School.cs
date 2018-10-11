using System.Collections.Generic;
using System;
using SchoolCore.Utilities;

namespace SchoolCore.Entities
{
    public class School : SchoolObjBase, IPlace
    {
        #region Properties
            public int CreationYear { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public SchoolType SchoolType { get; set; }
            public List<Course> Courses { get; set; }
            public string Address { get; set; }

        #endregion


        #region Constructor 
        // igualacion por tuplas
            public School(string name, int creationYear) => (Name, CreationYear) = (name, creationYear);

            public School(string name, int creationYear,
                            SchoolType schoolTypes,
                            string country = "", string City = "")
            {
                (Name, CreationYear) = (name, creationYear);
                Country = country;
                this.City = City;
            }

        #endregion

        public override string ToString()
        {
            return $"Nombre: {Name}, Tipo: {SchoolType} \nPais: {Country}, Ciudad: {City}";
        }

        public void CleanPlace()
        {
            Printer.DrawLine();
            Console.WriteLine("Cleaning school..");
            foreach (var course in Courses)
            {
                course.CleanPlace();
            }
        }
    }
}