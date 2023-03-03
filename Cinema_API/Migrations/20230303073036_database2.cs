using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema_API.Migrations
{
    public partial class database2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CinemaRoomId",
                table: "Phim",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phim_CinemaRoomId",
                table: "Phim",
                column: "CinemaRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Phim_FilmFormCode",
                table: "Phim",
                column: "FilmFormCode");

            migrationBuilder.CreateIndex(
                name: "IX_Phim_TypeOfFilmCode",
                table: "Phim",
                column: "TypeOfFilmCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Phim_DangPhim_FilmFormCode",
                table: "Phim",
                column: "FilmFormCode",
                principalTable: "DangPhim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Phim_PhongChieuPhim_CinemaRoomId",
                table: "Phim",
                column: "CinemaRoomId",
                principalTable: "PhongChieuPhim",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Phim_TheLoaiPhim_TypeOfFilmCode",
                table: "Phim",
                column: "TypeOfFilmCode",
                principalTable: "TheLoaiPhim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phim_DangPhim_FilmFormCode",
                table: "Phim");

            migrationBuilder.DropForeignKey(
                name: "FK_Phim_PhongChieuPhim_CinemaRoomId",
                table: "Phim");

            migrationBuilder.DropForeignKey(
                name: "FK_Phim_TheLoaiPhim_TypeOfFilmCode",
                table: "Phim");

            migrationBuilder.DropIndex(
                name: "IX_Phim_CinemaRoomId",
                table: "Phim");

            migrationBuilder.DropIndex(
                name: "IX_Phim_FilmFormCode",
                table: "Phim");

            migrationBuilder.DropIndex(
                name: "IX_Phim_TypeOfFilmCode",
                table: "Phim");

            migrationBuilder.DropColumn(
                name: "CinemaRoomId",
                table: "Phim");
        }
    }
}
