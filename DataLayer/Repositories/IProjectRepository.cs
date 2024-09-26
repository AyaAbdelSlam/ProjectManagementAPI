using DataLayer.Models;

namespace DataLayer.Repositories
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetAllProjects();
        Task<Project> GetProjectById(Guid id);
        System.Threading.Tasks.Task AddProject(Project project);
        System.Threading.Tasks.Task UpdateProject(Project project);
        System.Threading.Tasks.Task DeleteProject(Guid id);
    }
}
