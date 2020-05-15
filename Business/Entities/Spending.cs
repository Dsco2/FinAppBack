﻿using System;

namespace Business.Entities
{
    public class Spending
    {
        public int IdSpending { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime DateSpending { get; set; }
    }
}
