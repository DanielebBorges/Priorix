using Priorix.Priorix.Core.Entities;
using Task = Priorix.Priorix.Core.Entities.Task;

namespace Priorix.Priorix.Core.Interfaces.IRepositories
{
    public interface ITaskRepository
    {
        public List<Task> GetTasks();
        public Task FindById(int id);
        public void AddTask(Task task);
        public void UpdateTask(Task task);
        public void DeleteTask(int id);
        public bool TaskExists(int id);
    }
}

