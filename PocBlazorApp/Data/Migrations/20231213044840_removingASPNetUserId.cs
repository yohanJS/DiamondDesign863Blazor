using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PocBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class removingASPNetUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPrimaryInfo_AspNetUsers_UserId",
                table: "UserPrimaryInfo");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserPrimaryInfo",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserPrimaryInfo_UserId",
                table: "UserPrimaryInfo",
                newName: "IX_UserPrimaryInfo_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPrimaryInfo_AspNetUsers_ApplicationUserId",
                table: "UserPrimaryInfo",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPrimaryInfo_AspNetUsers_ApplicationUserId",
                table: "UserPrimaryInfo");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "UserPrimaryInfo",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserPrimaryInfo_ApplicationUserId",
                table: "UserPrimaryInfo",
                newName: "IX_UserPrimaryInfo_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPrimaryInfo_AspNetUsers_UserId",
                table: "UserPrimaryInfo",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
