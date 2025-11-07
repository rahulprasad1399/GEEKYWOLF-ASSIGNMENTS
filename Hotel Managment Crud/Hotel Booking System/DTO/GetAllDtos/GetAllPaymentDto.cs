using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.DTO.GetAllDtos
{
    public class GetAllPaymentDto
    {
        public int Id { get; set; } 
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; }
        public int BookingId { get; set; }
        public BookingGetAllForPaymentsDto Booking { get; set; }
    }
}
