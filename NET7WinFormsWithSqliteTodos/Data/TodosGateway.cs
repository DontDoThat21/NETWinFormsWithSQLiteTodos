using NETWinFormsWithSqliteTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace NETWinFormsWithSqliteTodos.Data
{
    public class TodosGateway
    {
        private readonly SqliteConnection _connection;

        public TodosGateway()
        {
            var connectionString = new SqliteConnectionStringBuilder
            {
                DataSource = "todos.db",
                Mode = SqliteOpenMode.ReadWriteCreate,
                Cache = SqliteCacheMode.Shared
            }.ToString();

            _connection = new SqliteConnection(connectionString);
        }

        public async Task<bool> AddAsync(ToDo todo)
        {
            await _connection.OpenAsync();
            var command = _connection.CreateCommand();
            command.CommandText = "INSERT INTO ToDos (TodoName, Description, Status, DateToBeCompleted, DateAdded) VALUES (@name, @desc, @status, @dateToBeCompleted, @dateAdded)";
            command.Parameters.AddWithValue("@name", todo.TodoName);
            command.Parameters.AddWithValue("@desc", todo.Description);
            command.Parameters.AddWithValue("@status", todo.Status);
            command.Parameters.AddWithValue("@dateToBeCompleted", todo.DateToBeCompleted);
            command.Parameters.AddWithValue("@dateAdded", todo.DateAdded);
            var result = await command.ExecuteNonQueryAsync();
            await _connection.CloseAsync();
            return result > 0;
        }

        public void EnsureTableExists()
        {
            _connection.Open();
            var command = _connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS ToDos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    TodoName TEXT NOT NULL,
                    Description TEXT NOT NULL,
                    Status TEXT NOT NULL,
                    DateToBeCompleted TEXT NOT NULL,
                    DateAdded TEXT NOT NULL
                );";
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void EnsureIndexes()
        {
            EnsureTableExists(); // Ensure the table exists before creating indexes
            _connection.Open();
            var command = _connection.CreateCommand();
            command.CommandText = "CREATE INDEX IF NOT EXISTS idx_status ON ToDos (Status);";
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public async Task<List<ToDo>> GetAllAsync()
        {
            await _connection.OpenAsync();
            var command = _connection.CreateCommand();
            command.CommandText = "SELECT * FROM ToDos";
            var reader = await command.ExecuteReaderAsync();
            var todos = new List<ToDo>();
            while (await reader.ReadAsync())
            {
                todos.Add(new ToDo
                {
                    Id = reader.GetInt32(0),
                    TodoName = reader.GetString(1),
                    Description = reader.GetString(2),
                    Status = reader.GetString(3),
                    DateToBeCompleted = reader.GetDateTime(4),
                    DateAdded = reader.GetDateTime(5)
                });
            }
            await _connection.CloseAsync();
            return todos;
        }

        public async Task<bool> UpdateAsync(ToDo todo)
        {
            await _connection.OpenAsync();
            var command = _connection.CreateCommand();
            command.CommandText = "UPDATE ToDos SET TodoName = @name, Description = @desc, Status = @status, DateToBeCompleted = @dateToBeCompleted WHERE Id = @id";
            command.Parameters.AddWithValue("@name", todo.TodoName);
            command.Parameters.AddWithValue("@desc", todo.Description);
            command.Parameters.AddWithValue("@status", todo.Status);
            command.Parameters.AddWithValue("@dateToBeCompleted", todo.DateToBeCompleted);
            command.Parameters.AddWithValue("@id", todo.Id);
            var result = await command.ExecuteNonQueryAsync();
            await _connection.CloseAsync();
            return result > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await _connection.OpenAsync();
            var command = _connection.CreateCommand();
            command.CommandText = "DELETE FROM ToDos WHERE Id = @id";
            command.Parameters.AddWithValue("@id", id);
            var result = await command.ExecuteNonQueryAsync();
            await _connection.CloseAsync();
            return result > 0;
        }
    }
}
