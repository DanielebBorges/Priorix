using Priorix.Core.Entities;

namespace Priorix.Core.Interfaces.IRepositories
{
    public interface IStatusesRepository
    {
        public List<Statuses> GetStatuses();
        public Statuses FindById(int id);
        public void CreateStatus(Statuses status);
        public void UpdateStatus(Statuses status);
        public void DeleteStatus(int id);
    }
}

