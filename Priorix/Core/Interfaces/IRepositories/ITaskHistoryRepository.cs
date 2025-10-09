using global::Priorix.Priorix.Core.Entities;
namespace Priorix.Core.Interfaces.Repositories
{
    public interface ITaskHistoryRepository
    {
        void Add(TaskHistory history);
        IEnumerable<TaskHistory> GetByTaskId(int taskId);
    }
}


