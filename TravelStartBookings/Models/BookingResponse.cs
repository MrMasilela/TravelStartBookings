using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TravelStartBookings.Models
{
    public class BookingResponse
    {
        public int RoomId { get; set; }
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
       
        public string Email { get; set; }
        
        public string Phone { get; set; }
 
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }
    }
}
