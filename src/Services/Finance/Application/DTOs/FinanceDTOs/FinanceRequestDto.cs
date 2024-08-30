namespace FinanceAPI.Application.DTOs.FinanceDTOs
{
    public class FinanceRequestDto
    {
        public int Id { get; set; }
        public string RequestNumber { get; set; }
        public decimal PaymentAmount { get; set; }
        public int PaymentPeriod { get; set; }
        public decimal TotalProfit { get; set; }
        public string Status { get; set; }
    }
}
