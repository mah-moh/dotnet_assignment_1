using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_1_webapi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courseModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstructorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfCredits = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "studentModels",
                columns: table => new
                {
                    StudentID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoiningBatch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<int>(type: "int", nullable: false),
                    Degree = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentModels", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "semesterModels",
                columns: table => new
                {
                    SemesterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SemesterCode = table.Column<int>(type: "int", nullable: false),
                    studentId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_semesterModels", x => x.SemesterId);
                    table.ForeignKey(
                        name: "FK_semesterModels_studentModels_studentId",
                        column: x => x.studentId,
                        principalTable: "studentModels",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "semesterCoursesModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SemesterId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_semesterCoursesModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_semesterCoursesModels_courseModels_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courseModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_semesterCoursesModels_semesterModels_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "semesterModels",
                        principalColumn: "SemesterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_semesterCoursesModels_CourseId",
                table: "semesterCoursesModels",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_semesterCoursesModels_SemesterId",
                table: "semesterCoursesModels",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_semesterModels_studentId",
                table: "semesterModels",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_studentModels_StudentID",
                table: "studentModels",
                column: "StudentID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "semesterCoursesModels");

            migrationBuilder.DropTable(
                name: "courseModels");

            migrationBuilder.DropTable(
                name: "semesterModels");

            migrationBuilder.DropTable(
                name: "studentModels");
        }
    }
}
