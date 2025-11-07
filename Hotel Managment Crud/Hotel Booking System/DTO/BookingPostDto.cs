using Hotel_Booking_System.Models;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.DTO
{
    public class BookingPostDto
    {
        [Required]
        public DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
        [Range(0,double.MaxValue, ErrorMessage = "Please Enter a valid Amount")]
        public decimal TotalAmount { get; set; }
        public BookingStatus Status { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int RoomId { get; set; }
    }
}
