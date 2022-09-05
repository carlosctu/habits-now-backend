using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class CreateUsernameHabit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Habit",
                newName: "UserEmail");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Duty",
                newName: "UserEmail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "Habit",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "Duty",
                newName: "Email");
        }
    }
}
