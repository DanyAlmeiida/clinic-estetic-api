using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain.ParamTables;

namespace ClinicEsteticManagement.Persistence.Repositories
{
    public class WorkActivityTypeRepository : GenericRepository<WorkActivityType>, IWorkActivityTypeRepository
    {
        private readonly DatabaseContext dbContext;

        public WorkActivityTypeRepository(DatabaseContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
