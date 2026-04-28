namespace student_management.forms.Admin
{
    partial class AdminDashboardForm
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
            panel1 = new Panel();
            button1 = new Button();
            btnHome = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            label10 = new Label();
            label11 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(2, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 414);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(41, 361);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(66, 30);
            button1.TabIndex = 2;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            btnHome.IconColor = Color.White;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 35;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(15, 12);
            btnHome.Margin = new Padding(3, 2, 3, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(118, 58);
            btnHome.TabIndex = 1;
            btnHome.Text = "dashboard";
            btnHome.TextAlign = ContentAlignment.MiddleRight;
            btnHome.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(225, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(122, 85);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(368, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(122, 85);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(517, 58);
            panel4.Name = "panel4";
            panel4.Size = new Size(122, 85);
            panel4.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(684, 58);
            panel5.Name = "panel5";
            panel5.Size = new Size(171, 85);
            panel5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 10);
            label1.Name = "label1";
            label1.Size = new Size(84, 13);
            label1.TabIndex = 0;
            label1.Text = "Total  Students";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(225, 23);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 5;
            label5.Text = "Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 10);
            label2.Name = "label2";
            label2.Size = new Size(86, 13);
            label2.TabIndex = 1;
            label2.Text = "Total  Payments";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 10);
            label3.Name = "label3";
            label3.Size = new Size(72, 13);
            label3.TabIndex = 2;
            label3.Text = "Total Tuition";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 10);
            label4.Name = "label4";
            label4.Size = new Size(82, 13);
            label4.TabIndex = 2;
            label4.Text = "Total  Revenue";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 44);
            label6.Name = "label6";
            label6.Size = new Size(34, 21);
            label6.TabIndex = 1;
            label6.Text = "120";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(52, 44);
            label7.Name = "label7";
            label7.Size = new Size(28, 21);
            label7.TabIndex = 1;
            label7.Text = "45";
            label7.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(58, 44);
            label8.Name = "label8";
            label8.Size = new Size(28, 21);
            label8.TabIndex = 1;
            label8.Text = "89";
            label8.Click += label6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(64, 44);
            label9.Name = "label9";
            label9.Size = new Size(104, 21);
            label9.TabIndex = 1;
            label9.Text = "₱ 450,000.00";
            label9.Click += label6_Click;
            // 
            // panel6
            // 
            panel6.Location = new Point(225, 198);
            panel6.Name = "panel6";
            panel6.Size = new Size(324, 184);
            panel6.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Location = new Point(586, 198);
            panel7.Name = "panel7";
            panel7.Size = new Size(281, 184);
            panel7.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(222, 165);
            label10.Name = "label10";
            label10.Size = new Size(125, 20);
            label10.TabIndex = 5;
            label10.Text = "Recent Payments";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(605, 165);
            label11.Name = "label11";
            label11.Size = new Size(125, 20);
            label11.TabIndex = 5;
            label11.Text = "Tuition Overview";
            label11.Click += label10_Click;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(15, 74);
            iconButton1.Margin = new Padding(3, 2, 3, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(118, 58);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Student Management";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 35;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(15, 136);
            iconButton2.Margin = new Padding(3, 2, 3, 2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(118, 58);
            iconButton2.TabIndex = 1;
            iconButton2.Text = "Tuition Management";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 35;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(15, 189);
            iconButton3.Margin = new Padding(3, 2, 3, 2);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(118, 58);
            iconButton3.TabIndex = 1;
            iconButton3.Text = "Payments";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 35;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(15, 251);
            iconButton4.Margin = new Padding(3, 2, 3, 2);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(118, 58);
            iconButton4.TabIndex = 1;
            iconButton4.Text = "dashboard";
            iconButton4.TextAlign = ContentAlignment.MiddleRight;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 408);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(label5);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashboardForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "AdminDashboardForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel6;
        private Panel panel7;
        private Label label10;
        private Label label11;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}