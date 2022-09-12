using System;

namespace IpcaCovidTracker.Entities
{
    internal class Doctor : Person
    {
        //An overload we used to test stuff
        public Doctor(int cc, string name) : base(cc, name)
        {
        }

        /// <summary>
        /// This proprieties represent an Doctor
        /// </summary>
        /// <param name="doctorLicense"></param>
        /// <param name="cc"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="dateofbirth"></param>
        /// <param name="gender"></param>
        /// <param name="doctorWage"></param>
        /// <param name="numberoftimestestcovid"></param>
        /// <param name="ispositive"></param>
        public Doctor(int doctorLicense, int cc, string name, string email, DateTime dateofbirth, string gender,
            float doctorWage, int numberoftimestestcovid, bool ispositive) : base(cc, name, email, dateofbirth, gender,
              numberoftimestestcovid, ispositive)
        {
            this.DoctorLicense = doctorLicense;
            this.DoctorWage = doctorWage;
        }

        /// <summary>
        /// This is the Doctor's number license
        /// </summary>
        public int DoctorLicense { get; set; }

        /// <summary>
        /// This is the Doctor's wage
        /// </summary>
        public float DoctorWage { get; set; }
    }
}