namespace student_management.forms.Auth
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            linkLabel1 = new LinkLabel();
            btnSignUp = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            txtConfirmPass = new TextBox();
            txtStudentNumber = new TextBox();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DodgerBlue;
            linkLabel1.Location = new Point(240, 459);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(105, 20);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Have Account!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.DodgerBlue;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = SystemColors.ControlText;
            btnSignUp.Location = new Point(184, 392);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(217, 46);
            btnSignUp.TabIndex = 19;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click_1;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(184, 326);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(216, 27);
            txtPassword.TabIndex = 17;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(185, 260);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(216, 27);
            txtUsername.TabIndex = 18;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(246, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(221, 171);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 15;
            label2.Text = "Sign up to Continue!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 134);
            label1.Name = "label1";
            label1.Size = new Size(122, 37);
            label1.TabIndex = 14;
            label1.Text = "Sign up!";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPass.Location = new Point(184, 359);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PlaceholderText = "Confirm Password";
            txtConfirmPass.Size = new Size(216, 27);
            txtConfirmPass.TabIndex = 21;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.BorderStyle = BorderStyle.FixedSingle;
            txtStudentNumber.Location = new Point(185, 227);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.PlaceholderText = "Student Number";
            txtStudentNumber.Size = new Size(216, 27);
            txtStudentNumber.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(184, 293);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email address";
            txtEmail.Size = new Size(216, 27);
            txtEmail.TabIndex = 18;
            txtEmail.TextChanged += txtUsername_TextChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 576);
            Controls.Add(txtConfirmPass);
            Controls.Add(linkLabel1);
            Controls.Add(btnSignUp);
            Controls.Add(txtPassword);
            Controls.Add(txtStudentNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button btnSignUp;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox txtConfirmPass;
        private TextBox txtStudentNumber;
        private TextBox txtEmail;
    }
}