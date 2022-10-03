using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetricsManager.Controllers
{
    [Route("api/ram")]
    [ApiController]
    public class RamMetricsController : ControllerBase
    {
        [HttpGet("agent/{agentId}/from/{fromTime}/to/{toTime}")]
        public IActionResult GetRamMetricsFromAgent([FromRoute] int agentId,
                                                    [FromRoute] TimeSpan fromTime,
                                                    [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

        [HttpGet("all/from/{fromTime}/to/{toTime}")]
        public IActionResult GetRamMetricsFromAll([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
