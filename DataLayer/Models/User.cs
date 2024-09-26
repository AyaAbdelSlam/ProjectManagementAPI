
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string RoleName { get; set; }
    }
}
