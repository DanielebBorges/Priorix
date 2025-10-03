using Priorix.Core.Entities.Metrics;

namespace Priorix.Core.Interfaces.Services
{
    public interface IPriorizationService
    {
        PriorizationMetrics CalculateAndSaveMetrics(int taskId, double reach, double impact, double confidence, double effort);

        IEnumerable<Task> GetPrioritizedTasks();

    }
}