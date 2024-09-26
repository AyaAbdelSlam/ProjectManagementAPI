
using Microsoft.AspNetCore.Mvc;
using DataLayer.Models;
using BusinessLayer.Base;

namespace ProjectManagmentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProjects()
        {
            var projects = await _projectService.GetAllProjects();
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProjectById(Guid id)
        {
            var project = await _projectService.GetProjectById(id);
            if (project == null) return NotFound();
            return Ok(project);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProject([FromBody] Project project)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _projectService.AddProject(project);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProject(Guid id, [FromBody] Project project)
        {
            if (id != project.ProjectId) return BadRequest();
            await _projectService.UpdateProject(project);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(Guid id)
        {
            await _projectService.DeleteProject(id);
            return Ok();
        }
    }
}
