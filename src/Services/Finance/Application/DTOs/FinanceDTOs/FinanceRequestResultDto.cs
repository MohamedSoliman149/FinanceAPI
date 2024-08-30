namespace FinanceAPI.Application.DTOs.FinanceDTOs
{
    public class FinanceRequestResultDto
    {
        public PaginatedResult<FinanceRequestDto> PaginatedResult { get; set; }
        public long EligibleCount { get; set; }
        public long NotEligibleCount { get; set; }
    }
}
