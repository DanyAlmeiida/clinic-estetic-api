using ClinicEsteticManagement.Application.DTOs.Common;
using ClinicEsteticManagement.Domain.ClinicalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.DTOs.ClinicalData
{
    public class GynecologicalConditionsDto : BaseDto,IGynecologicalConditions
    {
        public DateTime PregnantDate { get ; set ; }
        public PregnancyTypeDto? PregnancyType { get ; set ; }
        public DateTime BreastFeedDate { get ; set ; }
        public DateTime MenstruatingDate { get ; set ; }
        public DateTime MenopauseDate { get ; set ; }
        public int ChildrenQuantity { get ; set ; }
    }
}
