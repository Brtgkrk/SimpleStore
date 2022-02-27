using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleStore.Data.Migrations
{
    public partial class Cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductType");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "ProductType",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductType",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ProductType",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "ProductType");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductType");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ProductType");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
