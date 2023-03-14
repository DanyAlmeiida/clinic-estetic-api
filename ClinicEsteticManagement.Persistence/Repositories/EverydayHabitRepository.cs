using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain;
using ClinicEsteticManagement.Domain.ClinicalData;
using Microsoft.EntityFrameworkCore;

namespace ClinicEsteticManagement.Persistence.Repositories
{
    public class EverydayHabitRepository : GenericRepository<EverydayHabit>, IEverydayHabitRepository
    {
        private readonly DatabaseContext _dbContext;
        public EverydayHabitRepository(DatabaseContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<EverydayHabit> GetById(Guid id)
        {
            var habit = await _dbContext.EverydayHabits
                .Include(x => x.WorkActivitys)
                .FirstAsync(x => x.Id == id);
            return habit;
        }
    }
}