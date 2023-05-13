using NET7WinFormsWithSqliteTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET7WinFormsWithSqliteTodos.Data
{
    public class TodosManager
    {
        TodosGateway _dbContext = new TodosGateway();

        public bool Add(ToDo todo)
        {
            return _dbContext.Add(todo);
        }

        public List<ToDo> GetAll()
        {
            return _dbContext.GetAll();
        }

        public bool Update(ToDo todo)
        {
            return _dbContext.Update(todo);
        }

        public bool Delete(int id)
        {
            return _dbContext.Delete(id);
        }
    }
}
