using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonitoringAparat.Migrations
{
    /// <inheritdoc />
    public partial class speed_lines : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "speed",
                table: "Lines",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "speed",
                table: "Lines");
        }
    }
}
