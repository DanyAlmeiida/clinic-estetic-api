using ClinicEsteticManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.DTOs.GeneralDiseases
{
    public class UpdateGeneralDiseasesDto :  BaseDto, IGeneralDiseases
    {
        public DateTime DiabetesDate { get; set; }
        public string DiabetesType { get; set; }
        public DateTime CholesterolDate { get; set; }
        public double CholesterolValue { get; set; }
        public DateTime TriglyceridesDate { get; set; }
        public double TriglyceridesValue { get; set; }
        public bool HasVascularProblems { get; set; }
        public bool HasChilblains { get; set; }
        public bool HasEpilepsy { get; set; }
        public bool HasSkinProblems { get; set; }
        public bool HasHypotension { get; set; }
        public bool HasHyperthyroidism { get; set; }
        public bool HasHemophiliac { get; set; }
        public string FoodIntolerance { get; set; }
        public string CancerBackground { get; set; }
        public string StressDegree { get; set; }
        public string Intestine { get; set; }
    }
}
