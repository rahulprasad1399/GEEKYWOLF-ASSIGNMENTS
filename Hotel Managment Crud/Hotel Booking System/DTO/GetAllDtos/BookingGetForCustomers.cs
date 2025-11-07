using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.DTO.GetAllDtos
{
    public class BookingGetForCustomers
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalAmount { get; set; }
        public BookingStatus Status { get; set; }
    }
}
