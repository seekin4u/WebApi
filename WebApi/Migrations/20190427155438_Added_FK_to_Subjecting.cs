using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class Added_FK_to_Subjecting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Subjecting");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId1",
                table: "Subjecting",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjecting_SubjectId1",
                table: "Subjecting",
                column: "SubjectId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjecting_Subject_SubjectId1",
                table: "Subjecting",
                column: "SubjectId1",
                principalTable: "Subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjecting_Subject_SubjectId1",
                table: "Subjecting");

            migrationBuilder.DropIndex(
                name: "IX_Subjecting_SubjectId1",
                table: "Subjecting");

            migrationBuilder.DropColumn(
                name: "SubjectId1",
                table: "Subjecting");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Subjecting",
                nullable: false,
                defaultValue: 0);
        }
    }
}
