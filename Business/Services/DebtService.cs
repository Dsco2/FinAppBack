using Business.Entities;
using Business.Interfaces;

namespace Business.Services
{
    public class DebtService : IDebtService
    {
        private readonly IDebtRepository _debtRepository;

        public DebtService(IDebtRepository debtRepository)
        {
            _debtRepository = debtRepository;
        }

        public bool CreateDebt(Debt debt)
        {
            return _debtRepository.CreateDebt(debt);
        }
    }
}
