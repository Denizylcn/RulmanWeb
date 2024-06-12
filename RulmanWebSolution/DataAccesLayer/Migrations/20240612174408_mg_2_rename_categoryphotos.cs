using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    public partial class mg_2_rename_categoryphotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Categories_categoryIdid",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photos",
                table: "Photos");

            migrationBuilder.RenameTable(
                name: "Photos",
                newName: "CategoryPhotos");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_categoryIdid",
                table: "CategoryPhotos",
                newName: "IX_CategoryPhotos_categoryIdid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryPhotos",
                table: "CategoryPhotos",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryPhotos_Categories_categoryIdid",
                table: "CategoryPhotos",
                column: "categoryIdid",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryPhotos_Categories_categoryIdid",
                table: "CategoryPhotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryPhotos",
                table: "CategoryPhotos");

            migrationBuilder.RenameTable(
                name: "CategoryPhotos",
                newName: "Photos");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryPhotos_categoryIdid",
                table: "Photos",
                newName: "IX_Photos_categoryIdid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photos",
                table: "Photos",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Categories_categoryIdid",
                table: "Photos",
                column: "categoryIdid",
                principalTable: "Categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
