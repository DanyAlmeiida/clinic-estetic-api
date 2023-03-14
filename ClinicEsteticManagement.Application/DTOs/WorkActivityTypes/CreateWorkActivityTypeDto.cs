using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.DTOs.WorkActivityTypes
{
    public class CreateWorkActivityTypeDto: IWorkActivityTypeDto
    {
        public string Type { get; set; }
    }
}
