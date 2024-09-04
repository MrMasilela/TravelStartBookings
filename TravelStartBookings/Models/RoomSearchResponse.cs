using TravelStartBookings.Models.Entities;

namespace TravelStartBookings.Models
{
    public class RoomSearchResponse
    {
        public int Id { get; set; }
        public string? RoomNumber { get; set; }
        public string? RoomType { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerNight { get; set; }
        public string? Description { get; set; }
        public string? HotelName { get; set; }
        public string? HotelImageUrl { get; set; }

    }
}
