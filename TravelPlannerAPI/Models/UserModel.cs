using System;
using System.ComponentModel.DataAnnotations;

namespace TravelPlannerAPI.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string FullName { get; set; }
    }
}

