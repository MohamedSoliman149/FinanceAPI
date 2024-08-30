namespace Application.Interfaces.Repository
{
    public interface IFinanceRequestRepository
    {
        Task<FinanceRequest> AddAsync(FinanceRequest request);
        Task<(IEnumerable<FinanceRequest> Requests, long TotalCount, long EligibleCount, long NotEligibleCount)> GetFinanceRequestsAsync(
             string requestNumber,
             int? status,
             int pageIndex,
             int pageSize);
    }
}
