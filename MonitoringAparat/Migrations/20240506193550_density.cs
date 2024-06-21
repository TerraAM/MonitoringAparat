using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonitoringAparat.Migrations
{
    /// <inheritdoc />
    public partial class density : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "density",
                table: "Material",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "temp",
                table: "Material",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "density",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "temp",
                table: "Material");
        }
    }
}
