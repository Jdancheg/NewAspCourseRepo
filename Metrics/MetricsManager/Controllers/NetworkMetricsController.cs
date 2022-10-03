﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetricsManager.Controllers
{
    [Route("api/network")]
    [ApiController]
    public class NetworkMetricsController : ControllerBase
    {
        [HttpGet("agent/{agentId}/from/{fromTime}/to/{toTime}")]
        public IActionResult GetNetworkMetricsFromAgent([FromRoute] int agentId,
                                                    [FromRoute] TimeSpan fromTime,
                                                    [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

        [HttpGet("all/from/{fromTime}/to/{toTime}")]
        public IActionResult GetNetworkMetricsFromAll([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
