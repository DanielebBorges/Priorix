using Priorix.Core.Entities;
using Priorix.Core.Interfaces.IRepositories;
using Priorix.Core.Interfaces.IServices;

namespace Priorix.Core.Service
{
    public class StatusService : IStatusesService
    {
        private IStatusesRepository _statusRepository;

        public StatusService(IStatusesRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }

        public List<Statuses> GetAllStatuses()
        {
            return _statusRepository.GetStatuses();
        }

        public Statuses GetStatusById(int id)
        {
            return _statusRepository.FindById(id);
        }

        public void CreateStatus(Statuses status)
        {
            _statusRepository.CreateStatus(status);
        }

        public void UpdateStatus(Statuses status)
        {
            _statusRepository.UpdateStatus(status);
        }

        public void DeleteStatus(int id)
        {
            _statusRepository.DeleteStatus(id);
        }
    }
}
