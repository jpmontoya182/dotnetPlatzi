using System;

namespace SchoolCore.Entities
{
    public abstract class SchoolObjBase
    {
        public string Id { get; private set; }
        public string Name { get; set; }

        public SchoolObjBase()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}