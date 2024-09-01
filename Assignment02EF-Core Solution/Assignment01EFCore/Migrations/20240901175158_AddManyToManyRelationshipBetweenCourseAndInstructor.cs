using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment01EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddManyToManyRelationshipBetweenCourseAndInstructor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseInstructor",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInstructor", x => new { x.CourseId, x.InstructorId });
                    table.ForeignKey(
                        name: "FK_CourseInstructor_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseInstructor_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "InstructorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseInstructor_InstructorId",
                table: "CourseInstructor",
                column: "InstructorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseInstructor");
        }
    }
}
