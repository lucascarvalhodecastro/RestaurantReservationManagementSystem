using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantReservationManagementSystem.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        [ForeignKey("Table")]
        public int TableID { get; set; }

        [Required]
        public int NumberOfGuests { get; set; }

        [Required]
        public DateTime ReservationDateAndTime { get; set; }
    }
}
