using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain.ClinicalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Persistence.Repositories
{
    public class GynecologicalConditionRepository : GenericRepository<GynecologicalConditions>, IGynecologicalConditionRepository
    {
        private readonly DatabaseContext _dbContext;
        public GynecologicalConditionRepository(DatabaseContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}
