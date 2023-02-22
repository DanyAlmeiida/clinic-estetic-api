using ClinicEsteticManagement.Application.DTOs.Common;
using ClinicEsteticManagement.Domain.ClinicalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.DTOs.ClinicalData
{
    public class ClinicalInformationDto : BaseDto,IClinicalInformationDto
    {
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
        public GynecologicalConditionsDto? GynecologicalConditions { get; set; }
    }
}
