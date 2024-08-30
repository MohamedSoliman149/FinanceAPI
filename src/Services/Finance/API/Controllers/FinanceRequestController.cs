

namespace FinanceAPI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class FinanceRequestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FinanceRequestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateFinanceRequest(CreateFinanceRequestCommand command)
        {
            var result = await _mediator.Send(command);
            if (result.IsSuccess)
                return Ok(result.Value);
            return BadRequest(result.Error);
        }

        [HttpGet]
        public async Task<IActionResult> GetFinanceRequests([FromQuery] GetFinanceRequestsQuery query)
        {
            var result = await _mediator.Send(query);
            if (result.IsSuccess)
                return Ok(result.Value);
            return BadRequest(result.Error);
        }
    }
}
