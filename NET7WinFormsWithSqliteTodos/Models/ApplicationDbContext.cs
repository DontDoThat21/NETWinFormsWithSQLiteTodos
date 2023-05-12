using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET7WinFormsWithSqliteTodos.Models
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
