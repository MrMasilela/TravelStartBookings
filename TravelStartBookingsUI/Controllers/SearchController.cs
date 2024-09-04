using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Protocol;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using TravelStartBookings.Models;
using TravelStartBookings.Models.Entities;
using TravelStartBookingsUI.Helper;
using TravelStartBookingsUI.Models;

namespace TravelStartBookingsUI.Controllers
{
    public class SearchController : Controller
    {        
        ClientHelper clientHelper = new ClientHelper();
        HttpClient _client;
        public SearchController()
        {
            _client = clientHelper.Initial();
        }
        public IActionResult Search()
        {
            SearchRequest searchRequest = new SearchRequest();
            return View(searchRequest);
        }

        // Handle the search request and display results
        [HttpPost]
        public async Task<IActionResult> SearchResults(SearchRequest searchRequest)
        {
            List<RoomSearchResponse> rooms = new List<RoomSearchResponse>();
           
            string data = JsonConvert.SerializeObject(searchRequest);
            StringContent content = new StringContent(data,Encoding.UTF8,"application/json");
            HttpResponseMessage response = await _client.PostAsync(_client.BaseAddress +"/Bookings/search",content);
            if (response.IsSuccessStatusCode)
            {
                string dataResult = await response.Content.ReadAsStringAsync();
                   
                rooms = JsonConvert.DeserializeObject<List<RoomSearchResponse>>(dataResult);
            }
            return View(rooms);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            RoomDetails room = new RoomDetails();
            HttpResponseMessage response = await _client.GetAsync(_client.BaseAddress + "/Bookings/getRoomDetails/" + id);
            if (response.IsSuccessStatusCode)
            {
                var dataResult = await response.Content.ReadAsStringAsync();
               
                room = JsonConvert.DeserializeObject<RoomDetails>(dataResult);

            }

            if (room == null)
                return BadRequest("Room can not be null");

            return View(room);
        }

        public IActionResult Book(int roomId)
        {
            return RedirectToAction("CreateBooking", "Booking", new { id = roomId });
        }

    }
}
