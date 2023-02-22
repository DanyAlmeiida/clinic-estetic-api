using ClinicEsteticManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.DTOs.ClinicalData
{
    public class PregnancyTypeDto : BaseDto,IPregnancyType
    {
        public string Type { get; set; }
    }
}
