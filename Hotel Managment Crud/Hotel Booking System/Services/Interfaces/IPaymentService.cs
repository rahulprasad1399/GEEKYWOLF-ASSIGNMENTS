using Hotel_Booking_System.DTO.GetAllDtos;
using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<List<GetAllPaymentDto>> GetAllPayments();
        Task<GetAllPaymentDto> GetPayment(int id);
        Task<Payment> CreatePayment(Payment payment);
        Task<Payment> UpdatePayment(int id, Payment payment);
        Task<Payment> DeletePayment(int id);
    }
}
