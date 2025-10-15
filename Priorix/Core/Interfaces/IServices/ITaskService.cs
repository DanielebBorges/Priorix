using Priorix.Priorix.Core.Entities;
using Task = Priorix.Priorix.Core.Entities.Task;

namespace Priorix.Priorix.Core.Interfaces.IServices
{
    public interface ITaskService
    {
        public List<Task> GetAllTasks();
        public Task GetTaskById(int id);
        public void CreateTask(Task task);
        public void UpdateTask(Task task);
        public void DeleteTask(int id);
        public bool TaskExists(int id);
    }
}

