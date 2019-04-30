using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class _111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjecting_Teacher_SubjectingTeachersTeacherId",
                table: "Subjecting");

            migrationBuilder.DropIndex(
                name: "IX_Subjecting_SubjectingTeachersTeacherId",
                table: "Subjecting");

            migrationBuilder.DropColumn(
                name: "SubjectingTeachersTeacherId",
                table: "Subjecting");

            migrationBuilder.AddColumn<int>(
                name: "SubjectingId",
                table: "Teacher",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_SubjectingId",
                table: "Teacher",
                column: "SubjectingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Subjecting_SubjectingId",
                table: "Teacher",
                column: "SubjectingId",
                principalTable: "Subjecting",
                principalColumn: "SubjectingId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Subjecting_SubjectingId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_SubjectingId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "SubjectingId",
                table: "Teacher");

            migrationBuilder.AddColumn<int>(
                name: "SubjectingTeachersTeacherId",
                table: "Subjecting",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjecting_SubjectingTeachersTeacherId",
                table: "Subjecting",
                column: "SubjectingTeachersTeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjecting_Teacher_SubjectingTeachersTeacherId",
                table: "Subjecting",
                column: "SubjectingTeachersTeacherId",
                principalTable: "Teacher",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
