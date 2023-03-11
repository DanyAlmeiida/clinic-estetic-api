using ClinicEsteticManagement.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicEsteticManagement.Domain.ClinicalData
{
    public class ClinicalInformation : BaseDomainEntity
    {
        public Guid ClientId { get; set; }
        public bool IsLeftHanded { get; set; }
        public string MentalState { get; set; }
        public string ClinicalBackground { get; set; }
        public string Alergies { get; set; }
        public string Medicines { get; set; }
        public int MaxBloodPressure { get; set; }
        public int MinBloodPressure { get; set; }
        public int HearRate { get; set; }
        public bool HasRadioactiveDevices { get; set; }
        public bool HasProteses { get; set; }
        public bool HasPacemaker { get; set; }
        public bool HasImplants { get; set; }
        public bool HasIntraUterineDevice { get; set; }
        public string AgainstIndications { get; set; }
        public string Surgeries { get; set; }
        [ForeignKey("GynecologicalConditionsId")]
        public GynecologicalConditions? GynecologicalConditions { get; set; }
    }
}
