using MetricsAgent.Models;

namespace MetricsAgent.Services
{
    public interface ICpuMetricsRepository : IRepository<CpuMetrics>
    {
        IList<CpuMetrics> GetByTimePeriod(TimeSpan fromTime, TimeSpan toTime);
    }
}
