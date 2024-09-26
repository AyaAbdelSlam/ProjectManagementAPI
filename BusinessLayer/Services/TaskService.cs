using BusinessLayer.Base;
using DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class TaskService:ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<IEnumerable<DataLayer.Models.Task>> GetTasksByProjectIdAsync(Guid projectId)=>
            await _taskRepository.GetTasksByProjectIdAsync(projectId);

        public async Task<DataLayer.Models.Task> GetTaskByIdAsync(Guid taskId) =>
            await _taskRepository.GetTaskByIdAsync(taskId);

        public async Task AddTaskAsync(DataLayer.Models.Task task)=>
            await _taskRepository.AddTaskAsync(task);

        public async Task UpdateTaskAsync(DataLayer.Models.Task task) =>
            await _taskRepository.UpdateTaskAsync(task);

        public async Task DeleteTaskAsync(Guid taskId)=>
            await _taskRepository.DeleteTaskAsync(taskId);

    }
}
