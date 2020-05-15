using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using Business.Interfaces;

namespace Persistence.Repositories
{
    public class EarningRepository : IEarningRepository
    {
        private readonly MainContext _context;

        public EarningRepository(MainContext context)
        {
            _context = context;
        }

        public List<Earning> GetEarnings()
        {
            return _context.Earnings.ToList();
        }
    }
}
