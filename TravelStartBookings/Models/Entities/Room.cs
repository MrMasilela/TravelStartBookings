namespace TravelStartBookings.Models.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public  string? RoomNumber { get; set; }
        public string RoomType { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerNight { get; set; }
        public  string? Description { get; set; }
        public List<Images> Images { get; set; } // URL to room image
        public  List<Amenity>? Amenities { get; set; } // List of amenities
        public  List<Booking>? Bookings { get; set; }
        public Hotel Hotel { get; set; }
    }
}