using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DXIvoiceDemo.Model.Migrations
{
    /// <inheritdoc />
    public partial class EmptyRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Type", "Active", "Name", "Code", "Address", "City", "Country", "TIN", "Email" },
                values: new object[] { Guid.Empty, 0, true, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: Guid.Empty
            );
        }
    }
}
