using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.DTO.GetAllDtos
{
    public class ReviewsGetAllDto
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public int CustomerId { get; set; }
        public String CustomerName { get; set; }
    }
}
