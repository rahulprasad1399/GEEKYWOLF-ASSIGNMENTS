using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.DTO.GetAllDtos.Booking
{
    public class PaymentForBookingGetAllDto
    {
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; }
    }
}
