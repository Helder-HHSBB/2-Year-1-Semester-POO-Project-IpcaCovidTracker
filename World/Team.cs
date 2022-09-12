using IpcaCovidTracker.Entities;
using IpcaCovidTracker.Material;
using System.Collections.Generic;

namespace IpcaCovidTracker.Teams
{
    internal class Team
    {
        /// <summary>
        /// This properties represent an team
        /// </summary>
        /// <param name="teamName"></param>
        /// <param name="teamRegion"></param>
        public Team(string teamName, string teamRegion)
        {
            this.TeamName = teamName;
            this.TeamRegion = teamRegion;
            this.KitCleanings = new List<KitCleaning>();
            this.KitIndividualProtections = new List<KitIndividualProtection>();
            this.KitScreenings = new List<KitScreening>();
        }

        /// <summary>
        /// The team also can be identified by the Doctor, nurse, administrative and driver
        /// </summary>
        /// <param name="teamName"></param>
        /// <param name="TeamRegion"></param>
        /// <param name="doctor"></param>
        /// <param name="nurse"></param>
        /// <param name="administrative"></param>
        /// <param name="driver"></param>
        public Team(string teamName, string TeamRegion, Doctor doctor, Nurse nurse, Administrative administrative, Driver driver)
        {
            this.TeamName = teamName;
            this.TeamRegion = TeamRegion;
            this.Doctor = Doctor;
            this.Nurse = Nurse;
            this.Driver = driver;
            this.Administrative = administrative;
            this.KitCleanings = new List<KitCleaning>();
            this.KitIndividualProtections = new List<KitIndividualProtection>();
            this.KitScreenings = new List<KitScreening>();
        }

        /// <summary>
        /// This is the name of the team
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// This is the region assigned to the team
        /// </summary>
        public string TeamRegion { get; set; }

        /// <summary>
        /// This is the Team's doctor
        /// </summary>
        public Doctor Doctor { get; set; }

        /// <summary>
        /// This is the Team's nurse
        /// </summary>
        public Nurse Nurse { get; set; }

        /// <summary>
        /// This is the Team's driver
        /// </summary>
        public Driver Driver { get; set; }

        /// <summary>
        /// This is the Team's administrative
        /// </summary>
        public Administrative Administrative { get; set; }

        /// <summary>
        /// This is the car used by the team
        /// </summary>
        public Veichle Car { get; set; }

        /// <summary>
        /// This is the list of cleaning material.The team only can do Covid19 tests if have at least one kit of cleaning material.
        /// </summary>
        public List<KitCleaning> KitCleanings { get; set; }

        /// <summary>
        /// This is the list of individual protection material.The team only can do Covid19 tests if have at least one kit of individual protection material.
        /// </summary>
        public List<KitIndividualProtection> KitIndividualProtections { get; set; }

        /// <summary>
        /// This is the list of screening material. The team only can do Covid19 tests if have at least one kit of screening material.
        /// </summary>
        public List<KitScreening> KitScreenings { get; set; }
    }
}