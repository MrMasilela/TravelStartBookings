using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelStartBookings.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedBookingWithRoomNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomNumber",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomNumber",
                table: "Bookings");
        }
    }
}
