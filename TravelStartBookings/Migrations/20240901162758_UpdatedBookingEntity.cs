using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelStartBookings.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedBookingEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Guests_GuestId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_GuestId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "GuestId",
                table: "Bookings",
                newName: "PostalCode");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Bookings",
                newName: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_GuestId",
                table: "Bookings",
                column: "GuestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Guests_GuestId",
                table: "Bookings",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
