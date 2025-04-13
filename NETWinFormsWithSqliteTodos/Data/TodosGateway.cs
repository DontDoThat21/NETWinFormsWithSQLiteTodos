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
            try
            {
                await _connection.OpenAsync();
                var command = _connection.CreateCommand();
                command.CommandText = @"INSERT INTO ToDos (
                                      TodoName, 
                                      Description, 
                                      Status, 
                                      DateToBeCompleted, 
                                      DateAdded,
                                      Priority,
                                      IsRecurring,
                                      RecurrenceInterval) 
                                      VALUES (
                                      @name, 
                                      @desc, 
                                      @status, 
                                      @dateToBeCompleted, 
                                      @dateAdded,
                                      @priority,
                                      @isRecurring,
                                      @recurrenceInterval)";
                command.Parameters.AddWithValue("@name", todo.TodoName);
                command.Parameters.AddWithValue("@desc", todo.Description);
                command.Parameters.AddWithValue("@status", todo.Status);
                command.Parameters.AddWithValue("@dateToBeCompleted", todo.DateToBeCompleted);
                command.Parameters.AddWithValue("@dateAdded", todo.DateAdded);
                command.Parameters.AddWithValue("@priority", todo.Priority ?? "Medium");
                command.Parameters.AddWithValue("@isRecurring", todo.IsRecurring);
                command.Parameters.AddWithValue("@recurrenceInterval", todo.RecurrenceInterval.HasValue ? (object)todo.RecurrenceInterval.Value : DBNull.Value);

                var result = await command.ExecuteNonQueryAsync();
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in TodosGateway.AddAsync: {ex.Message}");
                return false;
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public void EnsureTableExists()
        {
            try
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
                        DateAdded TEXT NOT NULL,
                        Priority TEXT DEFAULT 'Medium',
                        IsRecurring INTEGER DEFAULT 0,
                        RecurrenceInterval TEXT
                    );";
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating table: {ex.Message}");
            }
            finally
            {
                _connection.Close();
            }
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
            try
            {
                await _connection.OpenAsync();
                var command = _connection.CreateCommand();
                
                // Explicitly list all columns to ensure we're getting all fields
                command.CommandText = @"SELECT 
                    Id, 
                    TodoName, 
                    Description, 
                    Status, 
                    DateToBeCompleted, 
                    DateAdded, 
                    Priority, 
                    IsRecurring, 
                    RecurrenceInterval 
                    FROM ToDos";
                    
                var reader = await command.ExecuteReaderAsync();
                var todos = new List<ToDo>();
                
                while (await reader.ReadAsync())
                {
                    var todo = new ToDo
                    {
                        Id = reader.GetInt32(0),
                        TodoName = reader.GetString(1),
                        Description = reader.GetString(2),
                        Status = reader.GetString(3),
                        DateToBeCompleted = reader.GetDateTime(4),
                        DateAdded = reader.GetDateTime(5)
                    };
                    
                    // Handle nullable/optional fields
                    if (!reader.IsDBNull(6))
                        todo.Priority = reader.GetString(6);
                        
                    if (!reader.IsDBNull(7))
                        todo.IsRecurring = reader.GetBoolean(7);
                        
                    if (!reader.IsDBNull(8))
                        todo.RecurrenceInterval = TimeSpan.Parse(reader.GetString(8));
                        
                    todos.Add(todo);
                }
                
                return todos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllAsync: {ex.Message}");
                return new List<ToDo>(); // Return empty list instead of null
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    await _connection.CloseAsync();
            }
        }

        public async Task<bool> UpdateAsync(ToDo todo)
        {
            if (todo == null)
            {
                Console.WriteLine("UpdateAsync: todo object is null");
                return false;
            }
                
            try
            {
                Console.WriteLine($"Updating todo ID {todo.Id} in database");
                
                await _connection.OpenAsync();
                var command = _connection.CreateCommand();
                
                // Update SQL to include all fields
                command.CommandText = @"UPDATE ToDos SET 
                    TodoName = @name, 
                    Description = @desc, 
                    Status = @status, 
                    DateToBeCompleted = @dateToBeCompleted,
                    Priority = @priority,
                    IsRecurring = @isRecurring,
                    RecurrenceInterval = @recurrenceInterval
                    WHERE Id = @id";
                
                // Add parameters with clear debug logging
                Console.WriteLine($"Setting parameters for todo update: ID={todo.Id}");
                
                command.Parameters.AddWithValue("@id", todo.Id);
                command.Parameters.AddWithValue("@name", todo.TodoName ?? string.Empty);
                command.Parameters.AddWithValue("@desc", todo.Description ?? string.Empty);
                command.Parameters.AddWithValue("@status", todo.Status ?? string.Empty);
                command.Parameters.AddWithValue("@dateToBeCompleted", todo.DateToBeCompleted.ToString("yyyy-MM-dd HH:mm:ss"));
                command.Parameters.AddWithValue("@priority", todo.Priority ?? "Medium");
                command.Parameters.AddWithValue("@isRecurring", todo.IsRecurring ? 1 : 0); // SQLite uses 1/0 for boolean
                
                // Handle nullable TimeSpan
                if (todo.RecurrenceInterval.HasValue)
                {
                    Console.WriteLine($"RecurrenceInterval: {todo.RecurrenceInterval.Value}");
                    command.Parameters.AddWithValue("@recurrenceInterval", todo.RecurrenceInterval.Value.ToString());
                }
                else
                {
                    Console.WriteLine("RecurrenceInterval: NULL");
                    command.Parameters.AddWithValue("@recurrenceInterval", DBNull.Value);
                }
                
                // Execute the update
                var result = await command.ExecuteNonQueryAsync();
                Console.WriteLine($"Update result: {result} rows affected");
                
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateAsync: {ex.Message}\n{ex.StackTrace}");
                return false;
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    await _connection.CloseAsync();
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Invalid ID provided for deletion.");
                }

                await _connection.OpenAsync(); // Ensure the connection is opened
                string query = "DELETE FROM ToDos WHERE Id = @Id";
                using (var command = new SqliteCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in TodosGateway.DeleteAsync: {ex.Message}");
                return false;
            }
            finally
            {
                await _connection.CloseAsync(); // Ensure the connection is closed
            }
        }

        public async Task<ToDo> GetByIdAsync(int id)
        {
            try
            {
                await _connection.OpenAsync();
                var command = _connection.CreateCommand();
                command.CommandText = @"
                    SELECT Id, TodoName, Description, Status, DateToBeCompleted, DateAdded, Priority, IsRecurring, RecurrenceInterval 
                    FROM ToDos 
                    WHERE Id = @id";
                command.Parameters.AddWithValue("@id", id);
                
                var reader = await command.ExecuteReaderAsync();
                ToDo todo = null;
                
                if (await reader.ReadAsync())
                {
                    todo = new ToDo
                    {
                        Id = reader.GetInt32(0),
                        TodoName = reader.GetString(1),
                        Description = reader.GetString(2),
                        Status = reader.GetString(3),
                        DateToBeCompleted = reader.GetDateTime(4),
                        DateAdded = reader.GetDateTime(5)
                    };
                    
                    // Handle nullable fields
                    if (!reader.IsDBNull(6))
                        todo.Priority = reader.GetString(6);
                        
                    if (!reader.IsDBNull(7))
                        todo.IsRecurring = reader.GetBoolean(7);
                        
                    if (!reader.IsDBNull(8))
                    {
                        string timeSpanStr = reader.GetString(8);
                        if (TimeSpan.TryParse(timeSpanStr, out TimeSpan ts))
                            todo.RecurrenceInterval = ts;
                    }
                }
                
                return todo;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetByIdAsync: {ex.Message}");
                return null;
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    await _connection.CloseAsync();
            }
        }

        public void UpdateSchema()
        {
            var schemaUpdate = new SchemaUpdate(_connection);
            schemaUpdate.UpdateSchema();
        }
    }
}
