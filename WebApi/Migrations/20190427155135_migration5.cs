using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HallId1",
                table: "Lesson",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectingId1",
                table: "Lesson",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(nullable: true),
                    TeacherId = table.Column<int>(nullable: false),
                    LessonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_Group_Lesson_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lesson",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hall",
                columns: table => new
                {
                    HallId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HallName = table.Column<string>(nullable: true),
                    HallLocation = table.Column<string>(nullable: true),
                    HallAviability = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hall", x => x.HallId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameSurname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubjectName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "Subjecting",
                columns: table => new
                {
                    SubjectingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubjectId = table.Column<int>(nullable: false),
                    SubjectingTeachers = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjecting", x => x.SubjectingId);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    TeacherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeacherNameSurname = table.Column<string>(nullable: true),
                    TeacherGrade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_HallId1",
                table: "Lesson",
                column: "HallId1");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_SubjectingId1",
                table: "Lesson",
                column: "SubjectingId1");

            migrationBuilder.CreateIndex(
                name: "IX_Group_LessonId",
                table: "Group",
                column: "LessonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Hall_HallId1",
                table: "Lesson",
                column: "HallId1",
                principalTable: "Hall",
                principalColumn: "HallId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Subjecting_SubjectingId1",
                table: "Lesson",
                column: "SubjectingId1",
                principalTable: "Subjecting",
                principalColumn: "SubjectingId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Hall_HallId1",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Subjecting_SubjectingId1",
                table: "Lesson");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Hall");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Subjecting");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Lesson_HallId1",
                table: "Lesson");

            migrationBuilder.DropIndex(
                name: "IX_Lesson_SubjectingId1",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "HallId1",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "SubjectingId1",
                table: "Lesson");
        }
    }
}
