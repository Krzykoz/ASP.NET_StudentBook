using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_Student_Book.Data.Migrations
{
    public partial class RemovingClassRelationFromGradeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Classes_ClassId",
                table: "Grades");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Grades",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Classes_ClassId",
                table: "Grades",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Classes_ClassId",
                table: "Grades");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Grades",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Classes_ClassId",
                table: "Grades",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
