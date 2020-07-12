using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class Jobfield
    {

        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }
        public Jobfield()
        {
            Id = nextId;
            nextId++;
        }

        public Jobfield(string value) : this()
        {
            Value = value;
        }

        public abstract bool Equals(object obj);
        public abstract int GetHashCode();
        public abstract string ToString();

    }
}
