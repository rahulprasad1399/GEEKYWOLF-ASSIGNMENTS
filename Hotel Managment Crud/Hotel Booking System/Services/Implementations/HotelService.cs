using Hotel_Booking_System.Data;
using Hotel_Booking_System.DTO;
using Hotel_Booking_System.DTO.GetAllDtos.Hotels;
using Hotel_Booking_System.Models;
using Hotel_Booking_System.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_System.Services.Implementations
{
    public class HotelService : IHotelService
    {
        private readonly HotelDbContext _context;
        public HotelService(HotelDbContext context)
        {
            _context = context;
        }
        public async Task<Hotel> AddHotel(Hotel hotel)
        {

            _context.hotels.Add(hotel);
            await _context.SaveChangesAsync();
            return hotel;
        }

        public async Task<Hotel> DeleteHotel(int id)
        {
            Hotel hotelToDelete = await _context.hotels.FirstOrDefaultAsync((hotel) => hotel.Id == id);
            if (hotelToDelete != null)
            {
                _context.hotels.Remove(hotelToDelete);
                await _context.SaveChangesAsync();
                return hotelToDelete;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<HotelsGetAllDto>> GetAllHotels()
        {
            List<HotelsGetAllDto> hotels = await _context.hotels.Include(x => x.Employees).Include(x => x.Rooms).Select(hotel => new HotelsGetAllDto
            {
                Id = hotel.Id,
                Name = hotel.Name,
                Address = hotel.Address,
                City = hotel.City,
                Country = hotel.Country,
                PhoneNumber = hotel.PhoneNumber,
                Rooms = hotel.Rooms.Select((room) => new RoomsForHotelGetAllDto
                {
                    Id = room.Id,
                    RoomNumber = room.RoomNumber,
                    PricePerNight = room.PricePerNight,
                    Status = room.Status,
                }).ToList(),
                Employees = hotel.Employees.Select((employee) => new EmployeeForHotelGetAllDto
                {
                    Id = employee.Id,
                    FullName = employee.FullName,
                    Role = employee.Role,
                    Email = employee.Email,
                }).ToList()
            }).ToListAsync();

            return hotels;
        }

        public async Task<HotelsGetAllDto> GetHotelById(int id)
        {
            HotelsGetAllDto hotelFound = await _context.hotels.Where(x=>x.Id==id).Include(x => x.Employees).Include(x => x.Rooms).Select(hotel => new HotelsGetAllDto
            {
                Id = hotel.Id,
                Name = hotel.Name,
                Address = hotel.Address,
                City = hotel.City,
                Country = hotel.Country,
                PhoneNumber = hotel.PhoneNumber,
                Rooms = hotel.Rooms.Select((room) => new RoomsForHotelGetAllDto
                {
                    Id = room.Id,
                    RoomNumber = room.RoomNumber,
                    PricePerNight = room.PricePerNight,
                    Status = room.Status,
                }).ToList(),
                Employees = hotel.Employees.Select((employee) => new EmployeeForHotelGetAllDto
                {
                    Id = employee.Id,
                    FullName = employee.FullName,
                    Role = employee.Role,
                    Email = employee.Email,
                }).ToList()
            }).FirstOrDefaultAsync();

            return hotelFound;
        }

        public async Task<Hotel> UpdateHotel(int id, HotelPostDto hotelPostDto)
        {

            Hotel existingHotel = await _context.hotels.FirstOrDefaultAsync((hotel) => hotel.Id == id);

            if (existingHotel != null)
            {
                existingHotel.Address = hotelPostDto.Address;
                existingHotel.PhoneNumber = hotelPostDto.PhoneNumber;
                existingHotel.Name = hotelPostDto.Name;
                existingHotel.City = hotelPostDto.City;
                existingHotel.Country = hotelPostDto.Country;

                await _context.SaveChangesAsync();
                return existingHotel;
            }
            else
            {
                return null;
            }
        }
    }
}
