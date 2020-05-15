using System.Collections.Generic;
using Business.Entities;
using Business.Interfaces;

namespace Business.Services
{
    public class EarningService : IEarningService
    {
        private readonly IEarningRepository _earningRepository;

        public EarningService(IEarningRepository earningRepository)
        {
            _earningRepository = earningRepository;
        }

        public List<Earning> GetEarning()
        {
            return _earningRepository.GetEarnings();
        }
    }
}
