using System;

namespace IpcaCovidTracker.Entities
{
    /// <summary>
    /// This proprieties represent an Citizen
    /// </summary>
    internal class Citizen : Person
    {
        public Citizen(int cc, string name, string email, DateTime dateofbirth, string gender,
           int numberoftimestestcovid, bool ispositive) : base(cc, name, email, dateofbirth, gender,
           numberoftimestestcovid, ispositive)
        {
        }

        //An overload we needed to initialize some empty citizens
        public Citizen(int cc, string name) : base(cc, name)
        {
        }
    }
}