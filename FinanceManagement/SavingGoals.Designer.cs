namespace FinanceManagement
{
    partial class SavingGoals
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingGoals));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddGoal = new System.Windows.Forms.Button();
            this.btnDeleteGoal = new System.Windows.Forms.Button();
            this.btnEditGoal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGoalName = new System.Windows.Forms.TextBox();
            this.txtAmountSaved = new System.Windows.Forms.TextBox();
            this.txtTotalGoalAmount = new System.Windows.Forms.TextBox();
            this.lstSavingGoals = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnGoals2 = new System.Windows.Forms.PictureBox();
            this.iconExpense = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoals2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(290, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Goal Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.label2.Location = new System.Drawing.Point(290, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Total Goal Amount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.label3.Location = new System.Drawing.Point(290, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Amount Saved :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAddGoal
            // 
            this.btnAddGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(224)))), ((int)(((byte)(175)))));
            this.btnAddGoal.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(94)))), ((int)(((byte)(161)))));
            this.btnAddGoal.Location = new System.Drawing.Point(306, 483);
            this.btnAddGoal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddGoal.Name = "btnAddGoal";
            this.btnAddGoal.Size = new System.Drawing.Size(272, 52);
            this.btnAddGoal.TabIndex = 7;
            this.btnAddGoal.Text = "Add a new goal";
            this.btnAddGoal.UseVisualStyleBackColor = false;
            this.btnAddGoal.Click += new System.EventHandler(this.btnAddGoal_Click);
            // 
            // btnDeleteGoal
            // 
            this.btnDeleteGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(224)))), ((int)(((byte)(175)))));
            this.btnDeleteGoal.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(94)))), ((int)(((byte)(161)))));
            this.btnDeleteGoal.Location = new System.Drawing.Point(1762, 587);
            this.btnDeleteGoal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDeleteGoal.Name = "btnDeleteGoal";
            this.btnDeleteGoal.Size = new System.Drawing.Size(487, 80);
            this.btnDeleteGoal.TabIndex = 8;
            this.btnDeleteGoal.Text = "Delete";
            this.btnDeleteGoal.UseVisualStyleBackColor = false;
            this.btnDeleteGoal.Click += new System.EventHandler(this.btnDeleteGoal_Click);
            // 
            // btnEditGoal
            // 
            this.btnEditGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(224)))), ((int)(((byte)(175)))));
            this.btnEditGoal.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(94)))), ((int)(((byte)(161)))));
            this.btnEditGoal.Location = new System.Drawing.Point(748, 479);
            this.btnEditGoal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEditGoal.Name = "btnEditGoal";
            this.btnEditGoal.Size = new System.Drawing.Size(268, 56);
            this.btnEditGoal.TabIndex = 9;
            this.btnEditGoal.Text = "Edit";
            this.btnEditGoal.UseVisualStyleBackColor = false;
            this.btnEditGoal.Click += new System.EventHandler(this.btnEditGoal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.label6.Location = new System.Drawing.Point(622, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(456, 39);
            this.label6.TabIndex = 20;
            this.label6.Text = "Finance Management System 2.0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2064, 102);
            this.panel1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.label5.Location = new System.Drawing.Point(338, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(456, 39);
            this.label5.TabIndex = 42;
            this.label5.Text = "Finance Management System 2.0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.btnGoals2);
            this.panel2.Controls.Add(this.iconExpense);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 1466);
            this.panel2.TabIndex = 22;
            // 
            // txtGoalName
            // 
            this.txtGoalName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.txtGoalName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtGoalName.Location = new System.Drawing.Point(655, 210);
            this.txtGoalName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtGoalName.Name = "txtGoalName";
            this.txtGoalName.Size = new System.Drawing.Size(423, 35);
            this.txtGoalName.TabIndex = 25;
            this.txtGoalName.TextChanged += new System.EventHandler(this.txtExpenseName_TextChanged);
            // 
            // txtAmountSaved
            // 
            this.txtAmountSaved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.txtAmountSaved.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAmountSaved.Location = new System.Drawing.Point(655, 283);
            this.txtAmountSaved.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAmountSaved.Name = "txtAmountSaved";
            this.txtAmountSaved.Size = new System.Drawing.Size(423, 35);
            this.txtAmountSaved.TabIndex = 26;
            // 
            // txtTotalGoalAmount
            // 
            this.txtTotalGoalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.txtTotalGoalAmount.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTotalGoalAmount.Location = new System.Drawing.Point(655, 376);
            this.txtTotalGoalAmount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTotalGoalAmount.Name = "txtTotalGoalAmount";
            this.txtTotalGoalAmount.Size = new System.Drawing.Size(423, 35);
            this.txtTotalGoalAmount.TabIndex = 27;
            // 
            // lstSavingGoals
            // 
            this.lstSavingGoals.FormattingEnabled = true;
            this.lstSavingGoals.ItemHeight = 29;
            this.lstSavingGoals.Location = new System.Drawing.Point(286, 587);
            this.lstSavingGoals.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstSavingGoals.Name = "lstSavingGoals";
            this.lstSavingGoals.Size = new System.Drawing.Size(766, 294);
            this.lstSavingGoals.TabIndex = 28;
            this.lstSavingGoals.SelectedIndexChanged += new System.EventHandler(this.lstGoals_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(33, 672);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 106);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 5;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-293, 721);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(154, 133);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            // 
            // btnGoals2
            // 
            this.btnGoals2.Image = ((System.Drawing.Image)(resources.GetObject("btnGoals2.Image")));
            this.btnGoals2.Location = new System.Drawing.Point(33, 518);
            this.btnGoals2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGoals2.Name = "btnGoals2";
            this.btnGoals2.Size = new System.Drawing.Size(79, 106);
            this.btnGoals2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGoals2.TabIndex = 3;
            this.btnGoals2.TabStop = false;
            // 
            // iconExpense
            // 
            this.iconExpense.Image = ((System.Drawing.Image)(resources.GetObject("iconExpense.Image")));
            this.iconExpense.Location = new System.Drawing.Point(33, 316);
            this.iconExpense.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.iconExpense.Name = "iconExpense";
            this.iconExpense.Size = new System.Drawing.Size(79, 106);
            this.iconExpense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconExpense.TabIndex = 2;
            this.iconExpense.TabStop = false;
            this.iconExpense.Click += new System.EventHandler(this.iconExpense_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 159);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(244, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // SavingGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(2401, 1466);
            this.Controls.Add(this.lstSavingGoals);
            this.Controls.Add(this.txtTotalGoalAmount);
            this.Controls.Add(this.txtAmountSaved);
            this.Controls.Add(this.txtGoalName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEditGoal);
            this.Controls.Add(this.btnDeleteGoal);
            this.Controls.Add(this.btnAddGoal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SavingGoals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.SavingGoals_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoals2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAddGoal;
        private System.Windows.Forms.Button btnDeleteGoal;
        private System.Windows.Forms.Button btnEditGoal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconExpense;
        private System.Windows.Forms.PictureBox btnGoals2;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGoalName;
        private System.Windows.Forms.TextBox txtAmountSaved;
        private System.Windows.Forms.TextBox txtTotalGoalAmount;
        private System.Windows.Forms.ListBox lstSavingGoals;
    }
}