using Priorix.Core.Entities;

namespace Priorix.Core.Interfaces.IServices
{
    public interface IStatusesService
    {
        public List<Statuses> GetAllStatuses();
        public Statuses GetStatusById(int id);
        public void CreateStatus(Statuses status);
        public void UpdateStatus(Statuses status);
        public void DeleteStatus(int id);
    }
}
