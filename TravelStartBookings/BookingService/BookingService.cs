using TravelStartBookings.Models;
using TravelStartBookings.Models.Entities;
using TravelStartBookings.RoomBookingData;

namespace TravelStartBookings.BookingService
{
    public class BookingService : IBookingService
    {
        private readonly IRoomBookingData _bookingData;

        public BookingService(IRoomBookingData bookingData)
        {
            _bookingData = bookingData;
        }

        public async Task<BookingResponse> CreateBookingAsync(BookingRequest bookingRequest)
        {
            var booking = new Booking
            {
                Address = bookingRequest.Address,
                CheckInDate = bookingRequest.CheckInDate,
                CheckOutDate = bookingRequest.CheckOutDate,
                City = bookingRequest.City,
                Email = bookingRequest.Email,
                FirstName = bookingRequest.FirstName,
                LastName = bookingRequest.LastName,
                Phone = bookingRequest.Phone,
                PostalCode = bookingRequest.PostalCode,
                RoomId = bookingRequest.RoomId,
            };

            //Call roomBookingRepo
            await _bookingData.CreateBookingAsync(booking);

            var bookingResponse = new BookingResponse
            {
                RoomId = booking.RoomId,
                Phone = booking.Phone,
                Email = booking.Email,
                FirstName = booking.FirstName,
                LastName = booking.LastName,
            };

            return bookingResponse;
        }

        public async Task<RoomDetails> GetRoomDetailsByIdAsync(int roomId)
        {
            var room = await _bookingData.GetRoomDetailsByIdAsync(roomId);

            var roomDetails = new RoomDetails
            {
                Id = room.Id,
                RoomType = room.RoomType,
                Capacity = room.Capacity,
                PricePerNight = room.PricePerNight,
                Description = room.Description,
                Images = room.Images,
                Amenities = room.Amenities,
            };

            return roomDetails;
        }

        public async Task<List<RoomSearchResponse>> SearchAvailableRoomsAsync(SearchRequest request)
        {            
             var rooms = await _bookingData.SearchAvailableRoomsAsync(request);

            var roomsResponse = rooms.Select(r => new RoomSearchResponse ()
            {
                Id = r.Id,
                RoomNumber = r.RoomNumber,
                RoomType = r.RoomType,
                Capacity = r.Capacity,
                PricePerNight = r.PricePerNight,
                Description = r.Description,
                HotelName = r.Hotel.Name,
                HotelImageUrl = r.Hotel.ImageUrl,
            }).ToList();

            return roomsResponse;
        }
    }
}
