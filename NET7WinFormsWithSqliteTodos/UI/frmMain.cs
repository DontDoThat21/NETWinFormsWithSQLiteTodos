
using NET7WinFormsWithSqliteTodos.Data;
using NET7WinFormsWithSqliteTodos.Models;

namespace NET7WinFormsWithSqliteTodos.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        ApplicationDbContext _dbContext = new ApplicationDbContext();

        /// <summary>
        /// This replaces the top text with the logged in Window's users name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            this.Text = this.Text.Replace("User", userName);
            LoadTodos();
        }

        private void Reset()
        {
            txtTodoDesc.Text = "todo details here";
            txtTodoName.Text = "todo name here";
            txtTodoFilter.Text = "type search filter here";
        }

        private void LoadTodos()
        {
            List<ToDo> todos = _dbContext.ToDos.ToList();
            dgvTodos.Rows.Clear();
            foreach (var todo in todos)
            {
                dgvTodos.Rows.Add(todo.Id, todo.TodoName, todo.Description, todo.Date);
            }
        }

        /// <summary>
        /// This is the picture box for the add/create new todo button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxAddNewToDo_Click(object sender, EventArgs e)
        {
            try
            {
                ToDo todo = new ToDo();
                todo.TodoName = txtTodoName.Text;
                todo.Description = txtTodoDesc.Text;
                _dbContext.ToDos.Add(todo);
                if (_dbContext.SaveChanges() > 0)
                {
                    MessageBox.Show($"A new todo has been saved.", "Todo saved...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Saving a new todo was not successful.", "Warning...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not create a new todo. Error: {ex.Message}", "Error adding todo...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Reset();
                LoadTodos();
            }
        }

        /// <summary>
        /// This is the all todos filter option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAll_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the active todos filter option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActive_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the completed todos filter option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompleted_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the filter/search box text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTodoFilter_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the main todo text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTodoDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTodoName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
