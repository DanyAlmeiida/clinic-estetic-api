using ClinicEsteticManagement.Application.DTOs.WorkActivityTypes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.WorkActivityTypes.Requests.Queries
{
    public class GetListWorkActivityTypeRequest : IRequest<List<WorkActivityTypeDto>>
    {
    }
}
