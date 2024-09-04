using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TravelStartBookings.Models
{
    public class BookingRequest
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]

        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [DisplayName("Postal Code")]
        public int PostalCode { get; set; }
        [Required]
        [DisplayName("Room Id")]
        public int RoomId { get; set; }

        [Required]
        [DisplayName("Check In Date")]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [Required]
        [DisplayName("CheckInDate Out Date")]
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }
    }
}
