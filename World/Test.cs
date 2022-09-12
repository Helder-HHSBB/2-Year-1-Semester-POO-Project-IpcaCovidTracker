using IpcaCovidTracker.Entities;
using System;

namespace IpcaCovidTracker.World
{
    /// <summary>
    /// Implementing the Interface Properties to perform tests
    /// </summary>
    internal class Test : ITestParameters
    {
        public Person PersonTested { get; set; }
        public DateTime DateOfTest { get; set; }
        public Doctor Doctor { get; set; }
        public Nurse Nurse { get; set; }
        public bool IsPositive { get; set; }
        public String Region { get; set; }

        public string TeamName { get; set; }

        public Test(Person personTested, string region, DateTime dateOfTest, Doctor doctor, Nurse nurse, bool isPositive, string teamName)
        {
            this.PersonTested = personTested;
            this.Region = region;
            this.DateOfTest = dateOfTest;
            this.Doctor = doctor;
            this.Nurse = nurse;
            this.IsPositive = isPositive;
            this.TeamName = teamName;
        }
    }
}