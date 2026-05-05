namespace student_management.forms.Admin
{
    partial class AttendanceHistoryForm
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
            btnAttendanceRecords = new FontAwesome.Sharp.IconButton();
            btnStudentManagement = new FontAwesome.Sharp.IconButton();
            btnScanner = new FontAwesome.Sharp.IconButton();
            btnDaashboard = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            lblClassInfo = new Label();
            lblSubject = new Label();
            lblStatus = new Label();
            picCamera = new PictureBox();
            panel3 = new Panel();
            lblStudentStatus = new Label();
            lblStudentNo = new Label();
            lblStudentName = new Label();
            lblTimeIn = new Label();
            btnTimeOut = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCamera).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAttendanceRecords);
            panel1.Controls.Add(btnStudentManagement);
            panel1.Controls.Add(btnScanner);
            panel1.Controls.Add(btnDaashboard);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 466);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 418);
            button1.Name = "button1";
            button1.Size = new Size(107, 36);
            button1.TabIndex = 1;
            button1.Text = "LogOut";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAttendanceRecords
            // 
            btnAttendanceRecords.FlatAppearance.BorderSize = 0;
            btnAttendanceRecords.FlatStyle = FlatStyle.Flat;
            btnAttendanceRecords.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttendanceRecords.IconChar = FontAwesome.Sharp.IconChar.HouseCircleCheck;
            btnAttendanceRecords.IconColor = Color.Black;
            btnAttendanceRecords.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAttendanceRecords.IconSize = 32;
            btnAttendanceRecords.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendanceRecords.Location = new Point(12, 165);
            btnAttendanceRecords.Name = "btnAttendanceRecords";
            btnAttendanceRecords.Size = new Size(160, 44);
            btnAttendanceRecords.TabIndex = 0;
            btnAttendanceRecords.Text = "attendance record";
            btnAttendanceRecords.TextAlign = ContentAlignment.MiddleRight;
            btnAttendanceRecords.UseVisualStyleBackColor = true;
            // 
            // btnStudentManagement
            // 
            btnStudentManagement.FlatAppearance.BorderSize = 0;
            btnStudentManagement.FlatStyle = FlatStyle.Flat;
            btnStudentManagement.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentManagement.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnStudentManagement.IconColor = Color.Black;
            btnStudentManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStudentManagement.IconSize = 32;
            btnStudentManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudentManagement.Location = new Point(12, 115);
            btnStudentManagement.Name = "btnStudentManagement";
            btnStudentManagement.Size = new Size(160, 44);
            btnStudentManagement.TabIndex = 0;
            btnStudentManagement.Text = "Manage Students";
            btnStudentManagement.TextAlign = ContentAlignment.MiddleRight;
            btnStudentManagement.UseVisualStyleBackColor = true;
            // 
            // btnScanner
            // 
            btnScanner.FlatAppearance.BorderSize = 0;
            btnScanner.FlatStyle = FlatStyle.Flat;
            btnScanner.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScanner.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            btnScanner.IconColor = Color.Black;
            btnScanner.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnScanner.IconSize = 32;
            btnScanner.ImageAlign = ContentAlignment.MiddleLeft;
            btnScanner.Location = new Point(12, 65);
            btnScanner.Name = "btnScanner";
            btnScanner.Size = new Size(107, 44);
            btnScanner.TabIndex = 0;
            btnScanner.Text = "Scanner";
            btnScanner.TextAlign = ContentAlignment.MiddleRight;
            btnScanner.UseVisualStyleBackColor = true;
            // 
            // btnDaashboard
            // 
            btnDaashboard.FlatAppearance.BorderSize = 0;
            btnDaashboard.FlatStyle = FlatStyle.Flat;
            btnDaashboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            btnDaashboard.IconColor = Color.Black;
            btnDaashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDaashboard.IconSize = 32;
            btnDaashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDaashboard.Location = new Point(12, 15);
            btnDaashboard.Name = "btnDaashboard";
            btnDaashboard.Size = new Size(120, 44);
            btnDaashboard.TabIndex = 0;
            btnDaashboard.Text = "Dashboard";
            btnDaashboard.TextAlign = ContentAlignment.MiddleRight;
            btnDaashboard.UseVisualStyleBackColor = true;
            btnDaashboard.Click += btnDaashboard_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(lblSubject);
            panel2.Controls.Add(lblClassInfo);
            panel2.Location = new Point(300, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 83);
            panel2.TabIndex = 3;
            // 
            // lblClassInfo
            // 
            lblClassInfo.AutoSize = true;
            lblClassInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassInfo.Location = new Point(17, 12);
            lblClassInfo.Name = "lblClassInfo";
            lblClassInfo.Size = new Size(57, 21);
            lblClassInfo.TabIndex = 0;
            lblClassInfo.Text = "label1";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(17, 33);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(45, 17);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "label1";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(17, 53);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 17);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "label1";
            // 
            // picCamera
            // 
            picCamera.BackColor = Color.Black;
            picCamera.Location = new Point(300, 115);
            picCamera.Name = "picCamera";
            picCamera.Size = new Size(376, 188);
            picCamera.TabIndex = 4;
            picCamera.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTimeIn);
            panel3.Controls.Add(lblStudentStatus);
            panel3.Controls.Add(lblStudentNo);
            panel3.Controls.Add(lblStudentName);
            panel3.Location = new Point(300, 309);
            panel3.Name = "panel3";
            panel3.Size = new Size(375, 67);
            panel3.TabIndex = 3;
            // 
            // lblStudentStatus
            // 
            lblStudentStatus.AutoSize = true;
            lblStudentStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentStatus.Location = new Point(239, 33);
            lblStudentStatus.Name = "lblStudentStatus";
            lblStudentStatus.Size = new Size(45, 17);
            lblStudentStatus.TabIndex = 0;
            lblStudentStatus.Text = "label1";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentNo.Location = new Point(17, 33);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(45, 17);
            lblStudentNo.TabIndex = 0;
            lblStudentNo.Text = "label1";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentName.Location = new Point(17, 12);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(57, 21);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "label1";
            // 
            // lblTimeIn
            // 
            lblTimeIn.AutoSize = true;
            lblTimeIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeIn.Location = new Point(239, 16);
            lblTimeIn.Name = "lblTimeIn";
            lblTimeIn.Size = new Size(45, 17);
            lblTimeIn.TabIndex = 0;
            lblTimeIn.Text = "label1";
            // 
            // btnTimeOut
            // 
            btnTimeOut.BackColor = Color.LimeGreen;
            btnTimeOut.FlatStyle = FlatStyle.Flat;
            btnTimeOut.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimeOut.Location = new Point(301, 397);
            btnTimeOut.Name = "btnTimeOut";
            btnTimeOut.Size = new Size(182, 44);
            btnTimeOut.TabIndex = 5;
            btnTimeOut.Text = "Time Out";
            btnTimeOut.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(494, 397);
            button2.Name = "button2";
            button2.Size = new Size(182, 44);
            button2.TabIndex = 5;
            button2.Text = "Time Out";
            button2.UseVisualStyleBackColor = false;
            // 
            // AttendanceHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 465);
            Controls.Add(button2);
            Controls.Add(btnTimeOut);
            Controls.Add(picCamera);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AttendanceHistoryForm";
            Text = "AttendanceHistoryForm";
            Load += AttendanceHistoryForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCamera).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private FontAwesome.Sharp.IconButton btnAttendanceRecords;
        private FontAwesome.Sharp.IconButton btnStudentManagement;
        private FontAwesome.Sharp.IconButton btnScanner;
        private FontAwesome.Sharp.IconButton btnDaashboard;
        private Panel panel2;
        private Label lblSubject;
        private Label lblClassInfo;
        private Label lblStatus;
        private PictureBox picCamera;
        private Panel panel3;
        private Label lblTimeIn;
        private Label lblStudentStatus;
        private Label lblStudentNo;
        private Label lblStudentName;
        private Button btnTimeOut;
        private Button button2;
    }
}