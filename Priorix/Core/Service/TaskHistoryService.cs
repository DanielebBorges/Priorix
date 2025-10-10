using Priorix.Core.Interfaces;
using Priorix.Core.Interfaces.Repositories;
using Priorix.Priorix.Core.Entities;
using System;
using System.Collections.Generic;

namespace Priorix.Core.Services
{
    public class TaskHistoryService
    {
        private readonly ITaskHistoryRepository _historyRepository;

        public TaskHistoryService(ITaskHistoryRepository historyRepository)
        {
            _historyRepository = historyRepository;
        }

        public void RegisterAction(int taskId, string action)
        {
            var history = new TaskHistory
            {
                TaskId = taskId,
                Action = action
            };

            _historyRepository.Add(history);
        }

        public List<TaskHistory> GetHistory(int taskId)
        {
            return _historyRepository.GetByTaskId(taskId);
        }
    }
}

