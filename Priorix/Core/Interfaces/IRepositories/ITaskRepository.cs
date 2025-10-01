namespace Priorix.Priorix.Core.Interfaces.IRepositories
{
    public interface ITaskRepository
    {
          void Add(Task task);
          IEnumerable<Task> GetAll();
          Task GetById(int id);
          void Update(Task task);
    }
}
