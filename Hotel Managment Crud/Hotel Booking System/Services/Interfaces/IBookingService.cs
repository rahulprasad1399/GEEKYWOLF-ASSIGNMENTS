using Hotel_Booking_System.DTO.GetAllDtos.Booking;
using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Services.Interfaces
{
    public interface IBookingService
    {
        Task<List<BookingGetAllDto>> GetAllBooking();
        Task<BookingGetAllDto> GetBookingById(int id);
        Task<Booking> CreateBookig(Booking booking);
        Task<Booking> UpdateBooking(int id, Booking booking);
        Task<Booking> DeleteBooking(int id);
    }
}
