using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Website_clothing.Migrations
{
    /// <inheritdoc />
    public partial class updateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPhams_DanhMucSanPhams_ID",
                table: "SanPhams");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_IDDanhMucSanPham",
                table: "SanPhams",
                column: "IDDanhMucSanPham");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhams_DanhMucSanPhams_IDDanhMucSanPham",
                table: "SanPhams",
                column: "IDDanhMucSanPham",
                principalTable: "DanhMucSanPhams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPhams_DanhMucSanPhams_IDDanhMucSanPham",
                table: "SanPhams");

            migrationBuilder.DropIndex(
                name: "IX_SanPhams_IDDanhMucSanPham",
                table: "SanPhams");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhams_DanhMucSanPhams_ID",
                table: "SanPhams",
                column: "ID",
                principalTable: "DanhMucSanPhams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
