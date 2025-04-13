using System;
using System.Windows.Forms;
using NETWinFormsWithSqliteTodos.Data;
using NETWinFormsWithSqliteTodos.UI;

namespace NETWinFormsWithSqliteTodos.UI
{
    internal static class ApplicationEntry
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Initialize database schema
            var todosGateway = new TodosGateway();
            todosGateway.EnsureTableExists();
            todosGateway.UpdateSchema(); // Update schema to include new fields
            
            Application.Run(new frmMain());
        }
    }
}
