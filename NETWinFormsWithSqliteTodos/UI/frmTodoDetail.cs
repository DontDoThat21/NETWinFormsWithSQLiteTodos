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

        private async void btnUpdateTodo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateTodoDetails())
                {
                    return; // Stop execution if validation fails
                }

                ToDo todo = new ToDo
                {
                    Id = Convert.ToInt16(lblId.Text),
                    TodoName = txtTodoName.Text,
                    Description = txtTodoDesc.Text,
                    Status = GetCurrentTodoStatus(),
                    DateToBeCompleted = dateTodoBy.Value
                };

                if (await _todoManager.UpdateAsync(todo))
                {
                    MessageBox.Show("Todo has been updated successfully.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    _main.LoadTodos();
                    _main.ResetText();
                    _main.Visible = true;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Failed to update the todo. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateTodoDetails()
        {
            bool isValid = true;
            StringBuilder validationErrors = new StringBuilder();

            if (string.IsNullOrEmpty(txtTodoName.Text))
            {
                isValid = false;
                validationErrors.AppendLine("Todo Name is required.");
                txtTodoName.BackColor = Color.LightCoral; // Highlight invalid field
            }
            else
            {
                txtTodoName.BackColor = Color.White; // Reset field color
            }

            if (string.IsNullOrEmpty(txtTodoDesc.Text))
            {
                isValid = false;
                validationErrors.AppendLine("Todo Description is required.");
                txtTodoDesc.BackColor = Color.LightCoral; // Highlight invalid field
            }
            else
            {
                txtTodoDesc.BackColor = Color.White; // Reset field color
            }

            if (dateTodoBy.Value == null || dateTodoBy.Value < DateTime.Now)
            {
                isValid = false;
                validationErrors.AppendLine("A valid 'To Be Completed By' date is required.");
                dateTodoBy.CalendarForeColor = Color.Red; // Highlight invalid field
            }
            else
            {
                dateTodoBy.CalendarForeColor = Color.Black; // Reset field color
            }

            if (!isValid)
            {
                MessageBox.Show($"Invalid todo details:\n{validationErrors.ToString()}", "Validation Errors",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isValid;
        }

        private void AddPriorityDropdown()
        {
            ComboBox priorityDropdown = new ComboBox
            {
                Items = { "High", "Medium", "Low" },
                SelectedIndex = 1 // Default to Medium
            };
            this.Controls.Add(priorityDropdown);
        }

        private void ApplyRoundedCorners(Control control, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            control.Region = new Region(path);
        }

        private void ApplyModernUI()
        {
            // Set a very dark blue color scheme
            this.BackColor = Color.FromArgb(10, 10, 50); // Dark blue background
            this.ForeColor = Color.White; // White text for readability

            // Update button styles
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.FromArgb(30, 30, 90); // Dark blue for buttons
                    button.ForeColor = Color.White;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
            }

            // Update text box styles
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Font = new Font("Segoe UI", 10);
                    textBox.BackColor = Color.FromArgb(20, 20, 70); // Slightly lighter dark blue
                    textBox.ForeColor = Color.White;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }
            }

            // Update labels
            foreach (Control control in this.Controls)
            {
                if (control is Label label)
                {
                    label.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    label.ForeColor = Color.White;
                }
            }
        }

        private void frmTodoDetail_Load(object sender, EventArgs e)
        {
            AddPriorityDropdown();
            ApplyModernUI(); // Apply the modern UI changes
        }
    }
}
