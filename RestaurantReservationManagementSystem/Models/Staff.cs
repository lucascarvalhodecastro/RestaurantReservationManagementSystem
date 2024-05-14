using System.ComponentModel.DataAnnotations;

namespace RestaurantReservationManagementSystem.Models
{
    public class Staff
    {
        [Key]
        public int StaffID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
