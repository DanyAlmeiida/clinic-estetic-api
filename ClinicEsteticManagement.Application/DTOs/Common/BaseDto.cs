using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.DTOs.Common
{
    public class BaseDto
    {
        public Guid Id { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
