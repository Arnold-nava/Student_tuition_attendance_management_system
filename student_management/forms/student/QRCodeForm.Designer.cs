namespace student_management.forms.student
{
    partial class QRCodeForm
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
            picQR = new FontAwesome.Sharp.IconPictureBox();
            lblName = new Label();
            lblStudentNo = new Label();
            btnDownload = new FontAwesome.Sharp.IconButton();
            btnPrint = new FontAwesome.Sharp.IconButton();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picQR).BeginInit();
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
            panelSidebar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
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
            // 
            // btnMyQR
            // 
            btnMyQR.BackColor = Color.FromArgb(128, 255, 128);
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
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(192, 255, 192);
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
            // 
            // picQR
            // 
            picQR.BackColor = SystemColors.Control;
            picQR.ForeColor = SystemColors.ControlText;
            picQR.IconChar = FontAwesome.Sharp.IconChar.None;
            picQR.IconColor = SystemColors.ControlText;
            picQR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picQR.Location = new Point(458, 183);
            picQR.Name = "picQR";
            picQR.Size = new Size(32, 32);
            picQR.TabIndex = 2;
            picQR.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(458, 105);
            lblName.Name = "lblName";
            lblName.Size = new Size(37, 15);
            lblName.TabIndex = 3;
            lblName.Text = "name";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(442, 126);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(70, 15);
            lblStudentNo.TabIndex = 4;
            lblStudentNo.Text = "Student No.";
            // 
            // btnDownload
            // 
            btnDownload.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDownload.IconColor = Color.Black;
            btnDownload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDownload.Location = new Point(361, 326);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 5;
            btnDownload.Text = "download";
            btnDownload.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPrint.IconColor = Color.Black;
            btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrint.Location = new Point(512, 326);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // QRCodeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrint);
            Controls.Add(btnDownload);
            Controls.Add(lblStudentNo);
            Controls.Add(lblName);
            Controls.Add(picQR);
            Controls.Add(panelSidebar);
            Name = "QRCodeForm";
            Text = "QRCodeForm";
            Load += QRCodeForm_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSidebar;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnAttendance;
        private FontAwesome.Sharp.IconButton btnMyQR;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconPictureBox picQR;
        private Label lblName;
        private Label lblStudentNo;
        private FontAwesome.Sharp.IconButton btnDownload;
        private FontAwesome.Sharp.IconButton btnPrint;
    }
}