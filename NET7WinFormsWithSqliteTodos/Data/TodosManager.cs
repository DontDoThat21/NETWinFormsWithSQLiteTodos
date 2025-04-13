using NETWinFormsWithSqliteTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETWinFormsWithSqliteTodos.Data
{
    public class TodosManager
    {
        private readonly TodosGateway _dbContext;

        public TodosManager()
        {
            _dbContext = new TodosGateway();
            _dbContext.EnsureIndexes(); // Ensure indexes are created
        }

        public async Task<bool> AddAsync(ToDo todo)
        {
            return await _dbContext.AddAsync(todo); // Use AddAsync from TodosGateway
        }

        public async Task<List<ToDo>> GetAllAsync()
        {
            return await _dbContext.GetAllAsync(); // Use GetAllAsync from TodosGateway
        }

        public async Task<bool> UpdateAsync(ToDo todo)
        {
            return await _dbContext.UpdateAsync(todo); // Use UpdateAsync from TodosGateway
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _dbContext.DeleteAsync(id); // Use DeleteAsync from TodosGateway
        }
    }
}
