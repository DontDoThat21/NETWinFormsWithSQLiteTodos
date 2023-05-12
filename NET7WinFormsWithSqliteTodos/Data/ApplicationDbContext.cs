using Microsoft.EntityFrameworkCore;
using NET7WinFormsWithSqliteTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET7WinFormsWithSqliteTodos.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\Tylor\\source\\repos\\NET7WinFormsWithSqliteTodos\\DB\\ToDosDB.db");
        }

        public DbSet<ToDo> ToDos { get; set; }

    }
}
