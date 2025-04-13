namespace NETWinFormsWithSqliteTodos.UI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            gboxTodos = new GroupBox();
            pnlToDosBody = new Panel();
            dgvTodos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            TodoName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            CompleteBy = new DataGridViewTextBoxColumn();
            DateTime = new DataGridViewTextBoxColumn();
            contextMenuDGVTodos = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            pnlToDosMaster = new Panel();
            pnlStatus = new Panel();
            lblSelectStatus = new Label();
            btnNew = new Button();
            btnCompleted = new Button();
            btnActive = new Button();
            pboxFilterReset = new PictureBox();
            dateTodoBy = new DateTimePicker();
            lblTodoBy = new Label();
            lblTodoName = new Label();
            label1 = new Label();
            txtTodoName = new TextBox();
            txtTodoFilter = new TextBox();
            txtTodoDesc = new TextBox();
            pboxAddNewToDo = new PictureBox();
            gboxTodos.SuspendLayout();
            pnlToDosBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodos).BeginInit();
            contextMenuDGVTodos.SuspendLayout();
            pnlToDosMaster.SuspendLayout();
            pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxFilterReset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxAddNewToDo).BeginInit();
            SuspendLayout();
            // 
            // gboxTodos
            // 
            gboxTodos.BackColor = Color.LightSlateGray;
            gboxTodos.Controls.Add(pnlToDosBody);
            gboxTodos.Controls.Add(pnlToDosMaster);
            gboxTodos.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gboxTodos.ForeColor = Color.Cyan;
            gboxTodos.Location = new Point(12, 14);
            gboxTodos.Name = "gboxTodos";
            gboxTodos.Size = new Size(776, 483);
            gboxTodos.TabIndex = 0;
            gboxTodos.TabStop = false;
            gboxTodos.Text = "ToDos ";
            gboxTodos.Dock = DockStyle.Fill;
            // 
            // pnlToDosBody
            // 
            pnlToDosBody.Controls.Add(dgvTodos);
            pnlToDosBody.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            pnlToDosBody.ForeColor = Color.DarkCyan;
            pnlToDosBody.Location = new Point(6, 175);
            pnlToDosBody.Name = "pnlToDosBody";
            pnlToDosBody.Size = new Size(764, 302);
            pnlToDosBody.TabIndex = 1;
            pnlToDosBody.Dock = DockStyle.Fill;
            // 
            // dgvTodos
            // 
            dgvTodos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodos.BackgroundColor = Color.LightSlateGray;
            dgvTodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodos.Columns.AddRange(new DataGridViewColumn[] { Id, TodoName, Description, Status, CompleteBy, DateTime });
            dgvTodos.ContextMenuStrip = contextMenuDGVTodos;
            dgvTodos.Location = new Point(3, 3);
            dgvTodos.Name = "dgvTodos";
            dgvTodos.RowTemplate.Height = 25;
            dgvTodos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTodos.Size = new Size(758, 314);
            dgvTodos.TabIndex = 0;
            dgvTodos.CellDoubleClick += dgvTodos_CellDoubleClick;
            dgvTodos.Dock = DockStyle.Fill;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // TodoName
            // 
            TodoName.HeaderText = "Name";
            TodoName.Name = "TodoName";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // CompleteBy
            // 
            CompleteBy.HeaderText = "Complete By";
            CompleteBy.Name = "CompleteBy";
            // 
            // DateTime
            // 
            DateTime.HeaderText = "Date Added";
            DateTime.Name = "DateTime";
            // 
            // contextMenuDGVTodos
            // 
            contextMenuDGVTodos.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuDGVTodos.Name = "contextMenuStrip1";
            contextMenuDGVTodos.Size = new Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // pnlToDosMaster
            // 
            pnlToDosMaster.BackColor = Color.LightSlateGray;
            pnlToDosMaster.Controls.Add(pnlStatus);
            pnlToDosMaster.Controls.Add(pboxFilterReset);
            pnlToDosMaster.Controls.Add(dateTodoBy);
            pnlToDosMaster.Controls.Add(lblTodoBy);
            pnlToDosMaster.Controls.Add(lblTodoName);
            pnlToDosMaster.Controls.Add(label1);
            pnlToDosMaster.Controls.Add(txtTodoName);
            pnlToDosMaster.Controls.Add(txtTodoFilter);
            pnlToDosMaster.Controls.Add(txtTodoDesc);
            pnlToDosMaster.Controls.Add(pboxAddNewToDo);
            pnlToDosMaster.Location = new Point(6, 25);
            pnlToDosMaster.Name = "pnlToDosMaster";
            pnlToDosMaster.Size = new Size(764, 144);
            pnlToDosMaster.TabIndex = 0;
            pnlToDosMaster.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // pnlStatus
            // 
            pnlStatus.BackColor = Color.FromArgb(150, 150, 150);
            pnlStatus.Controls.Add(lblSelectStatus);
            pnlStatus.Controls.Add(btnNew);
            pnlStatus.Controls.Add(btnCompleted);
            pnlStatus.Controls.Add(btnActive);
            pnlStatus.Location = new Point(432, 62);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(208, 63);
            pnlStatus.TabIndex = 11;
            // 
            // lblSelectStatus
            // 
            lblSelectStatus.AutoSize = true;
            lblSelectStatus.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectStatus.ForeColor = Color.GhostWhite;
            lblSelectStatus.Location = new Point(68, 4);
            lblSelectStatus.Name = "lblSelectStatus";
            lblSelectStatus.Size = new Size(72, 13);
            lblSelectStatus.TabIndex = 3;
            lblSelectStatus.Text = "Select Status";
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.ControlDarkDark;
            btnNew.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.ForeColor = Color.GhostWhite;
            btnNew.Location = new Point(5, 20);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(41, 39);
            btnNew.TabIndex = 0;
            btnNew.Text = "new";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnAll_Click;
            // 
            // btnCompleted
            // 
            btnCompleted.BackColor = SystemColors.ControlDarkDark;
            btnCompleted.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompleted.ForeColor = Color.GhostWhite;
            btnCompleted.Location = new Point(123, 20);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(80, 39);
            btnCompleted.TabIndex = 2;
            btnCompleted.Text = "completed";
            btnCompleted.UseVisualStyleBackColor = false;
            btnCompleted.Click += btnCompleted_Click;
            // 
            // btnActive
            // 
            btnActive.BackColor = SystemColors.ControlDarkDark;
            btnActive.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnActive.ForeColor = Color.GhostWhite;
            btnActive.Location = new Point(52, 20);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(65, 39);
            btnActive.TabIndex = 1;
            btnActive.Text = "work in progress";
            btnActive.UseVisualStyleBackColor = false;
            btnActive.Click += btnActive_Click;
            // 
            // pboxFilterReset
            // 
            pboxFilterReset.BackColor = SystemColors.ActiveCaptionText;
            pboxFilterReset.Image = (Image)resources.GetObject("pboxFilterReset.Image");
            pboxFilterReset.InitialImage = (Image)resources.GetObject("pboxFilterReset.InitialImage");
            pboxFilterReset.Location = new Point(386, 69);
            pboxFilterReset.Name = "pboxFilterReset";
            pboxFilterReset.Size = new Size(28, 24);
            pboxFilterReset.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxFilterReset.TabIndex = 10;
            pboxFilterReset.TabStop = false;
            pboxFilterReset.Click += pboxFilterReset_Click;
            // 
            // dateTodoBy
            // 
            dateTodoBy.CalendarMonthBackground = SystemColors.GrayText;
            dateTodoBy.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTodoBy.Location = new Point(68, 106);
            dateTodoBy.Name = "dateTodoBy";
            dateTodoBy.Size = new Size(200, 22);
            dateTodoBy.TabIndex = 9;
            dateTodoBy.Value = new DateTime(2028, 6, 21, 0, 0, 0, 0);
            // 
            // lblTodoBy
            // 
            lblTodoBy.AutoSize = true;
            lblTodoBy.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTodoBy.ForeColor = Color.GhostWhite;
            lblTodoBy.Location = new Point(3, 110);
            lblTodoBy.Name = "lblTodoBy";
            lblTodoBy.Size = new Size(51, 13);
            lblTodoBy.TabIndex = 8;
            lblTodoBy.Text = "ToDo By:";
            // 
            // lblTodoName
            // 
            lblTodoName.AutoSize = true;
            lblTodoName.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTodoName.ForeColor = Color.GhostWhite;
            lblTodoName.Location = new Point(65, 6);
            lblTodoName.Name = "lblTodoName";
            lblTodoName.Size = new Size(69, 13);
            lblTodoName.TabIndex = 5;
            lblTodoName.Text = "ToDo Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(3, 33);
            label1.Name = "label1";
            label1.Size = new Size(99, 13);
            label1.TabIndex = 7;
            label1.Text = "ToDo Description:";
            // 
            // txtTodoName
            // 
            txtTodoName.BackColor = SystemColors.ControlDarkDark;
            txtTodoName.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTodoName.ForeColor = Color.GhostWhite;
            txtTodoName.Location = new Point(146, 3);
            txtTodoName.Name = "txtTodoName";
            txtTodoName.Size = new Size(392, 22);
            txtTodoName.TabIndex = 6;
            txtTodoName.Text = "todo name here";
            txtTodoName.TextAlign = HorizontalAlignment.Center;
            txtTodoName.TextChanged += txtTodoName_TextChanged;
            // 
            // txtTodoFilter
            // 
            txtTodoFilter.BackColor = SystemColors.ControlDarkDark;
            txtTodoFilter.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTodoFilter.ForeColor = Color.GhostWhite;
            txtTodoFilter.Location = new Point(15, 69);
            txtTodoFilter.Name = "txtTodoFilter";
            txtTodoFilter.Size = new Size(399, 22);
            txtTodoFilter.TabIndex = 3;
            txtTodoFilter.Text = "type search filter here";
            txtTodoFilter.TextAlign = HorizontalAlignment.Center;
            txtTodoFilter.TextChanged += txtTodoFilter_TextChanged;
            // 
            // txtTodoDesc
            // 
            txtTodoDesc.BackColor = SystemColors.ControlDarkDark;
            txtTodoDesc.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTodoDesc.ForeColor = Color.GhostWhite;
            txtTodoDesc.Location = new Point(116, 31);
            txtTodoDesc.Name = "txtTodoDesc";
            txtTodoDesc.Size = new Size(525, 22);
            txtTodoDesc.TabIndex = 2;
            txtTodoDesc.Text = "todo details here";
            txtTodoDesc.TextAlign = HorizontalAlignment.Center;
            txtTodoDesc.TextChanged += txtTodoDesc_TextChanged;
            // 
            // pboxAddNewToDo
            // 
            pboxAddNewToDo.BackColor = SystemColors.ActiveCaptionText;
            pboxAddNewToDo.Image = Properties.Resources.btnAddTodoInvalid;
            pboxAddNewToDo.InitialImage = (Image)resources.GetObject("pboxAddNewToDo.InitialImage");
            pboxAddNewToDo.Location = new Point(647, 3);
            pboxAddNewToDo.Name = "pboxAddNewToDo";
            pboxAddNewToDo.Size = new Size(114, 119);
            pboxAddNewToDo.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxAddNewToDo.TabIndex = 1;
            pboxAddNewToDo.TabStop = false;
            pboxAddNewToDo.Click += pboxAddNewToDo_Click;
            pboxAddNewToDo.MouseHover += pboxAddNewToDo_MouseHover;
            pboxAddNewToDo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 510);
            Controls.Add(gboxTodos);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToDos - {User}";
            Load += frmMain_Load;
            gboxTodos.ResumeLayout(false);
            pnlToDosBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTodos).EndInit();
            contextMenuDGVTodos.ResumeLayout(false);
            pnlToDosMaster.ResumeLayout(false);
            pnlToDosMaster.PerformLayout();
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxFilterReset).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxAddNewToDo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxTodos;
        private Panel pnlToDosMaster;
        private TextBox txtTodoDesc;
        private TextBox txtTodoFilter;
        private Button btnCompleted;
        private Button btnActive;
        private Button btnNew;
        private Panel pnlToDosBody;
        private PictureBox pboxAddNewToDo;
        private Label label1;
        private TextBox txtTodoName;
        private Label lblTodoName;
        private DateTimePicker dateTodoBy;
        private Label lblTodoBy;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TodoName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn CompleteBy;
        private DataGridViewTextBoxColumn DateTime;
        public DataGridView dgvTodos;
        private ContextMenuStrip contextMenuDGVTodos;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private PictureBox pboxFilterReset;
        private Panel pnlStatus;
        private Label lblSelectStatus;
    }
}