using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NETWinFormsWithSqliteTodos.Migrations
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

            migrationBuilder.AddColumn<string>(
                name: "Priority",
                table: "ToDos",
                type: "TEXT",
                nullable: false,
                defaultValue: "Medium");

            migrationBuilder.AddColumn<bool>(
                name: "IsRecurring",
                table: "ToDos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "RecurrenceInterval",
                table: "ToDos",
                type: "TEXT",
                nullable: true);
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
