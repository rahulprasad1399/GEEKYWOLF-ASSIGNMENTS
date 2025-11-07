using Hotel_Booking_System.Models;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.DTO
{
    public class RoomTypePostDto
    {
        [Required]
        public string TypeName { get; set; }
        public string Description { get; set; }
        [Required]
        public int Capacity { get; set; }
    }
}
