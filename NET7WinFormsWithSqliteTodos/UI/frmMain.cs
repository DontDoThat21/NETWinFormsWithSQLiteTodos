
using Microsoft.VisualBasic.ApplicationServices;
using NETWinFormsWithSqliteTodos.Data;
using NETWinFormsWithSqliteTodos.Models;
using NETWinFormsWithSqliteTodos.Properties;
using System.Data;

namespace NETWinFormsWithSqliteTodos.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        TodosManager _todosManager = new TodosManager();

        /// <summary>
        /// This replaces the top text with the logged in Window's users name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {

            try
            {
                string userName = Environment.UserName;
                this.Text = this.Text.Replace("{User}", userName);
                LoadTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Reset()
        {
            txtTodoDesc.Text = "todo details here";
            txtTodoName.Text = "todo name here";
            txtTodoFilter.Text = "type search filter here";
        }

        public void LoadTodos()
        {
            try
            {
                TodosManager todosManager = new TodosManager();
                List<ToDo> todos = todosManager.GetAll();
                dgvTodos.Rows.Clear();
                foreach (var todo in todos)
                {
                    dgvTodos.Rows.Add(todo.Id, todo.TodoName, todo.Description,
                        todo.Status, todo.DateToBeCompleted, todo.DateAdded);
                }
                dgvTodos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}",
                    "Couldn't load todos.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// This is the picture box for the add/create new todo button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pboxAddNewToDo_Click(object sender, EventArgs e)
        {

            bool isValid = ValidateNewButtonSubmission();
            if (!isValid)
            {
                MessageBox.Show("You can't save a todo without filling out the todo information first.",
                    "Invalid todo details.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(txtTodoName.Text))
                {
                    MessageBox.Show("Please enter a todo name.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTodoName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtTodoDesc.Text))
                {
                    MessageBox.Show("Please enter a todo description.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTodoDesc.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(dateTodoBy.Value.ToString()))
                {
                    MessageBox.Show("Please enter a todo to be completed by date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateTodoBy.Focus();
                    return;
                }

                ToDo todo = new ToDo();
                todo.TodoName = txtTodoName.Text;
                todo.Description = txtTodoDesc.Text;
                todo.DateToBeCompleted = dateTodoBy.Value;
                todo.Status = GetCurrentTodoStatus();

                if (_todosManager.Add(todo))
                {
                    MessageBox.Show("Todo has been saved.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Todo save has failed.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                dgvTodos.Rows.Clear();
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
            ChangeStatusColor(sender);
            ValidateNewButtonSubmission();
        }

        private void ChangeStatusColor(object sender)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "all":
                    btnActive.BackColor = Color.FromName("Control");
                    btnCompleted.BackColor = Color.FromName("Control");
                    break;
                case "active":
                    btnAll.BackColor = Color.FromName("Control");
                    btnCompleted.BackColor = Color.FromName("Control");
                    break;
                case "completed":
                    btnAll.BackColor = Color.FromName("Control");
                    btnActive.BackColor = Color.FromName("Control");
                    break;
                default:
                    break;
            }
            btn.BackColor = Color.FromName("ControlDark");
        }

        public string GetCurrentTodoStatus()
        {
            string status = "";
            foreach (var obj in gboxStatus.Controls)
            {
                Button btn = (Button)obj;
                if (btn.BackColor == Color.FromName("ControlDark"))
                {
                    status = btn.Text;
                }
            }
            return status;
        }

        /// <summary>
        /// This is the active todos filter option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActive_Click(object sender, EventArgs e)
        {
            ChangeStatusColor(sender);
            ValidateNewButtonSubmission();
        }

        /// <summary>
        /// This is the completed todos filter option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            ChangeStatusColor(sender);
            ValidateNewButtonSubmission();
        }

        /// <summary>
        /// This is the filter/search box text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTodoFilter_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvTodos.DataSource;
            bs.Filter += dgvTodos.Columns[1].HeaderText.ToString() + " LIKE '%" + txtTodoFilter.Text + "%'";

            dgvTodos.DataSource = bs;

            //ValidateNewButtonSubmission();
        }

        private bool ValidateNewButtonSubmission()
        {
            bool isValid = true;
            if (btnActive.BackColor == Color.FromName("ControlDark") ||
                btnAll.BackColor == Color.FromName("ControlDark") ||
                btnCompleted.BackColor == Color.FromName("ControlDark")
               )
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtTodoName.Text.ToString()))
            {
                isValid = false;
            }
            else if (string.IsNullOrEmpty(txtTodoDesc.Text.ToString()))
            {
                isValid = false;
            }
            else if (string.IsNullOrEmpty(dateTodoBy.Value.ToString()))
            {
                isValid = false;
            }
            if (isValid)
            {
                pboxAddNewToDo.Image = Resources.btnAddTodo;
            }
            else
            {
                pboxAddNewToDo.Image = Resources.btnAddTodoInvalid;
            }

            return isValid;

        }

        /// <summary>
        /// This is the main todo text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTodoDesc_TextChanged(object sender, EventArgs e)
        {
            ValidateNewButtonSubmission();
        }

        private void txtTodoName_TextChanged(object sender, EventArgs e)
        {
            ValidateNewButtonSubmission();
        }

        private void dgvTodos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvR = dgvTodos.Rows[e.RowIndex];
                frmTodoDetail frmTodos = new frmTodoDetail(this);

                frmTodos.lblId.Text = dgvR.Cells[0].Value.ToString();
                frmTodos.txtTodoName.Text = dgvR.Cells[1].Value.ToString();
                frmTodos.txtTodoDesc.Text = dgvR.Cells[2].Value.ToString();
                frmTodos.SetStatusButton(GetCurrentTodoStatus());
                frmTodos.dateTodoBy.Value = dateTodoBy.Value;

                //this.Hide();
                frmTodos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetStatusButton(string status)
        {
            Button btn = new Button();
            switch (status)
            {
                case "all":
                    btnActive.BackColor = Color.FromName("Control");
                    btnCompleted.BackColor = Color.FromName("Control");
                    btn = btnAll;
                    break;
                case "active":
                    btnAll.BackColor = Color.FromName("Control");
                    btnCompleted.BackColor = Color.FromName("Control");
                    btn = btnActive;
                    break;
                case "completed":
                    btnAll.BackColor = Color.FromName("Control");
                    btnActive.BackColor = Color.FromName("Control");
                    btn = btnCompleted;
                    break;
                default:
                    break;
            }

            btn.BackColor = Color.FromName("ControlDark");
        }

        private void pboxAddNewToDo_MouseHover(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvTodos.Rows[dgvTodos.CurrentCell.RowIndex];
                if (MessageBox.Show("Do you want to delete?", "Question...",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dr.Cells[0].Value;
                    bool isDelete = _todosManager.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("Todo has been removed.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ssLoadData();
                        dgvTodos.Rows.Remove(dr);
                    }
                    else
                    {
                        MessageBox.Show("Todo removal failed.", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pboxFilterReset_Click(object sender, EventArgs e)
        {
            txtTodoFilter.Text = string.Empty;
            LoadTodos();
        }
    }
}
