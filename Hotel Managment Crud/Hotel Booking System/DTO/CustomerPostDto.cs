using Hotel_Booking_System.Models;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.DTO
{
    public class CustomerPostDto
    {
        [Required]
        public string FullName { get; set; }
        [EmailAddress(ErrorMessage = "Please Enter a valid email address")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Please Enter a valid Phonr number")]
        public string PhoneNumber { get; set; }
        [StringLength(20, ErrorMessage = "ID Proof Number cannot exceed 20 characters")]
        public string IdProofNumber { get; set; }
    }
}
