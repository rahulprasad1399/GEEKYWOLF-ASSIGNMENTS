using Hotel_Booking_System.Data;
using Hotel_Booking_System.DTO.GetAllDtos;
using Hotel_Booking_System.Models;
using Hotel_Booking_System.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_System.Services.Implementations
{
    public class ReviewService : IReviewService
    {
        private readonly HotelDbContext _context;
        public ReviewService(HotelDbContext context)
        {
            _context = context;
        }
        public async Task<Review> CreateReview(Review review)
        {
            bool hotelExist = await _context.hotels.AnyAsync((hotel) => hotel.Id == review.HotelId);
            bool customerExist = await _context.customers.AnyAsync((customer) => customer.Id == review.CustomerId);

            if (!hotelExist)
            {
                throw new Exception($"Hotel with the {review.HotelId} dosent exist");
            }

            if (!customerExist)
            {
                throw new Exception($"Customer with the {review.CustomerId} dosen't exist");
            }

            await _context.reviews.AddAsync(review);
            await _context.SaveChangesAsync();
            return review;
        }

        public async Task<Review> DeleteReview(int id)
        {
            Review reviewToBeDeleted = await _context.reviews.FirstOrDefaultAsync((review) => review.Id == id);
            if (reviewToBeDeleted != null)
            {
                _context.reviews.Remove(reviewToBeDeleted);
                await _context.SaveChangesAsync();
                return reviewToBeDeleted;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<ReviewsGetAllDto>> GetAllReviews()
        {
            List<ReviewsGetAllDto> reviews = await _context.reviews.Include((x)=>x.Hotel).Include((x)=>x.Customer).Select((review)=> new ReviewsGetAllDto
            {
                Id = review.Id,
                Rating = review.Rating,
                Comment = review.Comment,
                ReviewDate = review.ReviewDate,
                HotelId = review.HotelId,
                HotelName = review.Hotel.Name,
                CustomerId = review.CustomerId,
                CustomerName = review.Customer.FullName
            }).ToListAsync();

            return reviews;
        }

        public async Task<ReviewsGetAllDto> GetReviewById(int id)
        {
            ReviewsGetAllDto review = await _context.reviews.Where(x=>x.Id == id).Include((x) => x.Hotel).Include((x) => x.Customer).Select((review) => new ReviewsGetAllDto
            {
                Id = review.Id,
                Rating = review.Rating,
                Comment = review.Comment,
                ReviewDate = review.ReviewDate,
                HotelId = review.HotelId,
                HotelName = review.Hotel.Name,
                CustomerId = review.CustomerId,
                CustomerName = review.Customer.FullName
            }).FirstOrDefaultAsync();

            if (review != null)
            {
                return review;
            }
            else
            {
                return null;
            }
        }

        public async Task<Review> UpdateReview(int id, Review review)
        {


            Review updateReview = await _context.reviews.FirstOrDefaultAsync((review) => review.Id == id);

            bool hotelExist = await _context.hotels.AnyAsync((hotel) => hotel.Id == review.HotelId);
            bool customerExist = await _context.customers.AnyAsync((customer) => customer.Id == review.CustomerId);

            if (!hotelExist)
            {
                throw new Exception($"Hotel with the {review.HotelId} dosent exist");
            }

            if (!customerExist)
            {
                throw new Exception($"Customer with the {review.CustomerId} dosen't exist");
            }

            if (updateReview == null)
            {
                return null;
            }

            updateReview.Rating = review.Rating;
            updateReview.Comment = review.Comment;
            updateReview.ReviewDate = review.ReviewDate;
            updateReview.HotelId = review.HotelId;
            updateReview.CustomerId = review.CustomerId;

            await _context.SaveChangesAsync();

            return updateReview;
        }

    }
}
