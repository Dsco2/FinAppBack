namespace Business.Entities
{
    public class DebtDetail
    {
        public int IdDebtDetail { get; set; }        
        public int IdDebt { get; set; }
        public decimal Interest { get; set; }
        public decimal Capital { get; set; }
        public decimal Fee { get; set; }
        public decimal NumberFee { get; set; }
    }
}
