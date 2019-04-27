using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "Group",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "InDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "OutDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentGrade",
                table: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Subject",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InDate",
                table: "Students",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OutDate",
                table: "Students",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "StudentGrade",
                table: "Students",
                nullable: false,
                defaultValue: 0);
        }
    }
}
