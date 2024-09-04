using TravelStartBookings.Models;
using TravelStartBookings.Models.Entities;

namespace TravelStartBookings.BookingService
{
    public interface IBookingService
    {
        Task<BookingResponse> CreateBookingAsync(BookingRequest bookingRequest);

        Task<List<RoomSearchResponse>> SearchAvailableRoomsAsync(SearchRequest request);

        Task<RoomDetails> GetRoomDetailsByIdAsync(int roomId);
    }
}
