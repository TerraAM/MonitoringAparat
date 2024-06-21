using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonitoringAparat.Migrations
{
    /// <inheritdoc />
    public partial class mat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountMaterialDay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    count = table.Column<int>(type: "INTEGER", nullable: false),
                    MaterialId = table.Column<int>(type: "INTEGER", nullable: false),
                    DayMatId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountMaterialDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountMaterialDay_DayMats_DayMatId",
                        column: x => x.DayMatId,
                        principalTable: "DayMats",
                        principalColumn: "DayMatId");
                    table.ForeignKey(
                        name: "FK_CountMaterialDay_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountMaterialDay_DayMatId",
                table: "CountMaterialDay",
                column: "DayMatId");

            migrationBuilder.CreateIndex(
                name: "IX_CountMaterialDay_MaterialId",
                table: "CountMaterialDay",
                column: "MaterialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountMaterialDay");
        }
    }
}
