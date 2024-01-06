﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenMinhQuan546.Migrations
{
    /// <inheritdoc />
    public partial class CREATE_TABLE_SinhVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    MaSinhVien = table.Column<string>(type: "TEXT", nullable: false),
                    HoTen = table.Column<string>(type: "TEXT", nullable: false),
                    MaLop = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.MaSinhVien);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhVien");
        }
    }
}
