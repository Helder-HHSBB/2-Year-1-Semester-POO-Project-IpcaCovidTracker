using System;

namespace IpcaCovidTracker.Material
{
    internal abstract class Equipment
    {
        public Equipment(int equipmentCode, DateTime expirationDate)
        {
            this.EquipmentCode = equipmentCode;
            this.ExpirationDate = expirationDate;
            this.IsAssigned = false;
        }

        protected Equipment()
        {
        }

        /// <summary>
        /// This is de equipments's code, which allows you to identify the kit
        /// </summary>
        public int EquipmentCode { get; set; }

        /// <summary>
        /// This de Kit's expiration date
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// This propertie let you know if the equipments are assigned to the teams
        /// </summary>
        public bool IsAssigned { get; set; }
    }
}