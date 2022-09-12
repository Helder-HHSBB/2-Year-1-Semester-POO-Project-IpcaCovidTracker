using IpcaCovidTracker.Entities;
using System;

namespace IpcaCovidTracker.World
{
    /// <summary>
    /// This is an Interface to use when testing
    /// </summary>
    internal interface ITestParameters
    {
        public Person PersonTested { get; set; }
        public DateTime DateOfTest { get; set; }
        public Doctor Doctor { get; set; }
        public Nurse Nurse { get; set; }
        public bool IsPositive { get; set; }
        public string TeamName { get; set; }
        public String Region { get; set; }
    }
}