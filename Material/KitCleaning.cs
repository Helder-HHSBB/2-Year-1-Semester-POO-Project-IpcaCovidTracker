using System;

namespace IpcaCovidTracker.Material
{
    internal class KitCleaning : Equipment
    {
        /// <summary>
        /// This properties represnt an Kit of cleaning material.
        /// </summary>
        /// <param name="kitCode"></param>
        /// <param name="expirationDate"></param>
        public KitCleaning(int kitCode, DateTime expirationDate) : base(kitCode, expirationDate)
        {
            this.EquipmentCode = kitCode;
            this.ExpirationDate = expirationDate;
        }
    }
}