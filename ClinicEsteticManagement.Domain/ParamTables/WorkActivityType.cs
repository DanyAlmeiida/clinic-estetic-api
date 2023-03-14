using ClinicEsteticManagement.Domain.ClinicalData;
using ClinicEsteticManagement.Domain.Common;

namespace ClinicEsteticManagement.Domain.ParamTables
{
    public class WorkActivityType : BaseDomainEntity
    {
        public string Type { get; set; }

        public ICollection<EverydayHabit> Everydayhabits {get;set;}
    }
}
