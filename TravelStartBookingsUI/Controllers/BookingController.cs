using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using TravelStartBookings.Models;
using TravelStartBookings.Models.Entities;
using TravelStartBookingsUI.Helper;

namespace TravelStartBookingsUI.Controllers
{
    public class BookingController : Controller
    {                
        ClientHelper clientHelper = new ClientHelper();
        HttpClient _client ; 
         
        public BookingController()
        {
           _client = clientHelper.Initial();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking(BookingRequest booking)
        {
            booking.Id = 0;
            string data = JsonConvert.SerializeObject(booking);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response =  _client.PostAsync(_client.BaseAddress + "/Bookings/createBooking", content).Result;
            if (response.IsSuccessStatusCode)
            {
                string dataResult = await response.Content.ReadAsStringAsync();

                var bookingResponse = JsonConvert.DeserializeObject<BookingResponse>(dataResult);
                return View("Confirmation", bookingResponse);
            }
            return View();            
        }

        public IActionResult CreateBooking(int Id)
        {
            var model = new BookingRequest { RoomId = Id };
            return View(model);
        }

        public IActionResult ReturnToSearch()
        {
           return RedirectToAction("Search","Search");
        }
    }
}
