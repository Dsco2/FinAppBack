using System;

namespace Business.Entities
{
    public class Earning
    {
        public int IdEarning { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime DateEarning { get; set; }
    }
}
