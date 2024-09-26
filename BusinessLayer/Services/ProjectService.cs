using BusinessLayer.Base;
using DataLayer.Models;
using DataLayer.Repositories;
using Task = System.Threading.Tasks.Task;

namespace BusinessLayer.Services
{
    public class ProjectService: IProjectService
    {
        private IProjectRepository _repository;
        public ProjectService(IProjectRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Project>> GetAllProjects() =>
            await _repository.GetAllProjects();

        public async Task<Project> GetProjectById(Guid id) =>
            await _repository.GetProjectById(id);

        public async Task AddProject(Project project) =>
            await _repository.AddProject(project);


        public async Task UpdateProject(Project project) =>
            await _repository.UpdateProject(project);

        public async Task DeleteProject(Guid id) =>
            await _repository.DeleteProject(id);
        
    }
}
