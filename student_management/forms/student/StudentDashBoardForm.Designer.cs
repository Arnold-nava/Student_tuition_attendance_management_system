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
            panelPending = new Panel();
            panelAbsent = new Panel();
            panelLate = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            panelStatus = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            panelTodayClass = new Panel();
            panelPresent = new Panel();
            panelSidebar.SuspendLayout();
            panel1.SuspendLayout();
            panelPending.SuspendLayout();
            panelAbsent.SuspendLayout();
            panelLate.SuspendLayout();
            panel2.SuspendLayout();
            panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panelTodayClass.SuspendLayout();
            panelPresent.SuspendLayout();
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
            lblName.Location = new Point(521, 6);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(224, 20);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(94, 32);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Absent";
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
            lblTimeOut.Location = new Point(301, 77);
            lblTimeOut.Name = "lblTimeOut";
            lblTimeOut.Size = new Size(71, 19);
            lblTimeOut.TabIndex = 6;
            lblTimeOut.Text = "12:00 PM";
            // 
            // lblTodayClass
            // 
            lblTodayClass.AutoSize = true;
            lblTodayClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTodayClass.Location = new Point(24, 16);
            lblTodayClass.Name = "lblTodayClass";
            lblTodayClass.Size = new Size(109, 21);
            lblTodayClass.TabIndex = 7;
            lblTodayClass.Text = "Today's Class";
            // 
            // lblTotalAbsent
            // 
            lblTotalAbsent.AutoSize = true;
            lblTotalAbsent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalAbsent.Location = new Point(25, 91);
            lblTotalAbsent.Name = "lblTotalAbsent";
            lblTotalAbsent.Size = new Size(92, 19);
            lblTotalAbsent.TabIndex = 8;
            lblTotalAbsent.Text = "Total Absent";
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
            lblStudentNo.Location = new Point(237, 7);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(80, 19);
            lblStudentNo.TabIndex = 10;
            lblStudentNo.Text = "StudentNo";
            // 
            // lblTimeIn
            // 
            lblTimeIn.AutoSize = true;
            lblTimeIn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimeIn.Location = new Point(301, 58);
            lblTimeIn.Name = "lblTimeIn";
            lblTimeIn.Size = new Size(72, 19);
            lblTimeIn.TabIndex = 11;
            lblTimeIn.Text = "08:15 AM";
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
            panel1.Controls.Add(panelPending);
            panel1.Controls.Add(panelAbsent);
            panel1.Controls.Add(panelLate);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panelStatus);
            panel1.Controls.Add(panelTodayClass);
            panel1.Controls.Add(panelPresent);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 450);
            panel1.TabIndex = 13;
            // 
            // panelPending
            // 
            panelPending.BackColor = Color.White;
            panelPending.Controls.Add(lblPending);
            panelPending.Location = new Point(441, 155);
            panelPending.Name = "panelPending";
            panelPending.Size = new Size(137, 121);
            panelPending.TabIndex = 14;
            // 
            // panelAbsent
            // 
            panelAbsent.BackColor = Color.White;
            panelAbsent.Controls.Add(lblTotalAbsent);
            panelAbsent.Location = new Point(160, 155);
            panelAbsent.Name = "panelAbsent";
            panelAbsent.Size = new Size(134, 121);
            panelAbsent.TabIndex = 14;
            // 
            // panelLate
            // 
            panelLate.BackColor = Color.White;
            panelLate.Controls.Add(lblLate);
            panelLate.Location = new Point(300, 155);
            panelLate.Name = "panelLate";
            panelLate.Size = new Size(135, 121);
            panelLate.TabIndex = 14;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(16, 4);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 4;
            label2.Text = "DashBoard";
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.White;
            panelStatus.Controls.Add(iconPictureBox1);
            panelStatus.Controls.Add(label3);
            panelStatus.Controls.Add(lblStatus);
            panelStatus.Controls.Add(label5);
            panelStatus.Controls.Add(lblTimeOut);
            panelStatus.Controls.Add(label4);
            panelStatus.Controls.Add(lblTimeIn);
            panelStatus.Location = new Point(19, 43);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(559, 106);
            panelStatus.TabIndex = 14;
            panelStatus.Paint += panel4_Paint;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(255, 192, 192);
            iconPictureBox1.ForeColor = Color.Red;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconPictureBox1.IconColor = Color.Red;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 74;
            iconPictureBox1.Location = new Point(124, 20);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Padding = new Padding(0, 6, 0, 0);
            iconPictureBox1.Size = new Size(74, 76);
            iconPictureBox1.TabIndex = 12;
            iconPictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(224, 1);
            label3.Name = "label3";
            label3.Size = new Size(103, 19);
            label3.TabIndex = 4;
            label3.Text = "Today's Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(222, 77);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 6;
            label5.Text = "TimeOut :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(222, 58);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 11;
            label4.Text = "TimeIn    :";
            // 
            // panelTodayClass
            // 
            panelTodayClass.BackColor = Color.White;
            panelTodayClass.Controls.Add(lblTodayClass);
            panelTodayClass.Location = new Point(19, 282);
            panelTodayClass.Name = "panelTodayClass";
            panelTodayClass.Size = new Size(559, 141);
            panelTodayClass.TabIndex = 14;
            // 
            // panelPresent
            // 
            panelPresent.BackColor = Color.White;
            panelPresent.Controls.Add(lblTotalPresent);
            panelPresent.Location = new Point(19, 155);
            panelPresent.Name = "panelPresent";
            panelPresent.Size = new Size(135, 121);
            panelPresent.TabIndex = 14;
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
            panelPending.ResumeLayout(false);
            panelPending.PerformLayout();
            panelAbsent.ResumeLayout(false);
            panelAbsent.PerformLayout();
            panelLate.ResumeLayout(false);
            panelLate.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panelTodayClass.ResumeLayout(false);
            panelTodayClass.PerformLayout();
            panelPresent.ResumeLayout(false);
            panelPresent.PerformLayout();
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
        private Panel panelPending;
        private Panel panelLate;
        private Panel panelAbsent;
        private Panel panelTodayClass;
        private Panel panelPresent;
        private Panel panelStatus;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}