namespace NET7WinFormsWithSqliteTodos.UI
{
    partial class frmTodosDetail
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
            label1 = new Label();
            txtTodoName = new TextBox();
            lblTodoName = new Label();
            groupBox2 = new GroupBox();
            btnCompleted = new Button();
            btnActive = new Button();
            btnAll = new Button();
            txtTodoDesc = new TextBox();
            lblTodoMarkAs = new Label();
            groupBox1.SuspendLayout();
            pnlToDosMaster.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pnlToDosMaster);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // pnlToDosMaster
            // 
            pnlToDosMaster.Controls.Add(lblTodoMarkAs);
            pnlToDosMaster.Controls.Add(label1);
            pnlToDosMaster.Controls.Add(txtTodoName);
            pnlToDosMaster.Controls.Add(lblTodoName);
            pnlToDosMaster.Controls.Add(groupBox2);
            pnlToDosMaster.Controls.Add(txtTodoDesc);
            pnlToDosMaster.Location = new Point(6, 22);
            pnlToDosMaster.Name = "pnlToDosMaster";
            pnlToDosMaster.Size = new Size(651, 205);
            pnlToDosMaster.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
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
            // 
            // lblTodoName
            // 
            lblTodoName.AutoSize = true;
            lblTodoName.Location = new Point(3, 35);
            lblTodoName.Name = "lblTodoName";
            lblTodoName.Size = new Size(72, 15);
            lblTodoName.TabIndex = 5;
            lblTodoName.Text = "ToDo Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCompleted);
            groupBox2.Controls.Add(btnActive);
            groupBox2.Controls.Add(btnAll);
            groupBox2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(80, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(210, 61);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // btnCompleted
            // 
            btnCompleted.Location = new Point(124, 10);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(80, 48);
            btnCompleted.TabIndex = 2;
            btnCompleted.Text = "completed";
            btnCompleted.UseVisualStyleBackColor = true;
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
            // btnAll
            // 
            btnAll.Location = new Point(6, 10);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(41, 48);
            btnAll.TabIndex = 0;
            btnAll.Text = "all";
            btnAll.UseVisualStyleBackColor = true;
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
            // frmTodosDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "frmTodosDetail";
            Text = "Todo - {Name}";
            groupBox1.ResumeLayout(false);
            pnlToDosMaster.ResumeLayout(false);
            pnlToDosMaster.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel pnlToDosMaster;
        private Label lblTodoMarkAs;
        private Label label1;
        private TextBox txtTodoName;
        private Label lblTodoName;
        private GroupBox groupBox2;
        private Button btnCompleted;
        private Button btnActive;
        private Button btnAll;
        private TextBox txtTodoDesc;
    }
}