using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonitoringAparat.Migrations
{
    /// <inheritdoc />
    public partial class m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountMaterialDay_DayMats_DayMatId",
                table: "CountMaterialDay");

            migrationBuilder.DropForeignKey(
                name: "FK_CountMaterialDay_Material_MaterialId",
                table: "CountMaterialDay");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountMaterialDay",
                table: "CountMaterialDay");

            migrationBuilder.RenameTable(
                name: "CountMaterialDay",
                newName: "CountMaterialDays");

            migrationBuilder.RenameIndex(
                name: "IX_CountMaterialDay_MaterialId",
                table: "CountMaterialDays",
                newName: "IX_CountMaterialDays_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_CountMaterialDay_DayMatId",
                table: "CountMaterialDays",
                newName: "IX_CountMaterialDays_DayMatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountMaterialDays",
                table: "CountMaterialDays",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CountMaterialDays_DayMats_DayMatId",
                table: "CountMaterialDays",
                column: "DayMatId",
                principalTable: "DayMats",
                principalColumn: "DayMatId");

            migrationBuilder.AddForeignKey(
                name: "FK_CountMaterialDays_Material_MaterialId",
                table: "CountMaterialDays",
                column: "MaterialId",
                principalTable: "Material",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountMaterialDays_DayMats_DayMatId",
                table: "CountMaterialDays");

            migrationBuilder.DropForeignKey(
                name: "FK_CountMaterialDays_Material_MaterialId",
                table: "CountMaterialDays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountMaterialDays",
                table: "CountMaterialDays");

            migrationBuilder.RenameTable(
                name: "CountMaterialDays",
                newName: "CountMaterialDay");

            migrationBuilder.RenameIndex(
                name: "IX_CountMaterialDays_MaterialId",
                table: "CountMaterialDay",
                newName: "IX_CountMaterialDay_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_CountMaterialDays_DayMatId",
                table: "CountMaterialDay",
                newName: "IX_CountMaterialDay_DayMatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountMaterialDay",
                table: "CountMaterialDay",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CountMaterialDay_DayMats_DayMatId",
                table: "CountMaterialDay",
                column: "DayMatId",
                principalTable: "DayMats",
                principalColumn: "DayMatId");

            migrationBuilder.AddForeignKey(
                name: "FK_CountMaterialDay_Material_MaterialId",
                table: "CountMaterialDay",
                column: "MaterialId",
                principalTable: "Material",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
