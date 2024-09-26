using Microsoft.EntityFrameworkCore;


namespace DataLayer.Repositories
{
    public class TaskRepository: ITaskRepository
    {
            private readonly ProjectManagementContext _context;

            public TaskRepository(ProjectManagementContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Models.Task>> GetTasksByProjectIdAsync(Guid projectId)
            {
                return await _context.Tasks.Where(t => t.ProjectId == projectId).ToListAsync();
            }

            public async Task<Models.Task> GetTaskByIdAsync(Guid taskId)
            {
                return await _context.Tasks.FindAsync(taskId);
            }

            public async Task AddTaskAsync(Models.Task task)
            {
                _context.Tasks.Add(task);
                await _context.SaveChangesAsync();
            }

            public async Task UpdateTaskAsync(Models.Task task)
            {
                _context.Entry(task).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            public async Task DeleteTaskAsync(Guid taskId)
            {
                var task = await _context.Tasks.FindAsync(taskId);
                if (task != null)
                {
                    _context.Tasks.Remove(task);
                    await _context.SaveChangesAsync();
                }
            }


    }
}
