namespace TravelStartBookings.Models.Entities
{
    public class Amenity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required List<Room> Rooms { get; set; }
    }
}