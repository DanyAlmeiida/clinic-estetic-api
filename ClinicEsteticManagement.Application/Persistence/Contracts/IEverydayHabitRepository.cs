using ClinicEsteticManagement.Domain.ClinicalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Persistence.Contracts
{
    public interface IEverydayHabitRepository : IGenericRepository<EverydayHabit>
    {
        public Task<EverydayHabit> GetById(Guid id);
    }
}
