using BusinessLayer.Base;
using Microsoft.AspNetCore.Mvc;

namespace ProjectManagmentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _tasksService;

        public TasksController(ITaskService taskService)
        {
            _tasksService = taskService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTasksByProjectId(Guid projectId)
        {
            var projects = await _tasksService.GetTasksByProjectIdAsync(projectId);
            return Ok(projects);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskById(Guid id)
        {
            var project = await _tasksService.GetTaskByIdAsync(id);
            if (project == null) return NotFound();
            return Ok(project);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProject([FromBody] DataLayer.Models.Task task)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _tasksService.AddTaskAsync(task);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(Guid id, [FromBody] DataLayer.Models.Task task)
        {
            if (id != task.ProjectId) return BadRequest();
            await _tasksService.UpdateTaskAsync(task);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(Guid id)
        {
            await _tasksService.DeleteTaskAsync(id);
            return Ok();
        }
    }
}
