using System.ComponentModel.DataAnnotations;

namespace TravelStartBookings.Models
{
    public class SearchRequest
    {
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }
        public int NumberOfGuest { get; set; }

    }
}
