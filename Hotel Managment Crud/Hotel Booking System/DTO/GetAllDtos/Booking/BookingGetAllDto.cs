using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.DTO.GetAllDtos.Booking
{
    public class BookingGetAllDto
    {
        public int Id { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalAmount { get; set; }
        public BookingStatus Status { get; set; }
        public PaymentForBookingGetAllDto Payment { get; set; }
        public int CustomerId { get; set; }
        public CustomerForBookingGetAllDto Customer { get; set; }
        public int RoomId { get; set; }
        public RoomForBookingGetAllDto Room { get; set; }
    }
}
