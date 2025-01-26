using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CArch.Infrastructure.EF.Migrations
{
    /// <inheritdoc />
    public partial class Add_Column_Version_To_Models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Version",
                schema: "carch_db",
                table: "Books",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                schema: "carch_db",
                table: "Authors",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Version",
                schema: "carch_db",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Version",
                schema: "carch_db",
                table: "Authors");
        }
    }
}
