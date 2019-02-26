using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS_Na18.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_Person_PersonId",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_MyActivity_Module_ModuleId",
                table: "MyActivity");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "MyActivity");

            migrationBuilder.AlterColumn<int>(
                name: "ModuleId",
                table: "MyActivity",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Document",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Person_PersonId",
                table: "Document",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyActivity_Module_ModuleId",
                table: "MyActivity",
                column: "ModuleId",
                principalTable: "Module",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_Person_PersonId",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_MyActivity_Module_ModuleId",
                table: "MyActivity");

            migrationBuilder.AlterColumn<int>(
                name: "ModuleId",
                table: "MyActivity",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "MyActivity",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Document",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Person_PersonId",
                table: "Document",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MyActivity_Module_ModuleId",
                table: "MyActivity",
                column: "ModuleId",
                principalTable: "Module",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
