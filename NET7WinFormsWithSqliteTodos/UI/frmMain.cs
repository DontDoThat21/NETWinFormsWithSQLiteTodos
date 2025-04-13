using Microsoft.VisualBasic.ApplicationServices;
using NETWinFormsWithSqliteTodos.Data;
using NETWinFormsWithSqliteTodos.Models;
using NETWinFormsWithSqliteTodos.Properties;
using System.Data;
using System.Text;

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
                ApplyDarkMode(false); // Default to light mode
                EnableDragAndDrop();
                AddSwipeGestures();
                ApplyModernUI(); // Apply the modern UI changes
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

        public async void LoadTodos()
        {
            try
            {
                List<ToDo> todos = await _todosManager.GetAllAsync(); // Use GetAllAsync

                // Set the DataSource of the DataGridView instead of adding rows programmatically
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = todos;
                dgvTodos.DataSource = bindingSource;

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
        /// <param="sender"></param>
        /// <param="e"></param>
        private async void pboxAddNewToDo_Click(object sender, EventArgs e)
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

                ToDo todo = new ToDo
                {
                    TodoName = txtTodoName.Text,
                    Description = txtTodoDesc.Text,
                    DateToBeCompleted = dateTodoBy.Value,
                    Status = GetCurrentTodoStatus()
                };

                if (await _todosManager.AddAsync(todo)) // Use AddAsync
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
        /// <param="sender"></param>
        /// <param="e"></param>
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
                    btnNew.BackColor = Color.FromName("Control");
                    btnCompleted.BackColor = Color.FromName("Control");
                    break;
                case "completed":
                    btnNew.BackColor = Color.FromName("Control");
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
            foreach (var obj in pnlStatus.Controls)
            {
                if (obj is Button btn) // Ensure only Buttons are processed
                {
                    if (btn.BackColor == Color.FromName("ControlDark"))
                    {
                        status = btn.Text;
                        break;
                    }
                }
            }
            return status;
        }

        /// <summary>
        /// This is the active todos filter option.
        /// </summary>
        /// <param="sender"></param>
        /// <param="e"></param>
        private void btnActive_Click(object sender, EventArgs e)
        {
            ChangeStatusColor(sender);
            ValidateNewButtonSubmission();
        }

        /// <summary>
        /// This is the completed todos filter option.
        /// </summary>
        /// <param="sender"></param>
        /// <param="e"></param>
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            ChangeStatusColor(sender);
            ValidateNewButtonSubmission();
        }

        /// <summary>
        /// This is the filter/search box text.
        /// </summary>
        /// <param="sender"></param>
        /// <param="e"></param>
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

            // Fix incorrect usage of 'Now' in the DataGridViewTextBoxColumn context
            if (dateTodoBy.Value == null || dateTodoBy.Value < System.DateTime.Now) // Use DateTime.Now instead of 'Now'
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

        /// <summary>
        /// This is the main todo text.
        /// </summary>
        /// <param="sender"></param>
        /// <param="e"></param>
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

                // Check if the required cell values are null
                if (dgvR.Cells[0].Value == null || dgvR.Cells[1].Value == null || dgvR.Cells[2].Value == null)
                {
                    MessageBox.Show("One or more required fields are empty. Please ensure all fields are populated.", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmTodoDetail frmTodos = new frmTodoDetail(this);

                frmTodos.lblId.Text = dgvR.Cells[0].Value.ToString();
                frmTodos.txtTodoName.Text = dgvR.Cells[1].Value.ToString();
                frmTodos.txtTodoDesc.Text = dgvR.Cells[2].Value.ToString();
                frmTodos.SetStatusButton(GetCurrentTodoStatus());
                frmTodos.dateTodoBy.Value = dateTodoBy.Value;

                frmTodos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
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
                    btn = btnNew;
                    break;
                case "active":
                    btnNew.BackColor = Color.FromName("Control");
                    btnCompleted.BackColor = Color.FromName("Control");
                    btn = btnActive;
                    break;
                case "completed":
                    btnNew.BackColor = Color.FromName("Control");
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

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvTodos.Rows[dgvTodos.CurrentCell.RowIndex];
                if (MessageBox.Show("Do you want to delete?", "Question...",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dr.Cells[0].Value;
                    bool isDelete = await _todosManager.DeleteAsync(id); // Await the async method
                    if (isDelete)
                    {
                        MessageBox.Show("Todo has been removed.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ApplyDarkMode(bool enable)
        {
            this.BackColor = enable ? Color.Black : Color.White;
            this.ForeColor = enable ? Color.White : Color.Black;
            // Update other UI elements for dark mode
        }

        private void EnableDragAndDrop()
        {
            dgvTodos.AllowDrop = true;
            dgvTodos.DragDrop += (s, e) =>
            {
                // Handle drag-and-drop logic
            };
        }

        private void AddSwipeGestures()
        {
            // Implement swipe gestures for touch devices
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

            // Update DataGridView styles
            dgvTodos.BackgroundColor = Color.FromArgb(20, 20, 70); // Slightly lighter dark blue
            dgvTodos.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50); // Dark gray for cells
            dgvTodos.DefaultCellStyle.ForeColor = Color.White; // White text for readability
            dgvTodos.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTodos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 90);
            dgvTodos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTodos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

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
    }
}
