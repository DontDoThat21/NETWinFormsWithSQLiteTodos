using Microsoft.EntityFrameworkCore;
using NETWinFormsWithSqliteTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETWinFormsWithSqliteTodos.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\Tylor\\source\\repos\\NETWinFormsWithSqliteTodos\\DB\\ToDosDB.db");
        }

        public DbSet<ToDo> ToDos { get; set; }

    }
}
