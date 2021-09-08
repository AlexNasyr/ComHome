using Microsoft.EntityFrameworkCore.Migrations;

namespace ComHome.Migrations
{
    public partial class AddSensorType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SensorType",
                table: "Sensors",
                type: "NCHAR",
                maxLength: 32,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SensorType",
                table: "Sensors");
        }
    }
}
