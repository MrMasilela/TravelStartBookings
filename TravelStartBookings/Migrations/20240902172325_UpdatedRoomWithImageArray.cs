using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelStartBookings.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRoomWithImageArray : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Rooms",
                newName: "Images");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Images",
                table: "Rooms",
                newName: "ImageUrl");
        }
    }
}
