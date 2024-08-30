
namespace Infrastructure.Repositories
{
    public class FinanceRequestRepository : IFinanceRequestRepository
    {
        private readonly ApplicationDbContext _context;

        public FinanceRequestRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<FinanceRequest> AddAsync(FinanceRequest request)
        {
            await _context.FinanceRequests.AddAsync(request);
            await _context.SaveChangesAsync();
            return request;
        }
        public async Task<(IEnumerable<FinanceRequest> Requests, long TotalCount, long EligibleCount, long NotEligibleCount)> GetFinanceRequestsAsync(
             string requestNumber,
             int? status,
             int pageIndex,
             int pageSize)
        {
            var query = _context.FinanceRequests.AsQueryable();

            if (!string.IsNullOrEmpty(requestNumber))
            {
                query = query.Where(fr => fr.RequestNumber.Contains(requestNumber));
            }

            if (status is not null)
            {
                query = query.Where(fr => fr.Status == status);
            }

            var totalCount = await query.LongCountAsync();

            var eligibleCount = await query.CountAsync(fr => fr.Status == (int)RequestStatus.EligibleForConditions); // Eligible for conditions
            var notEligibleCount = await query.CountAsync(fr => fr.Status == (int)RequestStatus.NotEligibleForConditions); // Not eligible for the conditions

            var requests = await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return (requests, totalCount, eligibleCount, notEligibleCount);
        }


    }
}
