using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetricsManager.Controllers
{
    [Route("api/hdd")]
    [ApiController]
    public class HddMetricsController : ControllerBase
    {
        [HttpGet("agent/{agentId}/from/{fromTime}/to/{toTime}")]
        public IActionResult GetHddMetricsFromAgent([FromRoute] int agentId,
                                                    [FromRoute] TimeSpan fromTime,
                                                    [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

        [HttpGet("all/from/{fromTime}/to/{toTime}")]
        public IActionResult GetHddMetricsFromAll([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
