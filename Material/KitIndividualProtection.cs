using System;

namespace IpcaCovidTracker.Material

{
    /// <summary>
    /// This properties represnt an Kit of individual protection material.
    /// </summary>
    internal class KitIndividualProtection : Equipment
    {
        public KitIndividualProtection(int kitCode, DateTime expirationDate) : base(kitCode, expirationDate)
        {
            this.EquipmentCode = kitCode;
            this.ExpirationDate = expirationDate;
        }
    }
}