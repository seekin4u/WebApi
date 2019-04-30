using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class Added_FK_to_teacher_and_student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Subjecting");

            migrationBuilder.DropColumn(
                name: "SubjectingTeachers",
                table: "Subjecting");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Group");

            migrationBuilder.AddColumn<int>(
                name: "SubjectingId",
                table: "Teacher",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeachingGroupGroupId",
                table: "Subjecting",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Student",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupCuratorTeacherId",
                table: "Group",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_SubjectingId",
                table: "Teacher",
                column: "SubjectingId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjecting_TeachingGroupGroupId",
                table: "Subjecting",
                column: "TeachingGroupGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GroupId",
                table: "Student",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_GroupCuratorTeacherId",
                table: "Group",
                column: "GroupCuratorTeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Teacher_GroupCuratorTeacherId",
                table: "Group",
                column: "GroupCuratorTeacherId",
                principalTable: "Teacher",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Group_GroupId",
                table: "Student",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjecting_Group_TeachingGroupGroupId",
                table: "Subjecting",
                column: "TeachingGroupGroupId",
                principalTable: "Group",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Group_Teacher_GroupCuratorTeacherId",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Group_GroupId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjecting_Group_TeachingGroupGroupId",
                table: "Subjecting");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Subjecting_SubjectingId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_SubjectingId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Subjecting_TeachingGroupGroupId",
                table: "Subjecting");

            migrationBuilder.DropIndex(
                name: "IX_Student_GroupId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Group_GroupCuratorTeacherId",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "SubjectingId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "TeachingGroupGroupId",
                table: "Subjecting");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "GroupCuratorTeacherId",
                table: "Group");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Subjecting",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubjectingTeachers",
                table: "Subjecting",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Group",
                nullable: false,
                defaultValue: 0);
        }
    }
}
