using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.DTO.GetAllDtos
{
    public class CustomersGetAll
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string IdProofNumber { get; set; }
        public List<BookingGetForCustomers> Bookings { get; set; }
    }
}
