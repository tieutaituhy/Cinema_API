using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema_API.Migrations
{
    public partial class database3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Ve_CustomerCode",
                table: "Ve",
                column: "CustomerCode");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_EmployeeCode",
                table: "Ve",
                column: "EmployeeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_TicketTypeCode",
                table: "Ve",
                column: "TicketTypeCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Ve_KhachHang_CustomerCode",
                table: "Ve",
                column: "CustomerCode",
                principalTable: "KhachHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ve_LoaiVe_TicketTypeCode",
                table: "Ve",
                column: "TicketTypeCode",
                principalTable: "LoaiVe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ve_NhanVien_EmployeeCode",
                table: "Ve",
                column: "EmployeeCode",
                principalTable: "NhanVien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ve_KhachHang_CustomerCode",
                table: "Ve");

            migrationBuilder.DropForeignKey(
                name: "FK_Ve_LoaiVe_TicketTypeCode",
                table: "Ve");

            migrationBuilder.DropForeignKey(
                name: "FK_Ve_NhanVien_EmployeeCode",
                table: "Ve");

            migrationBuilder.DropIndex(
                name: "IX_Ve_CustomerCode",
                table: "Ve");

            migrationBuilder.DropIndex(
                name: "IX_Ve_EmployeeCode",
                table: "Ve");

            migrationBuilder.DropIndex(
                name: "IX_Ve_TicketTypeCode",
                table: "Ve");
        }
    }
}
