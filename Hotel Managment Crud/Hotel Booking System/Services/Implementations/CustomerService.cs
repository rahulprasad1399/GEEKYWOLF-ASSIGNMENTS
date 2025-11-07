using Hotel_Booking_System.Data;
using Hotel_Booking_System.DTO.GetAllDtos;
using Hotel_Booking_System.Models;
using Hotel_Booking_System.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Hotel_Booking_System.Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly HotelDbContext _context;
        public CustomerService(HotelDbContext context)
        {
            _context = context;
        }
        public async Task<Customer> CreateCustomer(Customer customer)
        {

            bool emailExist = await _context.customers.AnyAsync(x => x.Email == customer.Email);
            if (emailExist)
            {
                throw new Exception("Email already exist");
            }

            bool idProofExist = await _context.customers.AnyAsync((c) => c.IdProofNumber == customer.IdProofNumber);
            if (idProofExist)
            {
                throw new Exception("Id Proof Number already exist");
            }

            var result = await _context.customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            Customer customer = await _context.customers.FirstOrDefaultAsync(x => x.Id == id);
            if (customer == null)
            {
                return null;
            }
            else
            {
                _context.customers.Remove(customer);
                await _context.SaveChangesAsync();
                return customer;
            }
        }

        public async Task<List<CustomersGetAll>> GetAllCustomers()
        {
            List<CustomersGetAll> customers = await _context.customers.Include(x => x.Bookings).Select((customer) => new CustomersGetAll
            {
                Id = customer.Id,
                FullName = customer.FullName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
                IdProofNumber = customer.IdProofNumber,
                Bookings = customer.Bookings.Select((booking) => new BookingGetForCustomers
                {
                    CheckInDate = booking.CheckInDate,
                    CheckOutDate = booking.CheckOutDate,
                    TotalAmount = booking.TotalAmount,
                    Status = booking.Status,
                }).ToList()
            }).ToListAsync();

            return customers;
        }

        public async Task<CustomersGetAll> GetCustomer(int id)
        {
            CustomersGetAll customer = await _context.customers.Where((x) => x.Id == id).Select((customer) => new CustomersGetAll
            {
                Id = customer.Id,
                FullName = customer.FullName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
                IdProofNumber = customer.IdProofNumber,
                Bookings = customer.Bookings.Select((booking) => new BookingGetForCustomers
                {
                    CheckInDate = booking.CheckInDate,
                    CheckOutDate = booking.CheckOutDate,
                    TotalAmount = booking.TotalAmount,
                    Status = booking.Status,
                }).ToList()
            }).FirstOrDefaultAsync();

            if (customer == null)
            {
                return null;
            }
            else
            {
                return customer;
            }
        }

        public async Task<Customer> UpdateCustomer(int id, Customer customer)
        {
            var customerFound = await _context.customers.FirstOrDefaultAsync(x => x.Id == id);
            if (customerFound == null)
            {
                return null;
            }

            bool emailExist = await _context.customers.AnyAsync(c => c.Email == customer.Email && c.Id != id);
            if (emailExist)
            {
                throw new Exception("Email already exist for another customer");
            }

            bool idExist = await _context.customers.AnyAsync((c) => c.IdProofNumber == customer.IdProofNumber && c.Id != id);
            if (idExist)
            {
                throw new Exception("IdProofNumber already exist");
            }

            customerFound.FullName = customer.FullName;
            customerFound.Email = customer.Email;
            customerFound.PhoneNumber = customer.PhoneNumber;
            customerFound.IdProofNumber = customer.IdProofNumber;

            await _context.SaveChangesAsync();
            return customerFound;

        }
    }
}
