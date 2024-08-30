namespace FinanceAPI.Application.Features.FinanceRequestFeatures.Queries.GetFinanceRequests
{
    public class GetFinanceRequestsHandler : IQueryHandler<GetFinanceRequestsQuery, Result<FinanceRequestResultDto>>
    {
        private readonly IFinanceRequestRepository _financeRequestRepository;

        public GetFinanceRequestsHandler(IFinanceRequestRepository financeRequestRepository)
        {
            _financeRequestRepository = financeRequestRepository;
        }

        public async Task<Result<FinanceRequestResultDto>> Handle(GetFinanceRequestsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var pageIndex = request.PageIndex ?? 1;
                var pageSize = request.PageSize ?? 10;
                var (financeRequests, totalCount, eligibleCount, notEligibleCount) = await _financeRequestRepository.GetFinanceRequestsAsync(
                    request.RequestNumber,
                    request.Status,
                    pageIndex,
                    pageSize
                );

                var financeRequestDtos = financeRequests.Select(fr => new FinanceRequestDto
                {
                    Id = fr.Id,
                    RequestNumber = fr.RequestNumber,
                    PaymentAmount = fr.PaymentAmount,
                    PaymentPeriod = fr.PaymentPeriod,
                    TotalProfit = fr.TotalProfit,
                    Status = ((RequestStatus)fr.Status).ToString()
                }).ToList();

                var paginatedResult = new PaginatedResult<FinanceRequestDto>(
                    pageIndex,
                    pageSize,
                    totalCount,
                    financeRequestDtos
                );

                var result = new FinanceRequestResultDto
                {
                    PaginatedResult = paginatedResult,
                    EligibleCount = eligibleCount,
                    NotEligibleCount = notEligibleCount
                };

                return Result<FinanceRequestResultDto>.Success(result);
            }
            catch (Exception ex)
            {

                return Result<FinanceRequestResultDto>.Failure("An error occurred while processing your request. Please try again later.");
            }
      
        }
    }
}
