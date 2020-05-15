using System.Collections.Generic;
using Business.Entities;

namespace Business.Interfaces
{
    public interface IEarningService
    {
        List<Earning> GetEarning();
    }
}
