namespace student_management.forms.Admin
{
    partial class QRCodeScannerForm
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
            btnClear = new Button();
            lblSubMessage = new Label();
            lblMessage = new Label();
            panelResult = new Panel();
            panel3 = new Panel();
            lblStatus = new Label();
            lblStatusText = new Label();
            lblTimeIn = new Label();
            lblTimeInText = new Label();
            lblDate = new Label();
            lblDateText = new Label();
            lblStudentNo = new Label();
            lblCourseYear = new Label();
            lblName = new Label();
            cmbCamera = new ComboBox();
            btnStop = new Button();
            btnStart = new Button();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            pictureBoxCamera = new PictureBox();
            button1 = new Button();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            panelResult.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MistyRose;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Red;
            btnClear.Location = new Point(13, 451);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(297, 37);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear Record";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // lblSubMessage
            // 
            lblSubMessage.AutoSize = true;
            lblSubMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubMessage.ForeColor = Color.Gray;
            lblSubMessage.Location = new Point(71, 81);
            lblSubMessage.Name = "lblSubMessage";
            lblSubMessage.Size = new Size(174, 21);
            lblSubMessage.TabIndex = 10;
            lblSubMessage.Text = "Attendance Recorded";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.LimeGreen;
            lblMessage.Location = new Point(51, 49);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(214, 32);
            lblMessage.TabIndex = 9;
            lblMessage.Text = "Scann Successfull";
            // 
            // panelResult
            // 
            panelResult.BackColor = Color.Honeydew;
            panelResult.Controls.Add(panel3);
            panelResult.Controls.Add(btnClear);
            panelResult.Controls.Add(lblSubMessage);
            panelResult.Controls.Add(lblMessage);
            panelResult.Location = new Point(730, 13);
            panelResult.Margin = new Padding(3, 4, 3, 4);
            panelResult.Name = "panelResult";
            panelResult.Size = new Size(325, 506);
            panelResult.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MintCream;
            panel3.Controls.Add(lblStatus);
            panel3.Controls.Add(lblStatusText);
            panel3.Controls.Add(lblTimeIn);
            panel3.Controls.Add(lblTimeInText);
            panel3.Controls.Add(lblDate);
            panel3.Controls.Add(lblDateText);
            panel3.Controls.Add(lblStudentNo);
            panel3.Controls.Add(lblCourseYear);
            panel3.Controls.Add(lblName);
            panel3.Location = new Point(10, 147);
            panel3.Name = "panel3";
            panel3.Size = new Size(301, 290);
            panel3.TabIndex = 12;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.LimeGreen;
            lblStatus.Location = new Point(215, 252);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(57, 21);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "label1";
            // 
            // lblStatusText
            // 
            lblStatusText.AutoSize = true;
            lblStatusText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusText.ForeColor = Color.LimeGreen;
            lblStatusText.Location = new Point(12, 252);
            lblStatusText.Name = "lblStatusText";
            lblStatusText.Size = new Size(57, 21);
            lblStatusText.TabIndex = 9;
            lblStatusText.Text = "label1";
            // 
            // lblTimeIn
            // 
            lblTimeIn.AutoSize = true;
            lblTimeIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeIn.ForeColor = Color.LimeGreen;
            lblTimeIn.Location = new Point(215, 200);
            lblTimeIn.Name = "lblTimeIn";
            lblTimeIn.Size = new Size(57, 21);
            lblTimeIn.TabIndex = 9;
            lblTimeIn.Text = "label1";
            // 
            // lblTimeInText
            // 
            lblTimeInText.AutoSize = true;
            lblTimeInText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeInText.ForeColor = Color.LimeGreen;
            lblTimeInText.Location = new Point(12, 200);
            lblTimeInText.Name = "lblTimeInText";
            lblTimeInText.Size = new Size(57, 21);
            lblTimeInText.TabIndex = 9;
            lblTimeInText.Text = "label1";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.LimeGreen;
            lblDate.Location = new Point(215, 146);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(57, 21);
            lblDate.TabIndex = 9;
            lblDate.Text = "label1";
            // 
            // lblDateText
            // 
            lblDateText.AutoSize = true;
            lblDateText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateText.ForeColor = Color.LimeGreen;
            lblDateText.Location = new Point(12, 146);
            lblDateText.Name = "lblDateText";
            lblDateText.Size = new Size(57, 21);
            lblDateText.TabIndex = 9;
            lblDateText.Text = "label1";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentNo.ForeColor = Color.LimeGreen;
            lblStudentNo.Location = new Point(12, 75);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(57, 21);
            lblStudentNo.TabIndex = 9;
            lblStudentNo.Text = "label1";
            // 
            // lblCourseYear
            // 
            lblCourseYear.AutoSize = true;
            lblCourseYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourseYear.ForeColor = Color.LimeGreen;
            lblCourseYear.Location = new Point(12, 45);
            lblCourseYear.Name = "lblCourseYear";
            lblCourseYear.Size = new Size(57, 21);
            lblCourseYear.TabIndex = 9;
            lblCourseYear.Text = "label1";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.LimeGreen;
            lblName.Location = new Point(12, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(57, 21);
            lblName.TabIndex = 9;
            lblName.Text = "label1";
            // 
            // cmbCamera
            // 
            cmbCamera.FormattingEnabled = true;
            cmbCamera.Location = new Point(343, 445);
            cmbCamera.Name = "cmbCamera";
            cmbCamera.Size = new Size(163, 28);
            cmbCamera.TabIndex = 12;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.MistyRose;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStop.ForeColor = Color.Red;
            btnStop.Location = new Point(172, 438);
            btnStop.Margin = new Padding(3, 4, 3, 4);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(152, 40);
            btnStop.TabIndex = 11;
            btnStop.Text = "Stop Camera";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Honeydew;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.LimeGreen;
            btnStart.Location = new Point(13, 438);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(152, 40);
            btnStart.TabIndex = 11;
            btnStart.Text = "Start Camera";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 261);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 3);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 6;
            label3.Text = "Camera Preview";
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbCamera);
            panel2.Controls.Add(btnStop);
            panel2.Controls.Add(btnStart);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBoxCamera);
            panel2.Location = new Point(176, 14);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(525, 505);
            panel2.TabIndex = 9;
            // 
            // pictureBoxCamera
            // 
            pictureBoxCamera.BackColor = Color.Black;
            pictureBoxCamera.Location = new Point(16, 48);
            pictureBoxCamera.Margin = new Padding(3, 4, 3, 4);
            pictureBoxCamera.Name = "pictureBoxCamera";
            pictureBoxCamera.Size = new Size(493, 371);
            pictureBoxCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCamera.TabIndex = 0;
            pictureBoxCamera.TabStop = false;
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
            iconButton4.Location = new Point(17, 335);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(135, 77);
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
            iconButton2.Location = new Point(17, 181);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(135, 77);
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
            iconButton3.Location = new Point(17, 252);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(135, 77);
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
            iconButton1.Location = new Point(17, 99);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(135, 77);
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
            btnHome.Location = new Point(17, 16);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(135, 77);
            btnHome.TabIndex = 1;
            btnHome.Text = "dashboard";
            btnHome.TextAlign = ContentAlignment.MiddleRight;
            btnHome.UseVisualStyleBackColor = true;
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
            panel1.Location = new Point(-15, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 552);
            panel1.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // QRCodeScannerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 549);
            Controls.Add(panelResult);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "QRCodeScannerForm";
            Text = "QRCodeScannerForm";
            FormClosing += QRCodeScannerForm_FormClosing;
            Load += QRCodeScannerForm_Load;
            panelResult.ResumeLayout(false);
            panelResult.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnClear;
        private Label lblSubMessage;
        private Label lblMessage;
        private Panel panelResult;
        private ComboBox cmbCamera;
        private Button btnStop;
        private Button btnStart;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private PictureBox pictureBoxCamera;
        private Button button1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private ErrorProvider errorProvider1;
        private Panel panel3;
        private Label lblStudentNo;
        private Label lblCourseYear;
        private Label lblName;
        private Label lblStatus;
        private Label lblStatusText;
        private Label lblTimeIn;
        private Label lblTimeInText;
        private Label lblDate;
        private Label lblDateText;
    }
}