using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentDetail.Migrations
{
    /// <inheritdoc />
    public partial class YearofEnrollementAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "studentsection",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "YearOfEnrollement",
                table: "Students",
                type: "integer",
                nullable: false,
                defaultValue: 2020);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearOfEnrollement",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "studentsection",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "N/A");
        }
    }
}
