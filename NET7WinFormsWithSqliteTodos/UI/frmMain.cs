
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
                todo.Name = txtTodoDesc.Text;
                todo.Date = DateTime.Now;
                todo.Description = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not create a new todo. Error: {ex.Message}", "Error adding todo...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the main todo text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAddTodo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
