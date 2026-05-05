namespace student_management.forms.student
{
    partial class ProfileForm
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
            panel1 = new Panel();
            label2 = new Label();
            lblStatus = new Label();
            lblClass = new Label();
            lblEmail = new Label();
            lblStudentNo = new Label();
            lblName = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panelSidebar.SuspendLayout();
            panel1.SuspendLayout();
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
            panelSidebar.TabIndex = 2;
            panelSidebar.Paint += panelSidebar_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 37);
            label1.TabIndex = 1;
            label1.Text = "STUDENT";
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
            iconButton5.Click += iconButton5_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(128, 255, 128);
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
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(192, 255, 192);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            btnDashboard.IconColor = Color.Black;
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
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblClass);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblStudentNo);
            panel1.Controls.Add(lblName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 450);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(103, 37);
            label2.TabIndex = 1;
            label2.Text = "Profile";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblStatus.Location = new Point(105, 220);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(71, 28);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblClass.Location = new Point(105, 183);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(59, 28);
            lblClass.TabIndex = 3;
            lblClass.Text = "Class";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblEmail.Location = new Point(105, 147);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 28);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblStudentNo.Location = new Point(105, 111);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(114, 28);
            lblStudentNo.TabIndex = 1;
            lblStudentNo.Text = "student no";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblName.Location = new Point(105, 69);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 28);
            lblName.TabIndex = 0;
            lblName.Text = "name";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelSidebar);
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnAttendance;
        private FontAwesome.Sharp.IconButton btnMyQR;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Panel panel1;
        private Label label7;
        private Label lblStatus;
        private Label lblClass;
        private Label lblEmail;
        private Label lblStudentNo;
        private Label lblName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label label2;
    }
}