using Hotel_Booking_System.Models;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.DTO
{
    public class HotelPostDto
    {
        [Required]
        public string Name { get; set; }
        [MaxLength(100, ErrorMessage ="Maximum number of character allowed is 100")]
        public string Address { get; set; }
        [MaxLength(100, ErrorMessage ="Maximum number of character allowed is 100")]
        public string City { get; set; }
        [MaxLength(100)]
        public string Country { get; set; }
        [Phone(ErrorMessage ="Please enter a valid phone numer")]
        public string PhoneNumber { get; set; }

    }
}
