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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            button1 = new Button();
            btnScanner = new FontAwesome.Sharp.IconButton();
            btnTuitionManagement = new FontAwesome.Sharp.IconButton();
            btnPayments = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            lblStudents = new Label();
            label1 = new Label();
            label5 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            lblRevenue = new Label();
            label3 = new Label();
            dgvRecentPayments = new DataGridView();
            sessionBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentPayments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sessionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnScanner);
            panel1.Controls.Add(btnTuitionManagement);
            panel1.Controls.Add(btnPayments);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 552);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(47, 481);
            button1.Name = "button1";
            button1.Size = new Size(75, 40);
            button1.TabIndex = 2;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnScanner
            // 
            btnScanner.FlatAppearance.BorderSize = 0;
            btnScanner.FlatStyle = FlatStyle.Flat;
            btnScanner.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScanner.ForeColor = Color.White;
            btnScanner.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            btnScanner.IconColor = Color.White;
            btnScanner.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnScanner.IconSize = 35;
            btnScanner.ImageAlign = ContentAlignment.MiddleLeft;
            btnScanner.Location = new Point(17, 335);
            btnScanner.Name = "btnScanner";
            btnScanner.Size = new Size(135, 77);
            btnScanner.TabIndex = 1;
            btnScanner.Text = "Scanner";
            btnScanner.TextAlign = ContentAlignment.MiddleRight;
            btnScanner.UseVisualStyleBackColor = true;
            btnScanner.Click += btnScanner_Click_1;
            // 
            // btnTuitionManagement
            // 
            btnTuitionManagement.FlatAppearance.BorderSize = 0;
            btnTuitionManagement.FlatStyle = FlatStyle.Flat;
            btnTuitionManagement.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTuitionManagement.ForeColor = Color.White;
            btnTuitionManagement.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            btnTuitionManagement.IconColor = Color.White;
            btnTuitionManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTuitionManagement.IconSize = 35;
            btnTuitionManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnTuitionManagement.Location = new Point(17, 181);
            btnTuitionManagement.Name = "btnTuitionManagement";
            btnTuitionManagement.Size = new Size(135, 77);
            btnTuitionManagement.TabIndex = 1;
            btnTuitionManagement.Text = "Tuition Management";
            btnTuitionManagement.TextAlign = ContentAlignment.MiddleRight;
            btnTuitionManagement.UseVisualStyleBackColor = true;
            btnTuitionManagement.Click += btnTuitionManagement_Click;
            // 
            // btnPayments
            // 
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayments.ForeColor = Color.White;
            btnPayments.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            btnPayments.IconColor = Color.White;
            btnPayments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPayments.IconSize = 35;
            btnPayments.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayments.Location = new Point(17, 252);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(135, 77);
            btnPayments.TabIndex = 1;
            btnPayments.Text = "Payments";
            btnPayments.TextAlign = ContentAlignment.MiddleRight;
            btnPayments.UseVisualStyleBackColor = true;
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
            iconButton1.Location = new Point(17, 99);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(135, 77);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Student Management";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
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
            btnHome.Location = new Point(17, 16);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(135, 77);
            btnHome.TabIndex = 1;
            btnHome.Text = "dashboard";
            btnHome.TextAlign = ContentAlignment.MiddleRight;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblStudents);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(213, 63);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(139, 113);
            panel2.TabIndex = 2;
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudents.Location = new Point(55, 62);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(19, 21);
            lblStudents.TabIndex = 1;
            lblStudents.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 13);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 0;
            label1.Text = "Total  Students";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(213, 16);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 5;
            label5.Text = "Dashboard";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(209, 218);
            label10.Name = "label10";
            label10.Size = new Size(125, 20);
            label10.TabIndex = 5;
            label10.Text = "Recent Payments";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblRevenue);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(379, 63);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(139, 113);
            panel3.TabIndex = 3;
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenue.Location = new Point(55, 62);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(19, 21);
            lblRevenue.TabIndex = 1;
            lblRevenue.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 13);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 0;
            label3.Text = "Total Revenue";
            // 
            // dgvRecentPayments
            // 
            dgvRecentPayments.AutoGenerateColumns = false;
            dgvRecentPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentPayments.DataSource = sessionBindingSource;
            dgvRecentPayments.Location = new Point(209, 252);
            dgvRecentPayments.Name = "dgvRecentPayments";
            dgvRecentPayments.Size = new Size(747, 269);
            dgvRecentPayments.TabIndex = 6;
            // 
            // sessionBindingSource
            // 
            sessionBindingSource.DataSource = typeof(Helpers.Session);
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 544);
            Controls.Add(dgvRecentPayments);
            Controls.Add(panel3);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminDashboardForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentPayments).EndInit();
            ((System.ComponentModel.ISupportInitialize)sessionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panel2;
        private Label label1;
        private Label label5;
        private Label lblStudents;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnScanner;
        private FontAwesome.Sharp.IconButton btnTuitionManagement;
        private FontAwesome.Sharp.IconButton btnPayments;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel3;
        private Label lblRevenue;
        private Label label3;
        private DataGridView dgvRecentPayments;
        private BindingSource sessionBindingSource;
    }
}