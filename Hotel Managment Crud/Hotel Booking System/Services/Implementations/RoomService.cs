using Hotel_Booking_System.Data;
using Hotel_Booking_System.DTO;
using Hotel_Booking_System.DTO.GetAllDtos;
using Hotel_Booking_System.Models;
using Hotel_Booking_System.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Hotel_Booking_System.Services.Implementations
{
    public class RoomService : IRoomService
    {
        private readonly HotelDbContext _context;
        public RoomService(HotelDbContext hotelDbContext)
        {
            _context = hotelDbContext;
        }
        public async Task<Room> CreateRoom(Room room)
        {

            bool hostelExist = await _context.hotels.AnyAsync((x)=>x.Id == room.HotelId);
            bool roomTypeExist = await _context.roomTypes.AnyAsync((x) => x.Id == room.RoomTypeId);

            if (!hostelExist)
            {
                throw new Exception("Hostel with the Id dosent exist");
            }

            if (!roomTypeExist)
            {
                throw new Exception("RoomType with the Id dosent exist");
            }

            _context.rooms.Add(room);
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task<Room> DeleteRoom(int id)
        {
            var roomTobeDeleted = await _context.rooms.FirstOrDefaultAsync((room) => room.Id == id);
            if (roomTobeDeleted != null)
            {
                _context.rooms.Remove(roomTobeDeleted);
                await _context.SaveChangesAsync();
                return roomTobeDeleted;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<RoomGetDto>> GetAllRooms()
        {

            var rooms = await _context.rooms.Include("Hotel").Include("RoomType").Select((x) => new RoomGetDto
            {
                Id = x.Id,
                RoomNumber = x.RoomNumber,
                RoomStatus = x.Status,
                PricePerNight = x.PricePerNight,
                hotelId = x.HotelId,
                HotelName = x.Hotel.Name,
                RoomTypeId = x.RoomTypeId,
                RoomTypeName = x.RoomType.TypeName

            }).ToListAsync();

            return rooms;

        }

        public async Task<RoomGetDto> GetById(int id)
        {
            var room = await _context.rooms.Include("Hotel").Include("RoomType").FirstOrDefaultAsync((r) => r.Id == id);

            if (room == null)
            {
                return null;
            }
            else
            {
                RoomGetDto roomGetDto = new RoomGetDto
                {
                    Id = room.Id,
                    RoomNumber = room.RoomNumber,
                    RoomStatus = room.Status,
                    PricePerNight = room.PricePerNight,
                    hotelId = room.HotelId,
                    HotelName = room.Hotel.Name,
                    RoomTypeId = room.RoomTypeId,
                    RoomTypeName = room.RoomType.TypeName
                };
                return roomGetDto;
            }
        }

        public async Task<Room> UpdateRoom(int id, RoomPostDto roomPostDto)
        {

            bool hostelExist = await _context.hotels.AnyAsync((x) => x.Id == roomPostDto.HotelId);
            bool roomTypeExist = await _context.roomTypes.AnyAsync((x) => x.Id == roomPostDto.RoomTypeId);

            if (!hostelExist)
            {
                throw new Exception("Hostel with the Id dosent exist");
            }

            if (!roomTypeExist)
            {
                throw new Exception("RoomType with the Id dosent exist");
            }

            var roomToBeUpdated = await _context.rooms.FirstOrDefaultAsync((room) => room.Id == id);


            if (roomToBeUpdated != null)
            {
                roomToBeUpdated.RoomNumber = roomPostDto.RoomNumber;
                roomToBeUpdated.Status = roomPostDto.Status;
                roomToBeUpdated.PricePerNight = roomPostDto.PricePerNight;
                roomToBeUpdated.HotelId = roomPostDto.HotelId;
                roomToBeUpdated.RoomTypeId = roomPostDto.RoomTypeId;

                await _context.SaveChangesAsync();
                return roomToBeUpdated;
            }
            else
            {
                return null;
            }
        }
    }
}
