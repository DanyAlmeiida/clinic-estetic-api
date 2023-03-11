using ClinicEsteticManagement.Domain.ClinicalData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.DTOs.ClinicalData
{
    public interface IGynecologicalConditions
    {
        public DateTime? PregnantDate { get; set; }
        public PregnancyTypeDto? PregnancyType { get; set; }
        public DateTime? BreastFeedDate { get; set; }
        public DateTime? MenstruatingDate { get; set; }
        public DateTime? MenopauseDate { get; set; }
        public int ChildrenQuantity { get; set; }
    }
}
