using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using TravelStartBookings.Data;
using TravelStartBookings.Models;
using TravelStartBookings.Models.Entities;

namespace TravelStartBookings.RoomBookingData
{
    public class RoomBookingData : IRoomBookingData
    {
        private readonly ApplicationDbContext _context;

        public RoomBookingData(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateBookingAsync(Booking booking)
        {           
                await _context.Bookings.AddAsync(booking);
                await _context.SaveChangesAsync();
        }

        public async Task<Room> GetRoomDetailsByIdAsync(int roomId)
        {
            
            return await _context.Rooms
            .Include(r => r.Amenities)
            .Include(r => r.Images)
            .FirstOrDefaultAsync(r => r.Id == roomId);            
        }

        public async Task<List<Room>> SearchAvailableRoomsAsync(SearchRequest request)
        {
            var rooms = await _context.Rooms
           .Include(r => r.Bookings)
           .Include(r => r.Hotel)
           .Where(r => r.Capacity >= request.NumberOfGuest &&
                       r.Bookings.All(b =>
                           b.CheckOutDate <= request.CheckInDate || b.CheckInDate >= request.CheckOutDate)) // Check date conflicts
           .ToListAsync();
            return rooms;
        }

    }
}
