namespace student_management.forms.student
{
    partial class MyQRCodeForm
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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Location = new Point(1, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(93, 412);
            panel1.TabIndex = 2;
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
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(131, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 245);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 193);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 2);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 6;
            label1.Text = "Camera Preview";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 196);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            // 
            // MyQRCodeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 412);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MyQRCodeForm";
            Text = "MyQRCodeForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private FontAwesome.Sharp.IconButton btnPayment;
        private FontAwesome.Sharp.IconButton btnPaymentHistory;
        private FontAwesome.Sharp.IconButton btnQR;
        private FontAwesome.Sharp.IconButton btnAttendance;
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}