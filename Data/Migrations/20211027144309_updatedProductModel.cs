using Microsoft.EntityFrameworkCore.Migrations;

namespace AspDotNetCoreAssignment.Data.Migrations
{
    public partial class updatedProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductOwnerID",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductOwnerID",
                table: "Products");
        }
    }
}
