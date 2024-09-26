using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using Task = DataLayer.Models.Task;

namespace DataLayer
{
    public class ProjectManagementContext: DbContext
    {
        public ProjectManagementContext(DbContextOptions<ProjectManagementContext> options)
        : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}
