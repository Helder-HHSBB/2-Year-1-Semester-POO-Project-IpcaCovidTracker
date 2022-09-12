using System;

namespace IpcaCovidTracker.Entities
{
    internal class Nurse : Person
    {
        /// <summary>
        /// This proprieties represent an Nurse
        /// </summary>
        /// <param name="nurseLicense"></param>
        /// <param name="cc"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="dateofbirth"></param>
        /// <param name="gender"></param>
        /// <param name="nurseWage"></param>
        /// <param name="numberoftimestestcovid"></param>
        /// <param name="ispositive"></param>
        public Nurse(int nurseLicense, int cc, string name, string email, DateTime dateofbirth, string gender, float nurseWage,
           int numberoftimestestcovid, bool ispositive) : base(cc, name, email, dateofbirth, gender,
           numberoftimestestcovid, ispositive)
        {
            this.NurseLicense = nurseLicense;
            this.NurseWage = nurseWage;
        }

        /// <summary>
        /// This is the Nurse's number license
        /// </summary>
        public int NurseLicense { get; set; }

        /// <summary>
        /// This is the nurses's wage
        /// </summary>
        public float NurseWage { get; set; }
    }
}