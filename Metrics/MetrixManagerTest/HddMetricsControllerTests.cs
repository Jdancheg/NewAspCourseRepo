using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsManagerTests
{
    public class HddMetricsControllerTests
    {
        private HddMetricsController _hddMetricsController;

        public HddMetricsControllerTests()
        {
            _hddMetricsController = new HddMetricsController();
        }

        [Fact]
        public void GetHddMetricsFormAgent_ReturnOk()
        {
            int agetntId = 1;
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            var result = _hddMetricsController.GetHddMetricsFromAgent(agetntId, fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetHddMetricsFormAll_ReturnOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            var result = _hddMetricsController.GetHddMetricsFromAll(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
