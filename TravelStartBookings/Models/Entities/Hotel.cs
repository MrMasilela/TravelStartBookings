namespace TravelStartBookings.Models.Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
        public  required List<Room> Rooms { get; set; }

    }
}
