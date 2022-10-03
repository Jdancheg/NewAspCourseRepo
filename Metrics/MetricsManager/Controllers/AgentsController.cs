using MetricsManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace MetricsManager.Controllers
{
    [Route("api/agents")]
    [ApiController]
    public class AgentsController : ControllerBase
    {
        public AgentsController(AgentPool agentPool)
        {
            _agentPool = agentPool;
        }

        private AgentPool _agentPool;

        [HttpPost("register")]
        public IActionResult RegisterAgent([FromBody] AgentInfo agentInfo)
        {
            if (agentInfo != null)
            {
                _agentPool.Add(agentInfo);
            }
            return Ok();
        }

        [HttpPost("enable")]
        public IActionResult EnableAgentById([FromRoute] int agentId)
        {
            if (_agentPool.Values.ContainsKey(agentId))
            {
                _agentPool.Values[agentId].Enable = true;
            }
            return Ok();
        }

        [HttpPost("disable")]
        public IActionResult DisableAgentById([FromRoute] int agentId)
        {
            if (_agentPool.Values.ContainsKey(agentId))
            {
                _agentPool.Values[agentId].Enable = false;
            }
            return Ok();
        }

        [HttpPost("getall")]
        public IActionResult GetAllAgents()
        {
            return Ok(_agentPool.Get());
        }

    }
}
