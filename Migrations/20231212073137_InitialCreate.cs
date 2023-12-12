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
                name: "semesterModels",
                columns: table => new
                {
                    SemesterCode = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_semesterModels", x => x.SemesterCode);
                });

            migrationBuilder.CreateTable(
                name: "studentModels",
                columns: table => new
                {
                    StudentID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoiningBatch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<int>(type: "int", nullable: false),
                    Degree = table.Column<int>(type: "int", nullable: false),
                    SemesterCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentModels", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_studentModels_semesterModels_SemesterCode",
                        column: x => x.SemesterCode,
                        principalTable: "semesterModels",
                        principalColumn: "SemesterCode");
                });

            migrationBuilder.CreateIndex(
                name: "IX_studentModels_SemesterCode",
                table: "studentModels",
                column: "SemesterCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courseModels");

            migrationBuilder.DropTable(
                name: "studentModels");

            migrationBuilder.DropTable(
                name: "semesterModels");
        }
    }
}
