using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsManagerTests
{
    public class NetworkMetricsControllerTests
    {
        private NetworkMetricsController _networkMetricsController;

        public NetworkMetricsControllerTests()
        {
            _networkMetricsController = new NetworkMetricsController();
        }

        [Fact]
        public void GetNetworkMetricsFormAgent_ReturnOk()
        {
            int agetntId = 1;
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            var result = _networkMetricsController.GetNetworkMetricsFromAgent(agetntId, fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetNetworkMetricsFormAll_ReturnOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            var result = _networkMetricsController.GetNetworkMetricsFromAll(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
