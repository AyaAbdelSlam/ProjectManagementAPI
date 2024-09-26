using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace DataLayer.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ProjectManagementContext _context;

        public ProjectRepository(ProjectManagementContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Project>> GetAllProjects() =>
            await _context.Projects.ToListAsync();

        public async Task<Project> GetProjectById(Guid id) =>
            await _context.Projects.FindAsync(id);

        public async Task AddProject(Project project)
        {
            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProject(Project project)
        {
            _context.Projects.Update(project);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProject(Guid id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project != null)
            {
                _context.Projects.Remove(project);
                await _context.SaveChangesAsync();
            }
        }
    }

}
