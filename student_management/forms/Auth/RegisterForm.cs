using crud;
using MySql.Data.MySqlClient;
using student_management.models;
using student_management.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace student_management.forms.Auth
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        // PANG KUHA NG SESSION
        // PANG KUHA NG SESSION
        public void GetStudentInfo()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT * FROM students WHERE user_id=@user_id";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@user_id", Session.userId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Session.studentId = Convert.ToInt32(reader["id"]);
                    Session.fullName = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                    Session.course = reader["course"].ToString();
                    Session.semester = reader["semester"].ToString();
                    Session.year = reader["year_level"].ToString();
                    Session.section = reader["section"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student info: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            string studenNum = txtStudentNumber.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPass = txtConfirmPass.Text.Trim();
            string role = "Student";

            if (string.IsNullOrEmpty(studenNum) || 
                string.IsNullOrEmpty(username) || 
                string.IsNullOrEmpty(email)||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPass)) 
            {
                MessageBox.Show("Fill up all fields to continue!", "Error!");
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("Enter valid email!", "error!");
                return;
            }

            if (password != confirmPass)
            {
                MessageBox.Show("Password missmatch!", "error!");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                
                string checkStudent = "SELECT * FROM students WHERE student_number=@student_number";

                MySqlCommand checkCmd = new MySqlCommand(checkStudent, db.Connection);
                checkCmd.Parameters.AddWithValue("@student_number", studenNum);

                MySqlDataReader reader = checkCmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Student number not found. You are not registered in school.");
                    reader.Close();
                    return;
                }

                int studentId = Convert.ToInt32(reader["id"]);
                object userId = reader["user_id"];

                // Got helped by A.I//
                if (userId != DBNull.Value)
                {
                    MessageBox.Show("This student already has an account.");
                    reader.Close();
                    return;
                }

                reader.Close();//

                string checkUsername = "SELECT COUNT(*) FROM users WHERE username=@username";

                MySqlCommand userCmd = new MySqlCommand(checkUsername, db.Connection);
                userCmd.Parameters.AddWithValue("@username", username);

                int count = Convert.ToInt32(userCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Username already exists.");
                    return;
                }

                // 3. Insert account
                string insertUser = @"INSERT INTO users (username, password, email, role)
                          VALUES (@username, @password, @email, @role)";

                MySqlCommand insertCmd = new MySqlCommand(insertUser, db.Connection);
                insertCmd.Parameters.AddWithValue("@username", username);
                insertCmd.Parameters.AddWithValue("@password", password);
                insertCmd.Parameters.AddWithValue("@email", email);
                insertCmd.Parameters.AddWithValue("@role", role);

                insertCmd.ExecuteNonQuery();

                int newUserId = Convert.ToInt32(insertCmd.LastInsertedId);

                Session.userId = newUserId;
                Session.username = username;
                Session.role = role;

                string updateStudent = "UPDATE students SET user_id=@user_id WHERE id=@student_id";

                MySqlCommand updateCmd = new MySqlCommand(updateStudent, db.Connection);
                updateCmd.Parameters.AddWithValue("@user_id", newUserId);
                updateCmd.Parameters.AddWithValue("@student_id", studentId);

                updateCmd.ExecuteNonQuery();

                GetStudentInfo();

                MessageBox.Show("Registration successful!");

                StudentDashboardForm frm = new StudentDashboardForm();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }
        }
    }
}
