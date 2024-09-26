using DataLayer.Vaildation;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    public class Task
    {
        [Key]
        public Guid TaskId { get; set; }

        [Required, StringLength(100, ErrorMessage = "Task name must be between 1 and 100 characters.")]
        public string TaskName { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string Description { get; set; }

        [Required]
        public string AssignedTo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(TaskValidation), nameof(TaskValidation.ValidateEndDate))]
        public DateTime EndDate { get; set; }

        [Required, StringLength(20, ErrorMessage = "Priority cannot be longer than 20 characters.")]
        public string Priority { get; set; }

        [Required, StringLength(20, ErrorMessage = "Status cannot be longer than 20 characters.")]
        public string Status { get; set; }

        [Required]
        public Guid ProjectId { get; set; }

        public Project Project { get; set; }
    }

}
