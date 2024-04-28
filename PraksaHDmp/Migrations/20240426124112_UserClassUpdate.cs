using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraksaHDmp.Migrations
{
    public partial class UserClassUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_UserCreatedId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UserModifiedId",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "User",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "User",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserCreatedId",
                table: "User",
                column: "UserCreatedId",
                unique: true,
                filter: "[UserCreatedId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserModifiedId",
                table: "User",
                column: "UserModifiedId",
                unique: true,
                filter: "[UserModifiedId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_UserCreatedId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UserModifiedId",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "UserModifiedId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCreatedId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserCreatedId",
                table: "User",
                column: "UserCreatedId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserModifiedId",
                table: "User",
                column: "UserModifiedId",
                unique: true);
        }
    }
}
