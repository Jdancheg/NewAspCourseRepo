using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsManagerTests
{
    public class DotnetMetricsControllerTests
    {
        private DotnetMetricsController _dotnetMetricsController;

        public DotnetMetricsControllerTests()
        {
            _dotnetMetricsController = new DotnetMetricsController();
        }

        [Fact]
        public void GetDotnetMetricsFormAgent_ReturnOk()
        {            
            int agetntId = 1;
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);
            
            var result = _dotnetMetricsController.GetDotnetMetricsFromAgent(agetntId, fromTime, toTime);
            
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetDotnetMetricsFormAll_ReturnOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            var result = _dotnetMetricsController.GetDotnetMetricsFromAll(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

    }
}
