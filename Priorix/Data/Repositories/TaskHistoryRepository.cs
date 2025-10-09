using Priorix.Core.Interfaces.Repositories;
using Priorix.Priorix.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Priorix.Data.Repositories
{
    public class TaskHistoryRepository : ITaskHistoryRepository
    {
        private readonly AppDbContext _context;

        public TaskHistoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(TaskHistory history)
        {
            _context.TaskHistories.Add(history);
            _context.SaveChanges();
        }

        public IEnumerable<TaskHistory> GetByTaskId(int taskId)
        {
            return _context.TaskHistories
                           .Where(h => h.TaskId == taskId)
                           .OrderByDescending(h => h.ChangeDate)
                           .ToList();
        }
    }
}


