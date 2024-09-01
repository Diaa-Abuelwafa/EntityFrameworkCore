using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment01EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddOneToOneRelationshipBetweenCourseAndTopic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicId",
                table: "Courses",
                column: "TopicId",
                unique: true,
                filter: "[TopicId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_TopicId",
                table: "Courses",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "TopicId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopicId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Courses");
        }
    }
}
