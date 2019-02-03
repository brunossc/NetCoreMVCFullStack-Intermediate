using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreMVCIntermediate.Data.Migrations
{
    public partial class ActiveCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Customers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Customers");
        }
    }
}
