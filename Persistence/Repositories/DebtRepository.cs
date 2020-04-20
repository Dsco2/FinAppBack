using Business.Interfaces;

namespace Persistence.Repositories
{
    public class DebtRepository : IDebtRepository
    {
        private readonly MainContext _context;

        public DebtRepository(MainContext context)
        {
            _context = context;
        }
    }
}
