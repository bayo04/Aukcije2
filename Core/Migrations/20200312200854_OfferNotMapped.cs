using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class OfferNotMapped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_AspNetUsers_CreatorId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_CreatorId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Offers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatorId",
                table: "Offers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CreatorId",
                table: "Offers",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_AspNetUsers_CreatorId",
                table: "Offers",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
