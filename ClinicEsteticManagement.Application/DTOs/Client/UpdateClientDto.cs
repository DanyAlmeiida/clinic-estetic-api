﻿using ClinicEsteticManagement.Application.DTOs.ClinicalData;
using ClinicEsteticManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.DTOs.Client
{
    public class UpdateClientDto : BaseDto, IClientDto
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string JobOccupation { get; set; }
        public string Observations { get; set; }

    }
}
