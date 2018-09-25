using System.Collections.Generic;
using System;

namespace SchoolCore.Entities
{
    public class School    
    {
        #region Properties
            public string SchoolId {get; private set;} = Guid.NewGuid().ToString();
            private string name;
            public string Name { 
                get { return name.ToUpper(); } 
                set { name = value; } 
            }
            public int CreationYear { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public SchoolTypes SchoolType {get; set;}
            public List<Course> Courses {get; set;}

        #endregion


        #region Constructor 
        // igualacion por tuplas
            public School(string name, int creationYear) => (Name, CreationYear) = (name, creationYear);

            public School(  string name, int creationYear, 
                            SchoolTypes schoolTypes, 
                            string country = "", string City = "") 
            {
                 (Name, CreationYear) = (name, creationYear);
                 Country = country;
                 this.City = City;
            }

        #endregion

        public override string ToString()
        {
            return $"Nombre: {name}, Tipo: {SchoolType} \nPais: {Country}, Ciudad: {City}";
        }

    }
}