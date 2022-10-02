using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsManagerTests
{
    public class RamMetricsControllerTests
    {
        private RamMetricsController _ramMetricsController;

        public RamMetricsControllerTests()
        {
            _ramMetricsController = new RamMetricsController();
        }

        [Fact]
        public void GetRamMetricsFormAgent_ReturnOk()
        {
            int agetntId = 1;
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            var result = _ramMetricsController.GetRamMetricsFromAgent(agetntId, fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetRamMetricsFormAll_ReturnOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            var result = _ramMetricsController.GetRamMetricsFromAll(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
