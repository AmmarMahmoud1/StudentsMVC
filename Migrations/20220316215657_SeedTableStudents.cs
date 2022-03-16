using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsMangment.Migrations
{
    public partial class SeedTableStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "CourseTitle", "Email", "FullName" },
                values: new object[] { 112233, "IT", "John@it.com", "John Snow" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 112233);
        }
    }
}
