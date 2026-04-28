namespace student_management.forms.student
{
    partial class PaymentSuccessForm
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
            panel1.SuspendLayout();
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
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(106, 550);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(17, 509);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
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
            btnPayment.Location = new Point(17, 98);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(75, 77);
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
            btnPaymentHistory.Location = new Point(17, 347);
            btnPaymentHistory.Name = "btnPaymentHistory";
            btnPaymentHistory.Size = new Size(75, 77);
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
            btnQR.Location = new Point(17, 264);
            btnQR.Name = "btnQR";
            btnQR.Size = new Size(75, 77);
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
            btnAttendance.Location = new Point(17, 181);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(75, 77);
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
            btnHome.Location = new Point(17, 15);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 77);
            btnHome.TabIndex = 1;
            btnHome.UseVisualStyleBackColor = true;
            // 
            // PaymentSuccessForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 547);
            Controls.Add(panel1);
            Name = "PaymentSuccessForm";
            Text = "PaymentSuccess";
            panel1.ResumeLayout(false);
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
    }
}