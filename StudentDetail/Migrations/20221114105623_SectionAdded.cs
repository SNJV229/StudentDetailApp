using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentDetail.Migrations
{
    /// <inheritdoc />
    public partial class SectionAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "studentsection",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "N/A");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "studentsection",
                table: "Students");
        }
    }
}
