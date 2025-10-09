using Priorix.Core.Interfaces.Repositories;
using Priorix.Priorix.Core.Entities;
using System;
using System.Collections.Generic;

namespace Priorix.Core.Service
{
    public class TaskHistoryService
    {
        private readonly ITaskHistoryRepository _repository;

        public TaskHistoryService(ITaskHistoryRepository repository)
        {
            _repository = repository;
        }

        public void RegistrarHistorico(int taskId, int userId, string tipo, string valorAntigo, string valorNovo)
        {
            var history = new TaskHistory
            {
                TaskId = taskId,
                ChangedByUserId = userId,
                ChangeType = tipo,
                OldValue = valorAntigo,
                NewValue = valorNovo,
                ChangeDate = DateTime.UtcNow
            };

            _repository.Add(history);
        }

        public IEnumerable<TaskHistory> ObterHistorico(int taskId)
        {
            return _repository.GetByTaskId(taskId);
        }
    }
}


