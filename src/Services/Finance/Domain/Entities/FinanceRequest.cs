namespace FinanceAPI.Domain.Entities
{
    public class FinanceRequest
    {
        public int Id { get; set; }
        public string RequestNumber { get; set; }
        public decimal PaymentAmount { get; set; }
        public int PaymentPeriod { get; set; }
        public decimal TotalProfit { get; set; }
        public int Status { get; set; }
    }
}
