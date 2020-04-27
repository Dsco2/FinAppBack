using System.Collections.Generic;
using Business.Entities;

namespace Business.Interfaces
{
    public interface IDebtService
    {
        bool CreateDebt(Debt debt);
        List<Debt> GetDebt();
        List<DebtDetail> GetDetailDebt(int id);
    }
}
