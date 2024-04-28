using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraksaHDmp.Migrations
{
    public partial class something : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_User_UserCreatedId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_UserModifiedId",
                table: "User");

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

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_UserCreatedId",
                table: "User",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_UserModifiedId",
                table: "User",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_User_UserCreatedId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_UserModifiedId",
                table: "User");

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

            migrationBuilder.CreateIndex(
                name: "IX_User_UserCreatedId",
                table: "User",
                column: "UserCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserModifiedId",
                table: "User",
                column: "UserModifiedId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_UserCreatedId",
                table: "User",
                column: "UserCreatedId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_UserModifiedId",
                table: "User",
                column: "UserModifiedId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
