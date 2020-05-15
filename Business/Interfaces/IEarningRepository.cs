using System.Collections.Generic;
using Business.Entities;

namespace Business.Interfaces
{
    public interface IEarningRepository
    {
        List<Earning> GetEarnings();
    }
}
