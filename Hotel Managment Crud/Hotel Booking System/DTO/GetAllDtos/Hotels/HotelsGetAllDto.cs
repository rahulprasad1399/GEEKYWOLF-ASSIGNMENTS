using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.DTO.GetAllDtos.Hotels
{
    public class HotelsGetAllDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public List<RoomsForHotelGetAllDto> Rooms { get; set; }
        public List<EmployeeForHotelGetAllDto> Employees { get; set; }
    }
}
