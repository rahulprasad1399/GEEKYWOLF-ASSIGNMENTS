using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.DTO.GetAllDtos.Hotels
{
    public class EmployeeForHotelGetAllDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
    }
}
