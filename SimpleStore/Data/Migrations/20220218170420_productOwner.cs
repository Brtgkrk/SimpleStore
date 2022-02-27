using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleStore.Data.Migrations
{
    public partial class productOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductOwner",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductOwner",
                table: "Product");
        }
    }
}
