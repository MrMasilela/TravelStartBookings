using TravelStartBookings.Models;
using TravelStartBookings.Models.Entities;

namespace TravelStartBookings.RoomBookingData
{
    public interface IRoomBookingData
    {
        Task <List<Room>> SearchAvailableRoomsAsync(SearchRequest request);
        Task <Room> GetRoomDetailsByIdAsync(int roomId);

        Task CreateBookingAsync(Booking booking);        
    }
}
