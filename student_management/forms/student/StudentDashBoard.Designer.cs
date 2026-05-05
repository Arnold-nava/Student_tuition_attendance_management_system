namespace student_management.forms.student
{
    partial class StudentDashBoard
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
            panelSidebar = new Panel();
            label1 = new Label();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            btnProfile = new FontAwesome.Sharp.IconButton();
            btnAttendance = new FontAwesome.Sharp.IconButton();
            btnMyQR = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panelMain = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lblTodayClass = new Label();
            label16 = new Label();
            label15 = new Label();
            label5 = new Label();
            label12 = new Label();
            label14 = new Label();
            label13 = new Label();
            label11 = new Label();
            lblTimeOut = new Label();
            lblTimeIn = new Label();
            lblStatus = new Label();
            label2 = new Label();
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(192, 255, 192);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(iconButton5);
            panelSidebar.Controls.Add(btnProfile);
            panelSidebar.Controls.Add(btnAttendance);
            panelSidebar.Controls.Add(btnMyQR);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 450);
            panelSidebar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "STUDENT";
            label1.Click += label1_Click;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.FromArgb(128, 255, 128);
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            iconButton5.ForeColor = Color.Green;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconButton5.IconColor = Color.Green;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(12, 396);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(165, 42);
            iconButton5.TabIndex = 0;
            iconButton5.Text = "Logout";
            iconButton5.TextAlign = ContentAlignment.MiddleRight;
            iconButton5.UseVisualStyleBackColor = false;
            iconButton5.Click += iconButton1_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(192, 255, 192);
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnProfile.ForeColor = Color.Green;
            btnProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            btnProfile.IconColor = Color.Green;
            btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(12, 241);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(165, 50);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Profile";
            btnProfile.TextAlign = ContentAlignment.MiddleRight;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += iconButton1_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.FromArgb(192, 255, 192);
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAttendance.ForeColor = Color.Green;
            btnAttendance.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            btnAttendance.IconColor = Color.Green;
            btnAttendance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(12, 183);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(165, 52);
            btnAttendance.TabIndex = 0;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleRight;
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += iconButton1_Click;
            // 
            // btnMyQR
            // 
            btnMyQR.BackColor = Color.FromArgb(192, 255, 192);
            btnMyQR.FlatAppearance.BorderSize = 0;
            btnMyQR.FlatStyle = FlatStyle.Flat;
            btnMyQR.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMyQR.ForeColor = Color.Green;
            btnMyQR.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            btnMyQR.IconColor = Color.Green;
            btnMyQR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMyQR.ImageAlign = ContentAlignment.MiddleLeft;
            btnMyQR.Location = new Point(12, 126);
            btnMyQR.Name = "btnMyQR";
            btnMyQR.Size = new Size(165, 51);
            btnMyQR.TabIndex = 0;
            btnMyQR.Text = "QR code";
            btnMyQR.TextAlign = ContentAlignment.MiddleRight;
            btnMyQR.UseVisualStyleBackColor = false;
            btnMyQR.Click += iconButton1_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(128, 255, 128);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.Green;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            btnDashboard.IconColor = Color.Green;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(12, 69);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(165, 51);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleRight;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += iconButton1_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(label9);
            panelMain.Controls.Add(label8);
            panelMain.Controls.Add(label7);
            panelMain.Controls.Add(lblTodayClass);
            panelMain.Controls.Add(label16);
            panelMain.Controls.Add(label15);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(label12);
            panelMain.Controls.Add(label14);
            panelMain.Controls.Add(label13);
            panelMain.Controls.Add(label11);
            panelMain.Controls.Add(lblTimeOut);
            panelMain.Controls.Add(lblTimeIn);
            panelMain.Controls.Add(lblStatus);
            panelMain.Controls.Add(label2);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(600, 450);
            panelMain.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(85, 348);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 1;
            label9.Text = "8 00 - 9 00";
            label9.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(139, 304);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 1;
            label8.Text = "Mathematics";
            label8.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 304);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 1;
            label7.Text = "Grade 10 - A";
            label7.Click += label1_Click;
            // 
            // lblTodayClass
            // 
            lblTodayClass.AutoSize = true;
            lblTodayClass.Location = new Point(53, 257);
            lblTodayClass.Name = "lblTodayClass";
            lblTodayClass.Size = new Size(76, 15);
            lblTodayClass.TabIndex = 1;
            lblTodayClass.Text = "Today’s Class";
            lblTodayClass.Click += label1_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(305, 183);
            label16.Name = "label16";
            label16.Size = new Size(60, 15);
            label16.TabIndex = 1;
            label16.Text = "0 pending";
            label16.Click += label1_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(215, 183);
            label15.Name = "label15";
            label15.Size = new Size(35, 15);
            label15.TabIndex = 1;
            label15.Text = "1 late";
            label15.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 183);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 1;
            label5.Text = "2 total absent";
            label5.Click += label1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(35, 183);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 1;
            label12.Text = "18 total present";
            label12.Click += label1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(85, 100);
            label14.Name = "label14";
            label14.Size = new Size(34, 15);
            label14.TabIndex = 1;
            label14.Text = "09 00";
            label14.Click += label1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(75, 84);
            label13.Name = "label13";
            label13.Size = new Size(34, 15);
            label13.TabIndex = 1;
            label13.Text = "08 15";
            label13.Click += label1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(108, 69);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 1;
            label11.Text = "Present";
            label11.Click += label1_Click;
            // 
            // lblTimeOut
            // 
            lblTimeOut.AutoSize = true;
            lblTimeOut.Location = new Point(20, 100);
            lblTimeOut.Name = "lblTimeOut";
            lblTimeOut.Size = new Size(59, 15);
            lblTimeOut.TabIndex = 1;
            lblTimeOut.Text = "Time Out:";
            lblTimeOut.Click += label1_Click;
            // 
            // lblTimeIn
            // 
            lblTimeIn.AutoSize = true;
            lblTimeIn.Location = new Point(20, 85);
            lblTimeIn.Name = "lblTimeIn";
            lblTimeIn.Size = new Size(49, 15);
            lblTimeIn.TabIndex = 1;
            lblTimeIn.Text = "Time In:";
            lblTimeIn.Click += label1_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(20, 69);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(84, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Today's Status:";
            lblStatus.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 9);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "DashBoard";
            label2.Click += label1_Click;
            // 
            // StudentDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Name = "StudentDashBoard";
            Text = "StudentDashBoard";
            Load += StudentDashBoard_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Label label1;
        private Panel panelMain;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnAttendance;
        private FontAwesome.Sharp.IconButton btnMyQR;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label lblTodayClass;
        private Label lblStatus;
        private Label label2;
        private Label label12;
        private Label label11;
        private Label lblTimeOut;
        private Label lblTimeIn;
        private Label label16;
        private Label label15;
        private Label label5;
        private Label label14;
        private Label label13;
    }
}