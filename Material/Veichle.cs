using System;

namespace IpcaCovidTracker.Material
{
    /// <summary>
    /// This properties represent the veichle that is assigned to the teams.
    /// </summary>
    internal class Veichle : Equipment
    {
        public Veichle(string licensePlate, int equipmentCode, DateTime timeOfRevision, string model, int startingKilometers, int finalKilometers)
        : base()

        {
            this.LicensePlate = licensePlate;
            this.TimeOfRevision = timeOfRevision;
            this.Model = model;
            this.KindOfService = "Covid19 - Tracking";
            this.StartingKilometers = startingKilometers;
            this.FinalKilometers = finalKilometers;
            this.EquipmentCode = equipmentCode;
        }

        /// <summary>
        /// board of care . indentification of the care
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// time to take the car for review

        /// </summary>
        public DateTime TimeOfRevision { get; set; }

        /// <summary>
        /// car brand, model and any description of it that is useful
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// type of service that the car do.
        /// example this car can be useful for transporting people to work
        /// example transport materials, kits and etc...for using into tranking
        /// this need to be all registered
        /// </summary>
        public string KindOfService { get; set; }

        /// <summary>
        /// kilometers initials that must be recorded when use the car
        /// </summary>
        public int StartingKilometers { get; set; }

        /// <summary>
        /// final kilometers that must be recorded when delivering the car</summary>
        public int FinalKilometers { get; set; }

        /// <summary>
        /// name of driver that use the car
        /// </summary>
        public string NameDriver { get; set; }
    }
}