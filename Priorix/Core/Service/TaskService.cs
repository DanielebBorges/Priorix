﻿using Priorix.Priorix.Core.Entities;
using Priorix.Priorix.Core.Interfaces.IRepositories;
using Priorix.Priorix.Core.Interfaces.IServices;

namespace Priorix.Priorix.Core.Service
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void CreateTask(Task task)
        {
            _taskRepository.AddTask(task);
        }

        public List<Task> GetAllTasks()
        {
            return _taskRepository.GetTasks();
        }

        public Task GetTaskById(int id)
        {
            try
            {
                return _taskRepository.FindById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateTask(Task task)
        {
            _taskRepository.UpdateTask(task);
        }

        public void DeleteTask(int id)
        {
            _taskRepository.DeleteTask(id);
        }

        public bool TaskExists(int id)
        {
            return _taskRepository.TaskExists(id);
        }
    }
}
