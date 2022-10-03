using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsManagerTests
{
    public class CpuMetricsControllerTests
    {
        private CpuMetricsController _cpuMetricsController;

        public CpuMetricsControllerTests()
        {
            _cpuMetricsController = new CpuMetricsController();
        }

        [Fact]
        public void GetCpuMetricsFromAgent_ReturnOk()
        {
            int agetntId = 1;
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);
            
            var result = _cpuMetricsController.GetCpuMetricsFromAgent(agetntId, fromTime, toTime);
            
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetCpuMetricsFromAll_ReturnOk()
        {               
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);
            
            var result = _cpuMetricsController.GetCpuMetricsFromAll(fromTime, toTime);
            
            Assert.IsAssignableFrom<IActionResult>(result);
        }

    }
}
