using ClinicEsteticManagement.Application.DTOs.ClinicalData;
using ClinicEsteticManagement.Application.DTOs.Common;
using ClinicEsteticManagement.Application.DTOs.GeneralDiseases;
using System.ComponentModel.DataAnnotations;

namespace ClinicEsteticManagement.Application.DTOs.Client
{
    public class ClientDto : BaseDto
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }
        public string JobOccupation { get; set; }
        public string Observations { get; set; }
        public List<ClinicalInformationDto>? clinicalInformation { get; set; }
        public List<GeneralDiseasesDto>? generalDiseases { get; set; }
    }
}
