using Priorix.Core.Entities.Metrics;
using Priorix.Core.Interfaces.Repositories;
using Priorix.Infrastructure.Data; 
using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using System.Linq;

namespace Priorix.Infrastructure.Repositories
{
    public class PriorizationMetricsRepository : IPriorizationMetricsRepository
    {
        private readonly ApplicationDbContext _context;

        public PriorizationMetricsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(PriorizationMetrics metrics)
        {
            _context.PriorizationMetrics.Add(metrics);
            _context.SaveChanges();
        }

        public void Update(PriorizationMetrics metrics)
        {
            _context.Attach(metrics).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public PriorizationMetrics GetByTaskId(int taskId)
        {
            return _context.PriorizationMetrics
                           .FirstOrDefault(m => m.TaskId == taskId);
        }

        public IEnumerable<PriorizationMetrics> GetAll()
        {
            return _context.PriorizationMetrics.ToList();
        }
    }
}