using Hotel_Booking_System.Models;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.DTO
{
    public class PaymentPostDto
    {
        public DateTime PaymentDate { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public PaymentMethod Method { get; set; }
        [Required]
        public PaymentStatus Status { get; set; }
        public int BookingId { get; set; }
    }
}
