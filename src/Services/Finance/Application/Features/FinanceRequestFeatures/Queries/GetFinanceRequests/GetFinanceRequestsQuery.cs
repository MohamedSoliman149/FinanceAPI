
namespace FinanceAPI.Application.Features.FinanceRequestFeatures.Queries.GetFinanceRequests
{
    public class GetFinanceRequestsQuery : IQuery<Result<FinanceRequestResultDto>>
    {
        public string? RequestNumber { get; set; }
        public int? Status { get; set; }
        public int? PageIndex { get; set; } = 1;
        public int? PageSize { get; set; } = 10;
    }
}
