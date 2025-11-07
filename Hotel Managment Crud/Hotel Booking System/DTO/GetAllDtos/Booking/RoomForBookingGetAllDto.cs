using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.DTO.GetAllDtos.Booking
{
    public class RoomForBookingGetAllDto
    {
        public string RoomNumber { get; set; }
        public decimal PricePerNight { get; set; }
        public RoomStatus Status { get; set; }
    }
}
