namespace FinanceAPI.Application.Features.FinanceRequestFeatures.Commands.CreateFinanceRequest
{
    public class CreateFinanceRequestCommand : ICommand<Result<FinanceRequestDto>>
    {
        public decimal PaymentAmount { get; set; }
        public int PaymentPeriod { get; set; }
        public decimal TotalProfit { get; set; }
    }
}
