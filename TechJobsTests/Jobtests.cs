using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;
namespace TechJobsTests { 


    [TestClass]
    public class Jobtests
    {

 

    Job job1;
    Job job2;
    Employer employer;
    Location location;
    PositionType positiontype;
    CoreCompetency corecompetency;
    Job obj;
    Job obj1;
    Job obj2;
    Job nodataobj;
    Job emptyobj;
    [TestInitialize]
    public void Classinstance()
    {
        job1 = new TechJobsOO.Job();
        job2 = new TechJobsOO.Job();

        employer = new Employer("ACME");
        location = new Location("Desert");
        positiontype = new PositionType("Persistence");
        corecompetency = new CoreCompetency("Quality control");
        obj = new TechJobsOO.Job("Product tester", employer, location, positiontype, corecompetency);

        obj1 = new TechJobsOO.Job("chris", new Employer("john"), new Location("Desert"), new PositionType("testing"), new CoreCompetency("Quality control"));
        obj2 = new TechJobsOO.Job("chris", new Employer("john"), new Location("Desert"), new PositionType("testing"), new CoreCompetency("Quality control"));

        nodataobj = new Job("chris", new Employer("john"), new Location(""), new PositionType("testing"), new CoreCompetency("Quality control"));
         emptyobj = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
    }

    [TestMethod]
        public void TestSettingJobId()
        {
            
            bool actualoutput = job1.Id.Equals(job2.Id);
            Assert.IsFalse(actualoutput);

        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
    {
            
            Assert.AreEqual("Product tester", obj.Name);
            Assert.AreEqual(employer, obj.EmployerName);
            Assert.AreEqual(location, obj.EmployerLocation);
            Assert.AreEqual(positiontype, obj.JobType);
            Assert.AreEqual(corecompetency, obj.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
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
          
            bool endswith = obj1.ToString().EndsWith("\n");
            Assert.IsTrue(endswith);
        }

        [TestMethod]

        public void testtostringmethod2()
        {
           
            int id = obj1.Id;
            string expectedoutput = "\n" +
                                 "ID:"+ id +"\n"+
                                 "Name:chris" + "\n"+
                                 "Employer:john" + "\n" +
                                  "Location:Desert" + "\n" +
                                 "Position Type:testing" + "\n" +
                                 "Core Competency:Quality control" + "\n";
            string actualoutput = obj1.ToString();
            Assert.AreEqual(expectedoutput, actualoutput);
        }
        [TestMethod]
        public void testtostringmethod3()
        {

            int id = nodataobj.Id;
            string expectedoutput = "\n" +
                                 "ID:" + id + "\n" +
                                 "Name:chris" + "\n" +
                                 "Employer:john" + "\n" +
                                  "Location:No data found" + "\n" +
                                 "Position Type:testing" + "\n" +
                                 "Core Competency:Quality control" + "\n";
            string actualoutput = nodataobj.ToString();
            Assert.AreEqual(expectedoutput, actualoutput);
        }

        [TestMethod]
        public void testtostringmethod4()
        {
            int id = emptyobj.Id;
            string expectedoutput = "OOPS! This job does not seem to exist.";
            string actualoutput = emptyobj.ToString();
            Assert.AreEqual(expectedoutput, actualoutput);
        }




    }
}

        
    

