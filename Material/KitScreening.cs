using System;

namespace IpcaCovidTracker.Material
{
    /// <summary>
    /// This properties represnt an Kit of screening material.
    /// </summary>
    internal class KitScreening : Equipment
    {
        public KitScreening(int kitCode, DateTime expirationDate)
           : base(kitCode, expirationDate)
        {
            this.EquipmentCode = kitCode;
            this.ExpirationDate = expirationDate;
        }
    }
}