using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelPlannerAPI.Migrations
{
    /// <inheritdoc />
    public partial class migration21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DestinationActivities_TripDestinations_TripDestinationModelTripId_TripDestinationModelDestinationId",
                table: "DestinationActivities");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Users_UserModelId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Trips_UserModelId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_DestinationActivities_TripDestinationModelTripId_TripDestinationModelDestinationId",
                table: "DestinationActivities");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "TripDestinationModelDestinationId",
                table: "DestinationActivities");

            migrationBuilder.DropColumn(
                name: "TripDestinationModelTripId",
                table: "DestinationActivities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserModelId",
                table: "Trips",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TripDestinationModelDestinationId",
                table: "DestinationActivities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TripDestinationModelTripId",
                table: "DestinationActivities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trips_UserModelId",
                table: "Trips",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_DestinationActivities_TripDestinationModelTripId_TripDestinationModelDestinationId",
                table: "DestinationActivities",
                columns: new[] { "TripDestinationModelTripId", "TripDestinationModelDestinationId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DestinationActivities_TripDestinations_TripDestinationModelTripId_TripDestinationModelDestinationId",
                table: "DestinationActivities",
                columns: new[] { "TripDestinationModelTripId", "TripDestinationModelDestinationId" },
                principalTable: "TripDestinations",
                principalColumns: new[] { "TripId", "DestinationId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Users_UserModelId",
                table: "Trips",
                column: "UserModelId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
