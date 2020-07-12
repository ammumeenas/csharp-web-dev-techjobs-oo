using System;
namespace TechJobsOO
{
    public class CoreCompetency:Jobfield
    {
       
        public CoreCompetency(string v) :base(v)
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
    }

