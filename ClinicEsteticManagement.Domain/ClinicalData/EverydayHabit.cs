using ClinicEsteticManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Domain.ClinicalData
{
    public class EverydayHabit : BaseDomainEntity
    {
        public bool Smoke { get; set; }
        public bool Drinks { get; set; }
        public string Feeding { get; set; }
        public string SleepQuality { get; set; }
        public float WaterIntakePerDay { get; set; }
        List<string>? WorkActivity { get; set; }
        public string WorkFunction { get; set; }
        public bool DoesPhysicalActivity { get; set; }
        public string PhysicalActivity { get; set; }
        public TimeSpan? TimeADayOfPhysicalActivty { get; set; }
        public TimeSpan? TimeADayWithoutPhysicalActivty { get; set; }
        public bool PainSensitive { get; set; }
        public string HairRemovalMethod { get; set; }
    }
}
