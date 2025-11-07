using Hotel_Booking_System.Data;
using Hotel_Booking_System.DTO.GetAllDtos.Booking;
using Hotel_Booking_System.Models;
using Hotel_Booking_System.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_System.Services.Implementations
{
    public class BookingService : IBookingService
    {
        private readonly HotelDbContext _context;
        public BookingService(HotelDbContext context)
        {
            _context = context;
        }
        public async Task<Booking> CreateBookig(Booking booking)
        {

            var customerExist = await _context.customers.AnyAsync((customer) => customer.Id == booking.CustomerId);
            if (!customerExist)
            {
                throw new Exception($"Customer {booking.CustomerId} dosen't exist");
            }

            var roomExist = await _context.rooms.AnyAsync((room) => room.Id == booking.RoomId);
            if (!roomExist)
            {
                throw new Exception($"Room {booking.RoomId} dosen't Exist");
            }

            await _context.AddAsync(booking);
            await _context.SaveChangesAsync();
            return booking;
        }

        public async Task<Booking> DeleteBooking(int id)
        {
            Booking bookingToDelete = await _context.bookings.FirstOrDefaultAsync((booking) => booking.Id == id);
            if (bookingToDelete != null)
            {
                _context.bookings.Remove(bookingToDelete);
                await _context.SaveChangesAsync();
                return bookingToDelete;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<BookingGetAllDto>> GetAllBooking()
        {
            List<BookingGetAllDto> bookings = await _context.bookings.Include(x => x.Payment).Include(x => x.Customer).Include(x => x.Room).Select((booking) => new BookingGetAllDto
            {
                Id = booking.Id,
                CheckInDate = booking.CheckInDate,
                CheckOutDate = booking.CheckOutDate,
                TotalAmount = booking.TotalAmount,
                Status = booking.Status,
                Payment = booking.Payment == null ? null : new PaymentForBookingGetAllDto
                {
                    PaymentDate = booking.Payment.PaymentDate,
                    Amount = booking.Payment.Amount,
                    Status = booking.Payment.Status
                },
                CustomerId = booking.CustomerId,
                Customer = booking.Customer.FullName == null ? null : new CustomerForBookingGetAllDto
                {
                    FullName = booking.Customer.FullName,
                    PhoneNumber = booking.Customer.PhoneNumber,
                    Email = booking.Customer.Email,
                },
                RoomId = booking.RoomId,
                Room = booking.Room.RoomNumber == null ? null : new RoomForBookingGetAllDto
                {
                    RoomNumber = booking.Room.RoomNumber,
                    PricePerNight = booking.Room.PricePerNight,
                    Status = booking.Room.Status
                }
            }).ToListAsync();
            return bookings;
        }

        public async Task<BookingGetAllDto> GetBookingById(int id)
        {
            BookingGetAllDto existingBooking = await _context.bookings.Where((x) => x.Id == id).Include(x => x.Payment).Include(x => x.Customer).Include(x => x.Room).Select((booking) => new BookingGetAllDto
            {
                Id = booking.Id,
                CheckInDate = booking.CheckInDate,
                CheckOutDate = booking.CheckOutDate,
                TotalAmount = booking.TotalAmount,
                Status = booking.Status,
                Payment = booking.Payment.PaymentDate == null ? null : new PaymentForBookingGetAllDto
                {
                    PaymentDate = booking.Payment.PaymentDate,
                    Amount = booking.Payment.Amount,
                    Status = booking.Payment.Status
                },
                CustomerId = booking.CustomerId,
                Customer = new CustomerForBookingGetAllDto
                {
                    FullName = booking.Customer.FullName,
                    PhoneNumber = booking.Customer.PhoneNumber,
                    Email = booking.Customer.Email,
                },
                RoomId = booking.RoomId,
                Room = new RoomForBookingGetAllDto
                {
                    RoomNumber = booking.Room.RoomNumber,
                    PricePerNight = booking.Room.PricePerNight,
                    Status = booking.Room.Status
                }
            }).FirstOrDefaultAsync();

            if (existingBooking != null)
            {
                return existingBooking;
            }
            else
            {
                return null;
            }
        }

        public async Task<Booking> UpdateBooking(int id, Booking booking)
        {

            var customerExist = await _context.customers.AnyAsync((customer) => customer.Id == booking.CustomerId);
            if (!customerExist)
            {
                throw new Exception($"Customer {booking.CustomerId} dosen't exist");
            }

            var roomExist = await _context.rooms.AnyAsync((room) => room.Id == booking.RoomId);
            if (!roomExist)
            {
                throw new Exception($"Room {booking.RoomId} dosen't Exist");
            }

            Booking bookingToUpdate = await _context.bookings.FirstOrDefaultAsync((booking) => booking.Id == id);
            if (bookingToUpdate != null)
            {
                bookingToUpdate.CheckInDate = Convert.ToDateTime(booking.CheckInDate);
                bookingToUpdate.CheckOutDate = Convert.ToDateTime(booking.CheckOutDate);
                bookingToUpdate.TotalAmount = Convert.ToDecimal(booking.TotalAmount);
                bookingToUpdate.Status = booking.Status;
                bookingToUpdate.CustomerId = booking.CustomerId;
                bookingToUpdate.RoomId = booking.RoomId;

                await _context.SaveChangesAsync();
                return bookingToUpdate;
            }
            else
            {
                throw new Exception($"Booking with id : {id} dosen't exist");
            }
        }
    }
}
