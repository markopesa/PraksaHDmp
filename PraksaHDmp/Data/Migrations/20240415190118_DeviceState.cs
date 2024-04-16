using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraksaHDmp.Data.Migrations
{
    public partial class DeviceState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
            name: "DeviceStates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
