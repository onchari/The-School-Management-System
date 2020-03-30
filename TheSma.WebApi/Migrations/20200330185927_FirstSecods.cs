using Microsoft.EntityFrameworkCore.Migrations;

namespace TheSma.WebApi.Migrations
{
    public partial class FirstSecods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stream_Classes_ClassId",
                table: "Stream");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Stream",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stream_Classes_ClassId",
                table: "Stream",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stream_Classes_ClassId",
                table: "Stream");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Stream",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Stream_Classes_ClassId",
                table: "Stream",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
