using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class Jobtests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            TechJobsOO.Job id1 = new TechJobsOO.Job();
            TechJobsOO.Job id2 = new TechJobsOO.Job();
            bool actualoutput = id1.Equals(id2);
            bool expectedoutput = false;
            Assert.AreEqual(expectedoutput,actualoutput);

        }
        [TestMethod]

        public void TestJobConstructorSetsAllFields()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positiontype = new PositionType("Persistence");
            CoreCompetency corecompetency = new CoreCompetency("Quality control");
            TechJobsOO.Job obj = new TechJobsOO.Job("Product tester", employer, location, positiontype,corecompetency);
            
            Assert.AreEqual("Product tester", obj.Name);
            Assert.AreEqual(employer, obj.EmployerName);
            Assert.AreEqual(location, obj.EmployerLocation);
            Assert.AreEqual(positiontype, obj.JobType);
            Assert.AreEqual(corecompetency, obj.JobCoreCompetency);
        }

        [TestMethod]

        public void TestJobsForEquality()
        {
            TechJobsOO.Job obj1 = new TechJobsOO.Job("chris", new Employer("john"), new Location("Desert"), new PositionType("testing"), new CoreCompetency("Quality control"));
            TechJobsOO.Job obj2 = new TechJobsOO.Job("chris", new Employer("john"), new Location("Desert"), new PositionType("testing"), new CoreCompetency("Quality control"));
            bool expectedoutput = obj1.Equals(obj2);
            bool actualoutput = false;
            Assert.AreEqual(expectedoutput, actualoutput);
        }

        [TestMethod]

        public void testtostringmethodstartswith()
        {
            Job obj = new Job("chris", new Employer("john"), new Location("Desert"), new PositionType("testing"), new CoreCompetency("Quality control"));
            bool startsWith = obj.ToString().StartsWith("\n");
            Assert.IsTrue(startsWith);
        }
        [TestMethod]
        public void testtostringmethodendswith()
        {
            Job obj = new Job("chris", new Employer("john"), new Location("Desert"), new PositionType("testing"), new CoreCompetency("Quality control"));
            bool endswith = obj.ToString().EndsWith("\n");
            Assert.IsTrue(endswith);
        }

        [TestMethod]

        public void testtostringmethod2()
        {
            Job obj = new Job("chris", new Employer("john"), new Location("Desert"), new PositionType("testing"), new CoreCompetency("Quality control"));
            int id = obj.Id;
            string expectedoutput = "\n" +
                                 "ID:"+ id +"\n"+
                                 "Name:chris" + "\n"+
                                 "Employer:john" + "\n" +
                                  "Location:Desert" + "\n" +
                                 "Position Type:testing" + "\n" +
                                 "Core Competency:Quality control" + "\n";
            string actualoutput = obj.ToString();
            Assert.AreEqual(expectedoutput, actualoutput);
        }
        [TestMethod]
        public void testtostringmethod3()
        {

            Job obj = new Job("chris", new Employer("john"), new Location(""), new PositionType("testing"), new CoreCompetency("Quality control"));
            int id = obj.Id;
            string expectedoutput = "\n" +
                                 "ID:" + id + "\n" +
                                 "Name:chris" + "\n" +
                                 "Employer:john" + "\n" +
                                  "Location:No data found" + "\n" +
                                 "Position Type:testing" + "\n" +
                                 "Core Competency:Quality control" + "\n";
            string actualoutput = obj.ToString();
            Assert.AreEqual(expectedoutput, actualoutput);
        }






    }
}

        
    

