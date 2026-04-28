namespace student_management.forms.Admin
{
    partial class PaymentForm
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
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            dgvStudents = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
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
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 413);
            panel1.TabIndex = 3;
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
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(168, 78);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(619, 303);
            dgvStudents.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(583, 31);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(207, 25);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 8;
            label1.Text = "Payment History";
            // 
            // TuitionManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 409);
            Controls.Add(dgvStudents);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "TuitionManagementForm";
            Text = "TuitionManagementForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnHome;
        private DataGridView dgvStudents;
        private TextBox textBox1;
        private Label label1;
    }
}