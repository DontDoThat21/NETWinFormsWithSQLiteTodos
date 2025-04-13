using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NETWinFormsWithSqliteTodos.Migrations
{
    /// <inheritdoc />
    public partial class DBColNameChangedToTodosName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ToDos",
                newName: "TodoName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TodoName",
                table: "ToDos",
                newName: "Name");
        }
    }
}
