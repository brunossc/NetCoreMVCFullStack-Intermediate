using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreMVCIntermediate.Data.Migrations
{
    public partial class NotActiveCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Customers",
                newName: "NotActive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NotActive",
                table: "Customers",
                newName: "Active");
        }
    }
}
