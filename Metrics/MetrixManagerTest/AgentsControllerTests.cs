using MetricsManager.Controllers;
using MetricsManager.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsManagerTests
{    
    public class AgentsControllerTests
    {
        private AgentsController _agentsController;

        public AgentsControllerTests()
        {
            _agentsController = new AgentsController(new AgentPool());
        }

        [Fact]
        public void RegisterAgent_ReturnOk()
        {
            var result = _agentsController.RegisterAgent(new AgentInfo());

            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void EnableAgentById_ReturnOk()
        {
            int agentId = 1;

            var result = _agentsController.EnableAgentById(agentId);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void DisableAgentById_ReturnOk()
        {
            int agentId = 1;

            var result = _agentsController.DisableAgentById(agentId);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetAllAgents_ReturnOk()
        {
            var result = _agentsController.GetAllAgents();

            Assert.IsAssignableFrom<IActionResult>(result);
        }

    }
}
