using System;
using System.Collections.Generic;
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
            debt.InitDate = DateTime.Now;
            return _debtRepository.CreateDebt(debt);
        }

        public List<Debt> GetDebt()
        {
            return _debtRepository.GetDebt();
        }

        public List<DebtDetail> GetDetailDebt(int id)
        {
            var debt = _debtRepository.GetDebtById(id);
            var details = new List<DebtDetail>();
            var total = debt.DebtValue;
            var percent = decimal.Parse(debt.DebtType) / 1200;
            var fee = debt.DebtValue / debt.FeeQty;

            for (var i = 0; i < debt.FeeQty; i++)
            {

                var detail = new DebtDetail
                {
                    NumberFee = i + 1,
                    Capital = total
                };
                
                var prevCapital = total;
                detail.Fee = fee + prevCapital * percent;
                detail.Interest = detail.Fee - fee;
                total = detail.Capital-fee;
                details.Add(detail);
            }

            return details;
        }
    }
}
