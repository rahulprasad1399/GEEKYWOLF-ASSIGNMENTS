using Hotel_Booking_System.Models;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.DTO
{
    public class EmployeePostDto
    {
        [MaxLength(100)]
        public string FullName { get; set; }
        [Required, MaxLength(50)]
        public string Role { get; set; }
        [Required, EmailAddress(ErrorMessage = "Please Provide a valid Email")]
        public string Email { get; set; }
        public int HotelId { get; set; }
    }
}
