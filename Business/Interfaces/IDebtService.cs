using Business.Entities;

namespace Business.Interfaces
{
    public interface IDebtService
    {
        bool CreateDebt(Debt debt);
    }
}
