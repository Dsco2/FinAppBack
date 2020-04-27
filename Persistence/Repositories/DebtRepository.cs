using System.Collections.Generic;
using System.Linq;
using Business.Entities;
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

        public bool CreateDebt(Debt debt)
        {
            _context.Debts.Add(debt);
            return _context.SaveChanges() > 0;
        }

        public List<Debt> GetDebt()
        {
            return _context.Debts.ToList();
        }

        public Debt GetDebtById(int id)
        {
            return _context.Debts
                .FirstOrDefault(x => x.IdDebt == id);
        }
    }
}
