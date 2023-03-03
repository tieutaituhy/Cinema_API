using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema_API.Migrations
{
    public partial class database1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuPhim_CinemaRoomCode",
                table: "ChiTietPhieuPhim",
                column: "CinemaRoomCode");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuPhim_MovieCode",
                table: "ChiTietPhieuPhim",
                column: "MovieCode");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuPhim_Phim_MovieCode",
                table: "ChiTietPhieuPhim",
                column: "MovieCode",
                principalTable: "Phim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuPhim_PhongChieuPhim_CinemaRoomCode",
                table: "ChiTietPhieuPhim",
                column: "CinemaRoomCode",
                principalTable: "PhongChieuPhim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuPhim_Phim_MovieCode",
                table: "ChiTietPhieuPhim");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuPhim_PhongChieuPhim_CinemaRoomCode",
                table: "ChiTietPhieuPhim");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietPhieuPhim_CinemaRoomCode",
                table: "ChiTietPhieuPhim");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietPhieuPhim_MovieCode",
                table: "ChiTietPhieuPhim");
        }
    }
}
