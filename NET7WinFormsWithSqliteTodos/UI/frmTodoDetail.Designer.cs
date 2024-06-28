namespace NETWinFormsWithSqliteTodos.UI
{
    partial class frmTodoDetail
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
            groupBox1 = new GroupBox();
            pnlToDosMaster = new Panel();
            btnUpdateTodo = new Button();
            dateTodoBy = new DateTimePicker();
            lblTodoBy = new Label();
            lblId = new Label();
            lblTodoMarkAs = new Label();
            lblDesc = new Label();
            txtTodoName = new TextBox();
            lblTodoName = new Label();
            gboxStatus = new GroupBox();
            btnCompleted = new Button();
            btnActive = new Button();
            btnAll = new Button();
            txtTodoDesc = new TextBox();
            groupBox1.SuspendLayout();
            pnlToDosMaster.SuspendLayout();
            gboxStatus.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pnlToDosMaster);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(663, 198);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Todo - {Created}";
            // 
            // pnlToDosMaster
            // 
            pnlToDosMaster.BackColor = SystemColors.ControlLight;
            pnlToDosMaster.Controls.Add(btnUpdateTodo);
            pnlToDosMaster.Controls.Add(dateTodoBy);
            pnlToDosMaster.Controls.Add(lblTodoBy);
            pnlToDosMaster.Controls.Add(lblId);
            pnlToDosMaster.Controls.Add(lblTodoMarkAs);
            pnlToDosMaster.Controls.Add(lblDesc);
            pnlToDosMaster.Controls.Add(txtTodoName);
            pnlToDosMaster.Controls.Add(lblTodoName);
            pnlToDosMaster.Controls.Add(gboxStatus);
            pnlToDosMaster.Controls.Add(txtTodoDesc);
            pnlToDosMaster.Location = new Point(6, 20);
            pnlToDosMaster.Name = "pnlToDosMaster";
            pnlToDosMaster.Size = new Size(651, 172);
            pnlToDosMaster.TabIndex = 1;
            // 
            // btnUpdateTodo
            // 
            btnUpdateTodo.BackColor = SystemColors.ControlDark;
            btnUpdateTodo.Location = new Point(299, 129);
            btnUpdateTodo.Name = "btnUpdateTodo";
            btnUpdateTodo.Size = new Size(336, 37);
            btnUpdateTodo.TabIndex = 12;
            btnUpdateTodo.Text = "UPDATE";
            btnUpdateTodo.UseVisualStyleBackColor = false;
            btnUpdateTodo.Click += btnUpdateTodo_Click;
            // 
            // dateTodoBy
            // 
            dateTodoBy.Location = new Point(80, 139);
            dateTodoBy.Name = "dateTodoBy";
            dateTodoBy.Size = new Size(200, 23);
            dateTodoBy.TabIndex = 11;
            dateTodoBy.Value = new DateTime(2023, 6, 21, 0, 0, 0, 0);
            // 
            // lblTodoBy
            // 
            lblTodoBy.AutoSize = true;
            lblTodoBy.Location = new Point(6, 142);
            lblTodoBy.Name = "lblTodoBy";
            lblTodoBy.Size = new Size(53, 15);
            lblTodoBy.TabIndex = 10;
            lblTodoBy.Text = "ToDo By:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(603, 47);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 15);
            lblId.TabIndex = 9;
            // 
            // lblTodoMarkAs
            // 
            lblTodoMarkAs.AutoSize = true;
            lblTodoMarkAs.Location = new Point(3, 92);
            lblTodoMarkAs.Name = "lblTodoMarkAs";
            lblTodoMarkAs.Size = new Size(72, 15);
            lblTodoMarkAs.TabIndex = 8;
            lblTodoMarkAs.Text = "ToDo Name:";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(21, 42);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(100, 15);
            lblDesc.TabIndex = 7;
            lblDesc.Text = "ToDo Description:";
            // 
            // txtTodoName
            // 
            txtTodoName.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTodoName.Location = new Point(145, 8);
            txtTodoName.Name = "txtTodoName";
            txtTodoName.Size = new Size(364, 24);
            txtTodoName.TabIndex = 6;
            txtTodoName.Text = "todo name here";
            txtTodoName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTodoName
            // 
            lblTodoName.AutoSize = true;
            lblTodoName.Location = new Point(67, 12);
            lblTodoName.Name = "lblTodoName";
            lblTodoName.Size = new Size(72, 15);
            lblTodoName.TabIndex = 5;
            lblTodoName.Text = "ToDo Name:";
            // 
            // gboxStatus
            // 
            gboxStatus.Controls.Add(btnCompleted);
            gboxStatus.Controls.Add(btnActive);
            gboxStatus.Controls.Add(btnAll);
            gboxStatus.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gboxStatus.Location = new Point(80, 65);
            gboxStatus.Name = "gboxStatus";
            gboxStatus.Size = new Size(561, 61);
            gboxStatus.TabIndex = 4;
            gboxStatus.TabStop = false;
            // 
            // btnCompleted
            // 
            btnCompleted.BackColor = SystemColors.ControlDark;
            btnCompleted.Location = new Point(272, 10);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(283, 48);
            btnCompleted.TabIndex = 2;
            btnCompleted.Text = "completed";
            btnCompleted.UseVisualStyleBackColor = false;
            btnCompleted.Click += btnCompleted_Click;
            // 
            // btnActive
            // 
            btnActive.BackColor = SystemColors.ControlDark;
            btnActive.Location = new Point(115, 10);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(151, 48);
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
            btnAll.Size = new Size(103, 48);
            btnAll.TabIndex = 0;
            btnAll.Text = "all";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // txtTodoDesc
            // 
            txtTodoDesc.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTodoDesc.Location = new Point(127, 38);
            txtTodoDesc.Name = "txtTodoDesc";
            txtTodoDesc.Size = new Size(514, 24);
            txtTodoDesc.TabIndex = 2;
            txtTodoDesc.Text = "todo details here";
            txtTodoDesc.TextAlign = HorizontalAlignment.Center;
            // 
            // frmTodoDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 223);
            Controls.Add(groupBox1);
            Name = "frmTodoDetail";
            Text = "Todo - {Name}";
            groupBox1.ResumeLayout(false);
            pnlToDosMaster.ResumeLayout(false);
            pnlToDosMaster.PerformLayout();
            gboxStatus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlToDosMaster;
        private Label lblTodoMarkAs;
        private Label lblDesc;
        private Label lblTodoName;
        private GroupBox gboxStatus;
        public Label lblId;
        public TextBox txtTodoName;
        public TextBox txtTodoDesc;
        public Button btnCompleted;
        public Button btnActive;
        public Button btnAll;
        public GroupBox groupBox1;
        private Label lblTodoBy;
        private Button btnUpdateTodo;
        public DateTimePicker dateTodoBy;
    }
}