using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain;
using ClinicEsteticManagement.Domain.ClinicalData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Persistence.Repositories
{
    public class ClinicalInformationRepository : GenericRepository<ClinicalInformation>, IClinicalInformationRepository
    {
        private readonly DatabaseContext _dbContext;
        public ClinicalInformationRepository(DatabaseContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}
