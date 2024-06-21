using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonitoringAparat.Migrations
{
    /// <inheritdoc />
    public partial class strength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "syslo",
                table: "Material",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "syslo",
                table: "Material");
        }
    }
}
