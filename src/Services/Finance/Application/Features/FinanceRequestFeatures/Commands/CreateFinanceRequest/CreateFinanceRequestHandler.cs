namespace FinanceAPI.Application.Features.FinanceRequestFeatures.Commands.CreateFinanceRequest
{
    public class CreateFinanceRequestHandler : ICommandHandler<CreateFinanceRequestCommand, Result<FinanceRequestDto>>
    {
        private readonly IFinanceRequestRepository _financeRequestRepository;

        public CreateFinanceRequestHandler(IFinanceRequestRepository financeRequestRepository)
        {
            _financeRequestRepository = financeRequestRepository;
        }

        public async Task<Result<FinanceRequestDto>> Handle(CreateFinanceRequestCommand request, CancellationToken cancellationToken)
        {
            var financeRequest = new FinanceRequest
            {
                RequestNumber = GenerateRequestNumber(),
                PaymentAmount = request.PaymentAmount,
                PaymentPeriod = request.PaymentPeriod,
                TotalProfit = request.TotalProfit,
                Status = 1
            };

            await _financeRequestRepository.AddAsync(financeRequest);

            var financeRequestDto = new FinanceRequestDto
            {
                Id = financeRequest.Id,
                RequestNumber = financeRequest.RequestNumber,
                PaymentAmount = financeRequest.PaymentAmount,
                PaymentPeriod = financeRequest.PaymentPeriod,
                TotalProfit = financeRequest.TotalProfit,
                Status = RequestStatus.Pending.ToString()
            };

            return Result<FinanceRequestDto>.Success(financeRequestDto);
        }

        private string GenerateRequestNumber()
        {
            return $"REQ-{DateTime.Now:yyyyMMdd}-{Guid.NewGuid().ToString("N").Substring(0, 8)}";
        }
    }
}
