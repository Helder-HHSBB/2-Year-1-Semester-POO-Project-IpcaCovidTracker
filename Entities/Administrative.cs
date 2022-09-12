using System;

namespace IpcaCovidTracker.Entities
{
    internal class Administrative : Person
    {
        /// <summary>
        /// This proprieties represent an Administrative
        /// </summary>
        /// <param name="cc"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="dateofbirth"></param>
        /// <param name="gender"></param>
        /// <param name="administrativeWage"></param>
        /// <param name="numberoftimestestcovid"></param>
        /// <param name="ispositive"></param>
        public Administrative(int cc, string name, string email,
            DateTime dateofbirth, string gender, float administrativeWage, int numberoftimestestcovid, bool ispositive) : base(cc, name, email,
            dateofbirth, gender, numberoftimestestcovid, ispositive)
        {
            this.AdministrativeWage = administrativeWage;
        }

        /// <summary>
        /// This is the administrative's wage
        /// </summary>
        public float AdministrativeWage { get; set; }
    }
}