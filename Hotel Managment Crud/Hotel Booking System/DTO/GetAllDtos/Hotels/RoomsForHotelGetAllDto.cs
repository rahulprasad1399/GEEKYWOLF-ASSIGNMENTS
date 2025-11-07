using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.DTO.GetAllDtos.Hotels
{
    public class RoomsForHotelGetAllDto
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public decimal PricePerNight { get; set; }
        public RoomStatus Status { get; set; }
    }
}
