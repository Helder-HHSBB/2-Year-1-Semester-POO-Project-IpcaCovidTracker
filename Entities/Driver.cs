using System;

namespace IpcaCovidTracker.Entities
{
    internal class Driver : Person
    {
        /// <summary>
        /// This proprieties represent an Driver
        /// </summary>
        /// <param name="driverLicense"></param>
        /// <param name="driverCategory"></param>
        /// <param name="cc"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="dateofbirth"></param>
        /// <param name="gender"></param>
        /// <param name="driverWage"></param>
        /// <param name="numberoftimestestcovid"></param>
        /// <param name="ispositive"></param>
        public Driver(int driverLicense, string driverCategory, int cc, string name, string email, DateTime dateofbirth, string gender, float driverWage,
             int numberoftimestestcovid, bool ispositive) : base(cc, name, email, dateofbirth, gender,
              numberoftimestestcovid, ispositive)
        {
            this.DriverLicense = driverLicense;
            this.DriverCategory = driverCategory;
            this.DriverWage = driverWage;
        }

        /// <summary>
        /// This is the number of the driver license
        /// </summary>
        public int DriverLicense { get; set; }

        /// <summary>
        /// This is the category of a vehicule that can be driven by the driver
        /// </summary>
        public string DriverCategory { get; set; }

        /// <summary>
        /// This is the driver's wage
        /// </summary>
        public float DriverWage { get; set; }
    }
}