namespace student_management.forms.student
{
    partial class StudentDashBoardForm
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
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnProfile = new FontAwesome.Sharp.IconButton();
            btnAttendance = new FontAwesome.Sharp.IconButton();
            btnMyQR = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            lblName = new Label();
            lblStatus = new Label();
            lblPending = new Label();
            lblTimeOut = new Label();
            lblTodayClass = new Label();
            lblTotalAbsent = new Label();
            lblLate = new Label();
            lblStudentNo = new Label();
            lblTimeIn = new Label();
            lblTotalPresent = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            label2 = new Label();
            panelSidebar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(192, 255, 192);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnProfile);
            panelSidebar.Controls.Add(btnAttendance);
            panelSidebar.Controls.Add(btnMyQR);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.ForeColor = Color.Black;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 450);
            panelSidebar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 37);
            label1.TabIndex = 1;
            label1.Text = "STUDENT";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(128, 255, 128);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogout.ForeColor = Color.Green;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnLogout.IconColor = Color.Green;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(12, 396);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(165, 42);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleRight;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(192, 255, 192);
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnProfile.ForeColor = Color.Black;
            btnProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            btnProfile.IconColor = Color.Black;
            btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(12, 241);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(165, 50);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Profile";
            btnProfile.TextAlign = ContentAlignment.MiddleRight;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.FromArgb(192, 255, 192);
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAttendance.ForeColor = Color.Black;
            btnAttendance.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            btnAttendance.IconColor = Color.Black;
            btnAttendance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(12, 183);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(165, 52);
            btnAttendance.TabIndex = 0;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleRight;
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnMyQR
            // 
            btnMyQR.BackColor = Color.FromArgb(192, 255, 192);
            btnMyQR.FlatAppearance.BorderSize = 0;
            btnMyQR.FlatStyle = FlatStyle.Flat;
            btnMyQR.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMyQR.ForeColor = Color.Black;
            btnMyQR.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            btnMyQR.IconColor = Color.Black;
            btnMyQR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMyQR.ImageAlign = ContentAlignment.MiddleLeft;
            btnMyQR.Location = new Point(12, 126);
            btnMyQR.Name = "btnMyQR";
            btnMyQR.Size = new Size(165, 51);
            btnMyQR.TabIndex = 0;
            btnMyQR.Text = "QR code";
            btnMyQR.TextAlign = ContentAlignment.MiddleRight;
            btnMyQR.UseVisualStyleBackColor = false;
            btnMyQR.Click += btnMyQR_Click;
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
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblName.Location = new Point(521, 5);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.Location = new Point(215, 10);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(103, 19);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Today's Status";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPending.Location = new Point(35, 91);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(64, 19);
            lblPending.TabIndex = 5;
            lblPending.Text = "Pending";
            // 
            // lblTimeOut
            // 
            lblTimeOut.AutoSize = true;
            lblTimeOut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimeOut.Location = new Point(221, 83);
            lblTimeOut.Name = "lblTimeOut";
            lblTimeOut.Size = new Size(66, 19);
            lblTimeOut.TabIndex = 6;
            lblTimeOut.Text = "TimeOut";
            // 
            // lblTodayClass
            // 
            lblTodayClass.AutoSize = true;
            lblTodayClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTodayClass.Location = new Point(24, 16);
            lblTodayClass.Name = "lblTodayClass";
            lblTodayClass.Size = new Size(94, 21);
            lblTodayClass.TabIndex = 7;
            lblTodayClass.Text = "TodayClass";
            // 
            // lblTotalAbsent
            // 
            lblTotalAbsent.AutoSize = true;
            lblTotalAbsent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalAbsent.Location = new Point(25, 91);
            lblTotalAbsent.Name = "lblTotalAbsent";
            lblTotalAbsent.Size = new Size(88, 19);
            lblTotalAbsent.TabIndex = 8;
            lblTotalAbsent.Text = "TotalAbsent";
            // 
            // lblLate
            // 
            lblLate.AutoSize = true;
            lblLate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLate.Location = new Point(43, 91);
            lblLate.Name = "lblLate";
            lblLate.Size = new Size(37, 19);
            lblLate.TabIndex = 9;
            lblLate.Text = "Late";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudentNo.Location = new Point(251, 5);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(80, 19);
            lblStudentNo.TabIndex = 10;
            lblStudentNo.Text = "StudentNo";
            // 
            // lblTimeIn
            // 
            lblTimeIn.AutoSize = true;
            lblTimeIn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimeIn.Location = new Point(221, 64);
            lblTimeIn.Name = "lblTimeIn";
            lblTimeIn.Size = new Size(54, 19);
            lblTimeIn.TabIndex = 11;
            lblTimeIn.Text = "TimeIn";
            // 
            // lblTotalPresent
            // 
            lblTotalPresent.AutoSize = true;
            lblTotalPresent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalPresent.Location = new Point(24, 91);
            lblTotalPresent.Name = "lblTotalPresent";
            lblTotalPresent.Size = new Size(96, 19);
            lblTotalPresent.TabIndex = 12;
            lblTotalPresent.Text = "Total Present";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 450);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(lblStudentNo);
            panel2.Location = new Point(6, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 33);
            panel2.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblStatus);
            panel4.Controls.Add(lblTimeOut);
            panel4.Controls.Add(lblTimeIn);
            panel4.Location = new Point(19, 43);
            panel4.Name = "panel4";
            panel4.Size = new Size(559, 106);
            panel4.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblTotalPresent);
            panel5.Location = new Point(19, 155);
            panel5.Name = "panel5";
            panel5.Size = new Size(135, 121);
            panel5.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(lblTotalAbsent);
            panel6.Location = new Point(160, 155);
            panel6.Name = "panel6";
            panel6.Size = new Size(134, 121);
            panel6.TabIndex = 14;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(lblLate);
            panel7.Location = new Point(300, 155);
            panel7.Name = "panel7";
            panel7.Size = new Size(135, 121);
            panel7.TabIndex = 14;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(lblPending);
            panel8.Location = new Point(441, 155);
            panel8.Name = "panel8";
            panel8.Size = new Size(137, 121);
            panel8.TabIndex = 14;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(lblTodayClass);
            panel9.Location = new Point(19, 282);
            panel9.Name = "panel9";
            panel9.Size = new Size(559, 141);
            panel9.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(2, 4);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 4;
            label2.Text = "DashBoard";
            // 
            // StudentDashBoardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelSidebar);
            Name = "StudentDashBoardForm";
            Text = "StudentDashBoardForm";
            Load += StudentDashBoardForm_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnAttendance;
        private FontAwesome.Sharp.IconButton btnMyQR;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Label lblName;
        private Label lblStatus;
        private Label lblPending;
        private Label lblTimeOut;
        private Label lblTodayClass;
        private Label lblTotalAbsent;
        private Label lblLate;
        private Label lblStudentNo;
        private Label lblTimeIn;
        private Label lblTotalPresent;
        private Panel panel1;
        private Panel panel2;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel9;
        private Panel panel5;
        private Panel panel4;
        private Label label2;
    }
}