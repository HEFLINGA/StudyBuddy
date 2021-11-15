using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcStudyBuddy.Migrations.MvcStudyBuddy2
{
    public partial class possible_points : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "possible_points",
                table: "Course",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "possible_points",
                table: "Course");
        }
    }
}
