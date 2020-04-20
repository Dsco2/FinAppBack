namespace Business.Entities
{
    public class Debt
    {
        public int IdDebt { get; set; }        
        public string DebtName { get; set; }        
        public string DebtType { get; set; }        
        public int FeeQty { get; set; }        
        public string Debtor { get; set; }        
        public decimal DebtValue { get; set; }        
    }
}
