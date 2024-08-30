namespace FinanceAPI.Application.Features.FinanceRequestFeatures.Commands.CreateFinanceRequest
{
    public class CreateFinanceRequestCommandValidator:AbstractValidator<CreateFinanceRequestCommand>
    {
        public CreateFinanceRequestCommandValidator()
        {
            RuleFor(x => x.PaymentAmount)
              .GreaterThan(0).WithMessage("Payment amount must be greater than zero.");

            RuleFor(x => x.PaymentPeriod)
                .GreaterThan(0).WithMessage("Payment period must be greater than zero.");

            RuleFor(x => x.TotalProfit)
                .GreaterThanOrEqualTo(0).WithMessage("Total profit must be zero or greater.");
        }
    }
}
