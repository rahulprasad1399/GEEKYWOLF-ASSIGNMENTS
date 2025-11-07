using Hotel_Booking_System.DTO.GetAllDtos;
using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Services.Interfaces
{
    public interface IReviewService
    {
        Task<List<ReviewsGetAllDto>> GetAllReviews();
        Task<ReviewsGetAllDto> GetReviewById(int id);
        Task<Review> CreateReview(Review review);
        Task<Review> UpdateReview(int id, Review review);
        Task<Review> DeleteReview(int id);
    }
}
