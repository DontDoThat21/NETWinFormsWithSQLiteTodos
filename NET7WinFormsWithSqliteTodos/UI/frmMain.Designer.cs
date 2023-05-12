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
            pnlToDosMaster = new Panel();
            label1 = new Label();
            txtTodoName = new TextBox();
            lblTodoName = new Label();
            groupBox1 = new GroupBox();
            btnCompleted = new Button();
            btnActive = new Button();
            btnAll = new Button();
            txtTodoFilter = new TextBox();
            txtTodoDesc = new TextBox();
            pboxAddNewToDo = new PictureBox();
            Id = new DataGridViewTextBoxColumn();
            TodoName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            DateTime = new DataGridViewTextBoxColumn();
            gboxTodos.SuspendLayout();
            pnlToDosBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodos).BeginInit();
            pnlToDosMaster.SuspendLayout();
            groupBox1.SuspendLayout();
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
            pnlToDosBody.Location = new Point(6, 157);
            pnlToDosBody.Name = "pnlToDosBody";
            pnlToDosBody.Size = new Size(764, 320);
            pnlToDosBody.TabIndex = 1;
            // 
            // dgvTodos
            // 
            dgvTodos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodos.Columns.AddRange(new DataGridViewColumn[] { Id, TodoName, Description, DateTime });
            dgvTodos.Location = new Point(3, 3);
            dgvTodos.Name = "dgvTodos";
            dgvTodos.RowTemplate.Height = 25;
            dgvTodos.Size = new Size(758, 314);
            dgvTodos.TabIndex = 0;
            // 
            // pnlToDosMaster
            // 
            pnlToDosMaster.Controls.Add(label1);
            pnlToDosMaster.Controls.Add(txtTodoName);
            pnlToDosMaster.Controls.Add(lblTodoName);
            pnlToDosMaster.Controls.Add(groupBox1);
            pnlToDosMaster.Controls.Add(txtTodoFilter);
            pnlToDosMaster.Controls.Add(txtTodoDesc);
            pnlToDosMaster.Controls.Add(pboxAddNewToDo);
            pnlToDosMaster.Location = new Point(6, 25);
            pnlToDosMaster.Name = "pnlToDosMaster";
            pnlToDosMaster.Size = new Size(764, 126);
            pnlToDosMaster.TabIndex = 0;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCompleted);
            groupBox1.Controls.Add(btnActive);
            groupBox1.Controls.Add(btnAll);
            groupBox1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(420, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 61);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // btnCompleted
            // 
            btnCompleted.Location = new Point(124, 10);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(80, 48);
            btnCompleted.TabIndex = 2;
            btnCompleted.Text = "completed";
            btnCompleted.UseVisualStyleBackColor = true;
            btnCompleted.Click += btnCompleted_Click;
            // 
            // btnActive
            // 
            btnActive.Location = new Point(53, 10);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(65, 48);
            btnActive.TabIndex = 1;
            btnActive.Text = "active";
            btnActive.UseVisualStyleBackColor = true;
            btnActive.Click += btnActive_Click;
            // 
            // btnAll
            // 
            btnAll.Location = new Point(6, 10);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(41, 48);
            btnAll.TabIndex = 0;
            btnAll.Text = "all";
            btnAll.UseVisualStyleBackColor = true;
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
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Name
            // 
            TodoName.HeaderText = "Name";
            TodoName.Name = "Name";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // DateTime
            // 
            DateTime.HeaderText = "Date Added";
            DateTime.Name = "DateTime";
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
            Text = "ToDos - User";
            Load += frmMain_Load;
            gboxTodos.ResumeLayout(false);
            pnlToDosBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTodos).EndInit();
            pnlToDosMaster.ResumeLayout(false);
            pnlToDosMaster.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxAddNewToDo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxTodos;
        private Panel pnlToDosMaster;
        private TextBox txtTodoDesc;
        private TextBox txtTodoFilter;
        private GroupBox groupBox1;
        private Button btnCompleted;
        private Button btnActive;
        private Button btnAll;
        private Panel pnlToDosBody;
        private PictureBox pboxAddNewToDo;
        private Label label1;
        private TextBox txtTodoName;
        private Label lblTodoName;
        private DataGridView dgvTodos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TodoName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn DateTime;
    }
}