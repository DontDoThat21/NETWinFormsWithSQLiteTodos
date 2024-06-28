using NETWinFormsWithSqliteTodos.Data;
using NETWinFormsWithSqliteTodos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETWinFormsWithSqliteTodos.UI
{
    public partial class frmTodoDetail : Form
    {
        frmMain _main;
        public frmTodoDetail(Form main)
        {
            InitializeComponent();
            _main = (frmMain?)main;
        }

        TodosManager _todoManager = new TodosManager();

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

        public string GetCurrentTodoStatus()
        {
            string status = "";
            foreach (var obj in gboxStatus.Controls)
            {
                Button btn = (Button)obj;
                if (btn.BackColor == Color.FromName("ControlDark"))
                {
                    status = btn.Text;
                    break;
                }
            }
            return status;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ChangeStatusColor(sender);
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            ChangeStatusColor(sender);
        }
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            ChangeStatusColor(sender);
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

        private void btnUpdateTodo_Click(object sender, EventArgs e)
        {
            try
            {
                ToDo todo = new ToDo(); //_dbContext.ToDos.FirstOrDefault(t => t.Id == id);
                if (string.IsNullOrEmpty(txtTodoName.Text))
                {
                    MessageBox.Show("Please enter name.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTodoName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtTodoDesc.Text))
                {
                    MessageBox.Show("Please enter todo description.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTodoDesc.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(dateTodoBy.Value.ToString()))
                {
                    MessageBox.Show("Please enter a todo date.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateTodoBy.Focus();
                    return;
                }
                todo.Id = Convert.ToInt16(lblId.Text);
                todo.TodoName = txtTodoName.Text;
                todo.Description = txtTodoDesc.Text;
                todo.Status = GetCurrentTodoStatus();
                todo.DateToBeCompleted = dateTodoBy.Value;
                if (_todoManager.Update(todo))
                {
                    MessageBox.Show("Student has been modified.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    _main.LoadTodos();
                    _main.ResetText();
                    _main.Visible = true;
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("Todo update failed.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
