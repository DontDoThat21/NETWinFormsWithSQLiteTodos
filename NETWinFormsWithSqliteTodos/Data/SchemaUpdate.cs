using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace NETWinFormsWithSqliteTodos.Data
{
    public class SchemaUpdate
    {
        private readonly SqliteConnection _connection;

        public SchemaUpdate(SqliteConnection connection)
        {
            _connection = connection;
        }

        public void UpdateSchema()
        {
            try
            {
                Console.WriteLine("Starting schema update...");
                _connection.Open();
                
                // Check if the columns exist and add them if they don't
                if (!ColumnExists("Priority"))
                {
                    Console.WriteLine("Adding Priority column");
                    AddColumn("Priority", "TEXT", "'Medium'");
                }
                
                if (!ColumnExists("IsRecurring"))
                {
                    Console.WriteLine("Adding IsRecurring column");
                    AddColumn("IsRecurring", "INTEGER", "0");
                }
                
                if (!ColumnExists("RecurrenceInterval"))
                {
                    Console.WriteLine("Adding RecurrenceInterval column");
                    AddColumn("RecurrenceInterval", "TEXT", "NULL");
                }
                
                // Verify the update worked
                VerifyColumns();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating schema: {ex.Message}\n{ex.StackTrace}");
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
        }

        private bool ColumnExists(string columnName)
        {
            var command = _connection.CreateCommand();
            command.CommandText = $"PRAGMA table_info(ToDos)";
            
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(1);
                if (name.Equals(columnName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            
            return false;
        }

        private void AddColumn(string columnName, string dataType, string defaultValue)
        {
            var command = _connection.CreateCommand();
            command.CommandText = $"ALTER TABLE ToDos ADD COLUMN {columnName} {dataType} DEFAULT {defaultValue}";
            command.ExecuteNonQuery();
        }

        private void VerifyColumns()
        {
            var command = _connection.CreateCommand();
            command.CommandText = $"PRAGMA table_info(ToDos)";
            
            using var reader = command.ExecuteReader();
            Console.WriteLine("Current table schema:");
            while (reader.Read())
            {
                string name = reader.GetString(1);
                string type = reader.GetString(2);
                Console.WriteLine($"Column: {name} Type: {type}");
            }
        }
    }
}
