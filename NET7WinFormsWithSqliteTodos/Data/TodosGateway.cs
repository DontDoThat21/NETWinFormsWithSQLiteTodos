using NET7WinFormsWithSqliteTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET7WinFormsWithSqliteTodos.Data
{
    public class TodosGateway
    {

        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public bool Add(ToDo todo)
        {
            _dbContext.ToDos.Add(todo);
            return _dbContext.SaveChanges() > 0;
        }

        public List<ToDo> GetAll()
        {
            return _dbContext.ToDos.ToList();
        }

        public bool Update(ToDo todo)
        {
            var data = _dbContext.ToDos.FirstOrDefault(t => t.Id == todo.Id);
            if (data == null)
            {
                return false;
            }
            data.TodoName = todo.TodoName;
            data.Description = todo.Description;
            data.DateToBeCompleted = todo.DateToBeCompleted;
            data.Status = todo.Status;
            return _dbContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var student = _dbContext.ToDos.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return false;
            }
            _dbContext.ToDos.Remove(student);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
