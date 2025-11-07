using Hotel_Booking_System.DTO.GetAllDtos;
using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<List<CustomersGetAll>> GetAllCustomers();
        Task<CustomersGetAll> GetCustomer(int id);
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer> UpdateCustomer(int id, Customer customer);
        Task<Customer> DeleteCustomer(int id);
    }
}
