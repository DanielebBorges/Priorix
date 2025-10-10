using System.Collections.Generic;
using Priorix.Core.Entities;
using Priorix.Priorix.Core.Entities;

namespace Priorix.Core.Interfaces
{
    public interface ITaskHistoryRepository
    {
        void Add(TaskHistory history);
        List<TaskHistory> GetByTaskId(int taskId);
    }
}
