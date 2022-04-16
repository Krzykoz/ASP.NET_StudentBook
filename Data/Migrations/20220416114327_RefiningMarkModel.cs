using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_Student_Book.Data.Migrations
{
    public partial class RefiningMarkModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReceivedMark",
                table: "Marks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceivedMark",
                table: "Marks");
        }
    }
}
