using Hotel_Booking_System.Models;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.DTO
{
    public class ReviewDto
    {
        [Required]
        public int Rating { get; set; }
        public string Comment { get; set; }
        [Required]
        public DateTime ReviewDate { get; set; }
        [Required]
        public int HotelId { get; set; }
        [Required]
        public int CustomerId { get; set; }
    }
}
