using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.DTOs.PregnancyTypes
{
    public class CreatePregnancyTypeDto : IPregnancyTypeDto
    {
        public string Type { get; set; }
    }
}
