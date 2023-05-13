namespace NET7WinFormsWithSqliteTodos.UI
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
            pnlToDosMaster = new Panel();
            dateTodoBy = new DateTimePicker();
            lblTodoBy = new Label();
            label1 = new Label();
            txtTodoName = new TextBox();
            lblTodoName = new Label();
            gboxStatus = new GroupBox();
            btnCompleted = new Button();
            btnActive = new Button();
            btnAll = new Button();
            txtTodoFilter = new TextBox();
            txtTodoDesc = new TextBox();
            pboxAddNewToDo = new PictureBox();
            gboxTodos.SuspendLayout();
            pnlToDosBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodos).BeginInit();
            pnlToDosMaster.SuspendLayout();
            gboxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxAddNewToDo).BeginInit();
            SuspendLayout();
            // 
            // gboxTodos
            // 
            gboxTodos.Controls.Add(pnlToDosBody);
            gboxTodos.Controls.Add(pnlToDosMaster);
            gboxTodos.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gboxTodos.Location = new Point(12, 14);
            gboxTodos.Name = "gboxTodos";
            gboxTodos.Size = new Size(776, 483);
            gboxTodos.TabIndex = 0;
            gboxTodos.TabStop = false;
            gboxTodos.Text = "ToDos ";
            // 
            // pnlToDosBody
            // 
            pnlToDosBody.Controls.Add(dgvTodos);
            pnlToDosBody.Location = new Point(6, 175);
            pnlToDosBody.Name = "pnlToDosBody";
            pnlToDosBody.Size = new Size(764, 302);
            pnlToDosBody.TabIndex = 1;
            // 
            // dgvTodos
            // 
            dgvTodos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodos.Columns.AddRange(new DataGridViewColumn[] { Id, TodoName, Description, Status, CompleteBy, DateTime });
            dgvTodos.Location = new Point(3, 3);
            dgvTodos.Name = "dgvTodos";
            dgvTodos.RowTemplate.Height = 25;
            dgvTodos.Size = new Size(758, 314);
            dgvTodos.TabIndex = 0;
            dgvTodos.CellDoubleClick += dgvTodos_CellDoubleClick;
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
            // pnlToDosMaster
            // 
            pnlToDosMaster.BackColor = SystemColors.ControlLight;
            pnlToDosMaster.Controls.Add(dateTodoBy);
            pnlToDosMaster.Controls.Add(lblTodoBy);
            pnlToDosMaster.Controls.Add(label1);
            pnlToDosMaster.Controls.Add(txtTodoName);
            pnlToDosMaster.Controls.Add(lblTodoName);
            pnlToDosMaster.Controls.Add(gboxStatus);
            pnlToDosMaster.Controls.Add(txtTodoFilter);
            pnlToDosMaster.Controls.Add(txtTodoDesc);
            pnlToDosMaster.Controls.Add(pboxAddNewToDo);
            pnlToDosMaster.Location = new Point(6, 25);
            pnlToDosMaster.Name = "pnlToDosMaster";
            pnlToDosMaster.Size = new Size(764, 144);
            pnlToDosMaster.TabIndex = 0;
            // 
            // dateTodoBy
            // 
            dateTodoBy.Location = new Point(68, 108);
            dateTodoBy.Name = "dateTodoBy";
            dateTodoBy.Size = new Size(200, 24);
            dateTodoBy.TabIndex = 9;
            dateTodoBy.Value = new DateTime(2023, 6, 21, 0, 0, 0, 0);
            // 
            // lblTodoBy
            // 
            lblTodoBy.AutoSize = true;
            lblTodoBy.Location = new Point(3, 112);
            lblTodoBy.Name = "lblTodoBy";
            lblTodoBy.Size = new Size(59, 17);
            lblTodoBy.TabIndex = 8;
            lblTodoBy.Text = "ToDo By:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 7;
            label1.Text = "ToDo Description:";
            // 
            // txtTodoName
            // 
            txtTodoName.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTodoName.Location = new Point(80, 35);
            txtTodoName.Name = "txtTodoName";
            txtTodoName.Size = new Size(392, 24);
            txtTodoName.TabIndex = 6;
            txtTodoName.Text = "todo name here";
            txtTodoName.TextAlign = HorizontalAlignment.Center;
            txtTodoName.TextChanged += txtTodoName_TextChanged;
            // 
            // lblTodoName
            // 
            lblTodoName.AutoSize = true;
            lblTodoName.Location = new Point(3, 35);
            lblTodoName.Name = "lblTodoName";
            lblTodoName.Size = new Size(75, 17);
            lblTodoName.TabIndex = 5;
            lblTodoName.Text = "ToDo Name:";
            // 
            // gboxStatus
            // 
            gboxStatus.Controls.Add(btnCompleted);
            gboxStatus.Controls.Add(btnActive);
            gboxStatus.Controls.Add(btnAll);
            gboxStatus.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gboxStatus.Location = new Point(420, 55);
            gboxStatus.Name = "gboxStatus";
            gboxStatus.Size = new Size(210, 61);
            gboxStatus.TabIndex = 4;
            gboxStatus.TabStop = false;
            // 
            // btnCompleted
            // 
            btnCompleted.BackColor = SystemColors.ControlDark;
            btnCompleted.Location = new Point(124, 10);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(80, 48);
            btnCompleted.TabIndex = 2;
            btnCompleted.Text = "completed";
            btnCompleted.UseVisualStyleBackColor = false;
            btnCompleted.Click += btnCompleted_Click;
            // 
            // btnActive
            // 
            btnActive.BackColor = SystemColors.ControlDark;
            btnActive.Location = new Point(53, 10);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(65, 48);
            btnActive.TabIndex = 1;
            btnActive.Text = "active";
            btnActive.UseVisualStyleBackColor = false;
            btnActive.Click += btnActive_Click;
            // 
            // btnAll
            // 
            btnAll.BackColor = SystemColors.ControlDark;
            btnAll.Location = new Point(6, 10);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(41, 48);
            btnAll.TabIndex = 0;
            btnAll.Text = "all";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // txtTodoFilter
            // 
            txtTodoFilter.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTodoFilter.Location = new Point(15, 73);
            txtTodoFilter.Name = "txtTodoFilter";
            txtTodoFilter.Size = new Size(399, 24);
            txtTodoFilter.TabIndex = 3;
            txtTodoFilter.Text = "type search filter here";
            txtTodoFilter.TextAlign = HorizontalAlignment.Center;
            txtTodoFilter.TextChanged += txtTodoFilter_TextChanged;
            // 
            // txtTodoDesc
            // 
            txtTodoDesc.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTodoDesc.Location = new Point(116, 3);
            txtTodoDesc.Name = "txtTodoDesc";
            txtTodoDesc.Size = new Size(525, 24);
            txtTodoDesc.TabIndex = 2;
            txtTodoDesc.Text = "todo details here";
            txtTodoDesc.TextAlign = HorizontalAlignment.Center;
            txtTodoDesc.TextChanged += txtTodoDesc_TextChanged;
            // 
            // pboxAddNewToDo
            // 
            pboxAddNewToDo.BackColor = SystemColors.ActiveCaptionText;
            pboxAddNewToDo.Image = (Image)resources.GetObject("pboxAddNewToDo.Image");
            pboxAddNewToDo.InitialImage = (Image)resources.GetObject("pboxAddNewToDo.InitialImage");
            pboxAddNewToDo.Location = new Point(647, 3);
            pboxAddNewToDo.Name = "pboxAddNewToDo";
            pboxAddNewToDo.Size = new Size(114, 119);
            pboxAddNewToDo.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxAddNewToDo.TabIndex = 1;
            pboxAddNewToDo.TabStop = false;
            pboxAddNewToDo.Click += pboxAddNewToDo_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
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
            pnlToDosMaster.ResumeLayout(false);
            pnlToDosMaster.PerformLayout();
            gboxStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxAddNewToDo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxTodos;
        private Panel pnlToDosMaster;
        private TextBox txtTodoDesc;
        private TextBox txtTodoFilter;
        private GroupBox gboxStatus;
        private Button btnCompleted;
        private Button btnActive;
        private Button btnAll;
        private Panel pnlToDosBody;
        private PictureBox pboxAddNewToDo;
        private Label label1;
        private TextBox txtTodoName;
        private Label lblTodoName;
        private DataGridView dgvTodos;
        private DateTimePicker dateTodoBy;
        private Label lblTodoBy;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TodoName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn CompleteBy;
        private DataGridViewTextBoxColumn DateTime;
    }
}