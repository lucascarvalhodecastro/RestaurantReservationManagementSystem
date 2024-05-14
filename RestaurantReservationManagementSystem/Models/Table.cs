using System.ComponentModel.DataAnnotations;

namespace RestaurantReservationManagementSystem.Models
{
    public class Table
    {
        [Key]
        public int TableID { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public string Location { get; set; }
    }
}
