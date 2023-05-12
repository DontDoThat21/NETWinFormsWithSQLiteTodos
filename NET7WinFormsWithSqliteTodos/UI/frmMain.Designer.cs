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
            gboxTodos = new GroupBox();
            pnlToDosMaster = new Panel();
            pboxAddNewToDo = new PictureBox();
            tboxAddTodo = new TextBox();
            tboxFilter = new TextBox();
            groupBox1 = new GroupBox();
            btnAll = new Button();
            btnActive = new Button();
            btnComplete = new Button();
            pnlToDosBody = new Panel();
            gboxTodos.SuspendLayout();
            pnlToDosMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxAddNewToDo).BeginInit();
            groupBox1.SuspendLayout();
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
            // pnlToDosMaster
            // 
            pnlToDosMaster.Controls.Add(groupBox1);
            pnlToDosMaster.Controls.Add(tboxFilter);
            pnlToDosMaster.Controls.Add(tboxAddTodo);
            pnlToDosMaster.Controls.Add(pboxAddNewToDo);
            pnlToDosMaster.Location = new Point(6, 25);
            pnlToDosMaster.Name = "pnlToDosMaster";
            pnlToDosMaster.Size = new Size(764, 126);
            pnlToDosMaster.TabIndex = 0;
            // 
            // pboxAddNewToDo
            // 
            pboxAddNewToDo.Location = new Point(647, 3);
            pboxAddNewToDo.Name = "pboxAddNewToDo";
            pboxAddNewToDo.Size = new Size(114, 119);
            pboxAddNewToDo.TabIndex = 1;
            pboxAddNewToDo.TabStop = false;
            // 
            // tboxAddTodo
            // 
            tboxAddTodo.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tboxAddTodo.Location = new Point(3, 3);
            tboxAddTodo.Name = "tboxAddTodo";
            tboxAddTodo.Size = new Size(638, 24);
            tboxAddTodo.TabIndex = 2;
            tboxAddTodo.Text = "Add ToDo here";
            // 
            // tboxFilter
            // 
            tboxFilter.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tboxFilter.Location = new Point(22, 63);
            tboxFilter.Name = "tboxFilter";
            tboxFilter.Size = new Size(392, 24);
            tboxFilter.TabIndex = 3;
            tboxFilter.Text = "type search filter here";
            tboxFilter.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnComplete);
            groupBox1.Controls.Add(btnActive);
            groupBox1.Controls.Add(btnAll);
            groupBox1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(420, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 61);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
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
            // btnActive
            // 
            btnActive.Location = new Point(53, 10);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(65, 48);
            btnActive.TabIndex = 1;
            btnActive.Text = "active";
            btnActive.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(124, 10);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(80, 48);
            btnComplete.TabIndex = 2;
            btnComplete.Text = "completed";
            btnComplete.UseVisualStyleBackColor = true;
            // 
            // pnlToDosBody
            // 
            pnlToDosBody.Location = new Point(6, 157);
            pnlToDosBody.Name = "pnlToDosBody";
            pnlToDosBody.Size = new Size(764, 320);
            pnlToDosBody.TabIndex = 1;
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
            pnlToDosMaster.ResumeLayout(false);
            pnlToDosMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxAddNewToDo).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxTodos;
        private Panel pnlToDosMaster;
        private PictureBox pboxAddNewToDo;
        private TextBox tboxAddTodo;
        private TextBox tboxFilter;
        private GroupBox groupBox1;
        private Button btnComplete;
        private Button btnActive;
        private Button btnAll;
        private Panel pnlToDosBody;
    }
}