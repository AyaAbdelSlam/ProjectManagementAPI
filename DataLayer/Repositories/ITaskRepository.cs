

namespace DataLayer.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<Models.Task>> GetTasksByProjectIdAsync(Guid projectId);
        Task<Models.Task> GetTaskByIdAsync(Guid taskId);
        Task AddTaskAsync(Models.Task task);
        Task UpdateTaskAsync(Models.Task task);
        Task DeleteTaskAsync(Guid taskId);
    }
}
