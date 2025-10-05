using Priorix.Core.Entities;
using Priorix.Core.Interfaces.IRepositories;
using Priorix.Priorix.Data.Context;

namespace Priorix.Data.Repositories
{
    public class StatusesRepository : IStatusesRepository
    {
        private readonly DataContext _db;

        public StatusesRepository(DataContext db)
        {
            _db = db;
        }

        public List<Statuses> GetStatuses()
        {
            throw new NotImplementedException();
        }

        public Statuses FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateStatus(Statuses status)
        {
            throw new NotImplementedException();
        }

        public void UpdateStatus(Statuses status)
        {
            throw new NotImplementedException();
        }

        public void DeleteStatus(int id)
        {
            throw new NotImplementedException();
        }
    }
}
