using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Reflection.Metadata.Ecma335;
using TravelStartBookings.BookingService;
using TravelStartBookings.Models;
using TravelStartBookings.Models.Entities;
using TravelStartBookings.RoomBookingData;

namespace TravelStartBookings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _service;

        public BookingsController(IBookingService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("search")]
        public async Task<ActionResult<List<RoomSearchResponse>>> SearchAvailableRoomsAsync([FromBody]SearchRequest request)
        {
            var rooms = await _service.SearchAvailableRoomsAsync(request);
            return Ok(rooms);
        }

        [HttpGet]
        [Route("getRoomDetails/{Id:int}")]
        public async Task<ActionResult<RoomDetails>> GetRoomDetailsByIdAsync(int Id)
        {
            var room = await _service.GetRoomDetailsByIdAsync(Id);
            return Ok(room);
        }

        [HttpPost]
        [Route("createBooking")]
        public async Task<IActionResult> CreateBookingAsync([FromBody] BookingRequest booking)
        {
            var bookingResponse = await _service.CreateBookingAsync(booking);
            return Ok(bookingResponse);
        }

    }
}
