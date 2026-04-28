namespace student_management.forms
{
    partial class StudentDashboardForm
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
            btnPayment = new FontAwesome.Sharp.IconButton();
            btnPaymentHistory = new FontAwesome.Sharp.IconButton();
            btnQR = new FontAwesome.Sharp.IconButton();
            btnAttendance = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            lblUser = new Label();
            panel2 = new Panel();
            label3 = new Label();
            lblBalance = new Label();
            label1 = new Label();
            panel3 = new Panel();
            lblNextDue = new Label();
            label6 = new Label();
            panel4 = new Panel();
            lblStatus = new Label();
            label9 = new Label();
            label2 = new Label();
            btnPaynow = new FontAwesome.Sharp.IconButton();
            btnQRCode = new FontAwesome.Sharp.IconButton();
            btnAttendanceHistory = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            linkLabel2 = new LinkLabel();
            panelRecentPayments = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnPayment);
            panel1.Controls.Add(btnPaymentHistory);
            panel1.Controls.Add(btnQR);
            panel1.Controls.Add(btnAttendance);
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(1, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(93, 412);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(15, 382);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(66, 20);
            button1.TabIndex = 2;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnPayment
            // 
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            btnPayment.IconColor = Color.White;
            btnPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPayment.IconSize = 35;
            btnPayment.Location = new Point(15, 74);
            btnPayment.Margin = new Padding(3, 2, 3, 2);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(66, 58);
            btnPayment.TabIndex = 1;
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnPaymentHistory
            // 
            btnPaymentHistory.FlatAppearance.BorderSize = 0;
            btnPaymentHistory.FlatStyle = FlatStyle.Flat;
            btnPaymentHistory.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnPaymentHistory.IconColor = Color.White;
            btnPaymentHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPaymentHistory.IconSize = 35;
            btnPaymentHistory.Location = new Point(15, 260);
            btnPaymentHistory.Margin = new Padding(3, 2, 3, 2);
            btnPaymentHistory.Name = "btnPaymentHistory";
            btnPaymentHistory.Size = new Size(66, 58);
            btnPaymentHistory.TabIndex = 1;
            btnPaymentHistory.UseVisualStyleBackColor = true;
            btnPaymentHistory.Click += iconButton4_Click;
            // 
            // btnQR
            // 
            btnQR.FlatAppearance.BorderSize = 0;
            btnQR.FlatStyle = FlatStyle.Flat;
            btnQR.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            btnQR.IconColor = Color.White;
            btnQR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQR.IconSize = 35;
            btnQR.Location = new Point(15, 198);
            btnQR.Margin = new Padding(3, 2, 3, 2);
            btnQR.Name = "btnQR";
            btnQR.Size = new Size(66, 58);
            btnQR.TabIndex = 1;
            btnQR.UseVisualStyleBackColor = true;
            btnQR.Click += btnQR_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            btnAttendance.IconColor = Color.White;
            btnAttendance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAttendance.IconSize = 35;
            btnAttendance.Location = new Point(15, 136);
            btnAttendance.Margin = new Padding(3, 2, 3, 2);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(66, 58);
            btnAttendance.TabIndex = 1;
            btnAttendance.UseVisualStyleBackColor = true;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnHome.IconColor = Color.White;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 35;
            btnHome.Location = new Point(15, 11);
            btnHome.Margin = new Padding(3, 2, 3, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(66, 58);
            btnHome.TabIndex = 1;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(104, 15);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(199, 32);
            lblUser.TabIndex = 1;
            lblUser.Text = "Welcome Guest!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblBalance);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(108, 50);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 93);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(125, 17);
            label3.TabIndex = 1;
            label3.Text = "Remaining balance";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(12, 36);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(102, 32);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "Balance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 1;
            label1.Text = "Balance";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.Controls.Add(lblNextDue);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(294, 50);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(163, 93);
            panel3.TabIndex = 2;
            // 
            // lblNextDue
            // 
            lblNextDue.AutoSize = true;
            lblNextDue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNextDue.Location = new Point(12, 34);
            lblNextDue.Name = "lblNextDue";
            lblNextDue.Size = new Size(67, 32);
            lblNextDue.TabIndex = 1;
            lblNextDue.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 11);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 1;
            label6.Text = "Next Due";
            // 
            // panel4
            // 
            panel4.BackColor = Color.OldLace;
            panel4.Controls.Add(lblStatus);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(483, 50);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(163, 93);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(12, 34);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(83, 32);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 11);
            label9.Name = "label9";
            label9.Size = new Size(67, 25);
            label9.TabIndex = 1;
            label9.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 157);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 1;
            label2.Text = "Quick Actions";
            // 
            // btnPaynow
            // 
            btnPaynow.FlatAppearance.BorderColor = Color.LightSlateGray;
            btnPaynow.FlatAppearance.BorderSize = 2;
            btnPaynow.FlatStyle = FlatStyle.Flat;
            btnPaynow.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaynow.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            btnPaynow.IconColor = Color.DodgerBlue;
            btnPaynow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPaynow.IconSize = 45;
            btnPaynow.Location = new Point(110, 196);
            btnPaynow.Margin = new Padding(3, 2, 3, 2);
            btnPaynow.Name = "btnPaynow";
            btnPaynow.Size = new Size(163, 83);
            btnPaynow.TabIndex = 1;
            btnPaynow.Text = "Pay now";
            btnPaynow.TextAlign = ContentAlignment.BottomCenter;
            btnPaynow.UseVisualStyleBackColor = true;
            btnPaynow.Click += btnPaynow_Click;
            // 
            // btnQRCode
            // 
            btnQRCode.FlatAppearance.BorderColor = Color.LightSlateGray;
            btnQRCode.FlatAppearance.BorderSize = 2;
            btnQRCode.FlatStyle = FlatStyle.Flat;
            btnQRCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQRCode.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            btnQRCode.IconColor = Color.DodgerBlue;
            btnQRCode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQRCode.IconSize = 45;
            btnQRCode.Location = new Point(297, 196);
            btnQRCode.Margin = new Padding(3, 2, 3, 2);
            btnQRCode.Name = "btnQRCode";
            btnQRCode.Size = new Size(163, 83);
            btnQRCode.TabIndex = 1;
            btnQRCode.Text = "My QR Code";
            btnQRCode.TextAlign = ContentAlignment.BottomCenter;
            btnQRCode.UseVisualStyleBackColor = true;
            btnQRCode.Click += btnQRCode_Click;
            // 
            // btnAttendanceHistory
            // 
            btnAttendanceHistory.FlatAppearance.BorderColor = Color.LightSlateGray;
            btnAttendanceHistory.FlatAppearance.BorderSize = 2;
            btnAttendanceHistory.FlatStyle = FlatStyle.Flat;
            btnAttendanceHistory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttendanceHistory.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            btnAttendanceHistory.IconColor = Color.DodgerBlue;
            btnAttendanceHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAttendanceHistory.IconSize = 45;
            btnAttendanceHistory.Location = new Point(486, 196);
            btnAttendanceHistory.Margin = new Padding(3, 2, 3, 2);
            btnAttendanceHistory.Name = "btnAttendanceHistory";
            btnAttendanceHistory.Size = new Size(163, 83);
            btnAttendanceHistory.TabIndex = 1;
            btnAttendanceHistory.Text = "Attendance History";
            btnAttendanceHistory.TextAlign = ContentAlignment.BottomCenter;
            btnAttendanceHistory.UseVisualStyleBackColor = true;
            btnAttendanceHistory.Click += iconButton8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(110, 302);
            label4.Name = "label4";
            label4.Size = new Size(141, 21);
            label4.TabIndex = 1;
            label4.Text = "Recent Payments";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.DodgerBlue;
            linkLabel2.Location = new Point(588, 302);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(47, 15);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "View all";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // panelRecentPayments
            // 
            panelRecentPayments.Location = new Point(116, 333);
            panelRecentPayments.Name = "panelRecentPayments";
            panelRecentPayments.Size = new Size(519, 67);
            panelRecentPayments.TabIndex = 15;
            // 
            // StudentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 409);
            Controls.Add(panelRecentPayments);
            Controls.Add(linkLabel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lblUser);
            Controls.Add(btnAttendanceHistory);
            Controls.Add(btnQRCode);
            Controls.Add(btnPaynow);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentDashboardForm";
            Text = "DashboardForm";
            Load += StudentDashboardForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnHome;
        private Button button1;
        private FontAwesome.Sharp.IconButton btnPayment;
        private FontAwesome.Sharp.IconButton btnPaymentHistory;
        private FontAwesome.Sharp.IconButton btnQR;
        private FontAwesome.Sharp.IconButton btnAttendance;
        private Label lblUser;
        private Panel panel2;
        private Label lblBalance;
        private Label label1;
        private Label label3;
        private Panel panel3;
        private Label lblNextDue;
        private Label label6;
        private Panel panel4;
        private Label lblStatus;
        private Label label9;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnPaynow;
        private FontAwesome.Sharp.IconButton btnQRCode;
        private FontAwesome.Sharp.IconButton btnAttendanceHistory;
        private Label label4;
        private LinkLabel linkLabel2;
        private Panel panelRecentPayments;
    }
}