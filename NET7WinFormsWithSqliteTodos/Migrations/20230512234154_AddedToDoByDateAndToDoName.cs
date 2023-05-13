using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NET7WinFormsWithSqliteTodos.Migrations
{
    /// <inheritdoc />
    public partial class AddedToDoByDateAndToDoName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "ToDos",
                newName: "Status");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "ToDos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateToBeCompleted",
                table: "ToDos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "DateToBeCompleted",
                table: "ToDos");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ToDos",
                newName: "Date");
        }
    }
}
