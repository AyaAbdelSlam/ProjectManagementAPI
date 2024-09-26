using DataLayer.Vaildation;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{

    public class Project
    {
        [Key]
        public Guid ProjectId { get; set; }

        [Required, StringLength(100, ErrorMessage = "Project name must be between 1 and 100 characters.")]
        public string ProjectName { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(ProjectValidation), nameof(ProjectValidation.ValidateEndDate))]
        public DateTime EndDate { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Budget must be a positive number.")]
        public decimal Budget { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Owner name must be between 1 and 100 characters.")]
        public string Owner { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Status cannot be longer than 20 characters.")]
        public string Status { get; set; }
    }

}
