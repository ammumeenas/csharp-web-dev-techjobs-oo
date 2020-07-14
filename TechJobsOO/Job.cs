﻿using System;
using System.Linq;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId++;
        }

        public Job(string name, Employer employerName,Location employerLocation,PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;


        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public  override string ToString()
        {

            string output;
            string nodata = "No data found";
            string namenull = Name == "" ? nodata : Name;
            string employernull = EmployerName.Value == "" ? nodata : EmployerName.Value;
            string positionnull = JobType.Value == "" ? nodata : JobType.Value;
            string locationnull = EmployerLocation.Value == "" ? nodata : EmployerLocation.Value;
            string corenull = JobCoreCompetency.Value == "" ? nodata : JobCoreCompetency.Value;
           
            
             output = "\n"+"ID:" + Id + "\n"+"Name:" + namenull +  "\n"  + "Employer:" + employernull + "\n"  + "Location:" + locationnull + "\n" +  "Position Type:" + positionnull + "\n" + "Core Competency:" + corenull+ "\n";
            if (namenull == nodata && employernull == nodata && positionnull == nodata && locationnull == nodata && corenull == nodata)
            {
                output = "OOPS! This job does not seem to exist.";
            }
            return output;
        }
        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
