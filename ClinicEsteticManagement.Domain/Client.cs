using ClinicEsteticManagement.Domain.ClinicalData;
using ClinicEsteticManagement.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicEsteticManagement.Domain
{
    public class Client : BaseDomainEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "Date")]
        public DateTime BirthDate { get; set; }
        public string JobOccupation { get; set; }
        public string Observations { get; set; }
        public List<ClinicalInformation> ClinicalInformations { get; set; }
        public List<GeneralDisease> GeneralDiseases { get; set; }
    }
}