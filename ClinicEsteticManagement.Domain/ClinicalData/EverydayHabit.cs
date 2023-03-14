using ClinicEsteticManagement.Domain.Common;
using ClinicEsteticManagement.Domain.ParamTables;

namespace ClinicEsteticManagement.Domain.ClinicalData
{
    public class EverydayHabit : BaseDomainEntity
    {
        public Guid ClientId { get; set; }
        public bool Smoke { get; set; }
        public bool Drinks { get; set; }
        public string Feeding { get; set; }
        public string SleepQuality { get; set; }
        public float? WaterIntakePerDay { get; set; }
        public List<WorkActivityType> WorkActivitys { get; set; }
        public string WorkFunction { get; set; }
        public bool DoesPhysicalActivity { get; set; }
        public string PhysicalActivity { get; set; }
        public TimeSpan? TimeADayOfPhysicalActivty { get; set; }
        public TimeSpan? TimeADayWithoutPhysicalActivty { get; set; }
        public bool PainSensitive { get; set; }
        public string HairRemovalMethod { get; set; }
    }
}
