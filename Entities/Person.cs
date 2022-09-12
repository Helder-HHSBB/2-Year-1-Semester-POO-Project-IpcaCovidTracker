using System;

namespace IpcaCovidTracker.Entities
{
    /// <summary>
    ///This is the super class, which contains the classes that inherit it.
    ///A Person is represented by the following properties.
    /// </summary>
    internal abstract class Person
    {
        public Person(int cc, string name)
        {
            this.Cc = cc;
            this.Name = name;
        }

        public Person(int cc, string name, string email, DateTime dateofbirth,
            string gender, int numberOfTimesTestedCovid, bool ispositive)
        {
            this.Cc = cc;
            this.Name = name;
            this.Email = email;
            this.DateOfBirth = dateofbirth;
            this.Gender = gender;
            this.NumberOfTimesTestCovid = numberOfTimesTestedCovid;
            this.IsPositive = ispositive;
            this.IsAssigned = false;
        }

        /// <summary>
        /// This is the citizen number
        /// </summary>
        public int Cc { get; set; }

        /// <summary>
        /// how many times did citizen the test covid
        /// </summary>
        ///

        public int NumberOfTimesTestCovid { get; set; }

        /// <summary>
        /// result of test covid if is positive is true or if is negative is false.
        /// </summary>

        public bool IsPositive { get; set; }

        /// <summary>
        /// This is the citizen name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This is the citizen email adress
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// This is the Date of Birth os the citizen
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                int age = DateTime.Today.Year - this.DateOfBirth.Year;

                if (DateTime.Today.DayOfYear < this.DateOfBirth.DayOfYear)
                {
                    age--;
                }
                return age;
            }
        }

        /// <summary>
        /// This is the citizen gender: Female or Male
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// This propertie let you know if the person it is assigned to any team, as a professional
        /// </summary>
        public bool IsAssigned { get; set; }

        /// <summary>
        /// This is the date when the Person was tested positive to Covid19 virus.
        /// </summary>
        public DateTime PositiveDate { get; set; }
    }
}