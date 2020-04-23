using System.Collections.Generic;
using Business.Entities;

namespace Business.Interfaces
{
    public interface IDebtRepository
    {
        bool CreateDebt(Debt debt);
        List<Debt> GetDebt();
    }
}
