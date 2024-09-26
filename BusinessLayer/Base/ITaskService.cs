

namespace BusinessLayer.Base
{
    public interface ITaskService
    {
        Task<IEnumerable<DataLayer.Models.Task>> GetTasksByProjectIdAsync(Guid projectId);
        Task<DataLayer.Models.Task> GetTaskByIdAsync(Guid taskId);
        Task AddTaskAsync(DataLayer.Models.Task task);
        Task UpdateTaskAsync(DataLayer.Models.Task task);
        Task DeleteTaskAsync(Guid taskId);
    }
}
