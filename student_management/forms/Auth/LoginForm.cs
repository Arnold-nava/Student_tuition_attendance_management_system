using crud;
using MySql.Data.MySqlClient;
using student_management.forms.Admin;
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

namespace student_management.forms.Auth
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Enter Username or Password", "Error!");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT * FROM users WHERE username=@username AND password=@password";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    User u = new User();

                    u.id = Convert.ToInt32(reader["id"]);
                    u.user = reader["username"].ToString();
                    u.password = reader["password"].ToString();
                    u.role = reader["role"].ToString();

                    Session.userId = u.id;

                    MessageBox.Show("Welcome " + u.user);

                    if (u.role == "Admin")
                    {
                        AdminDashboardForm admin = new AdminDashboardForm();
                        admin.Show();
                        this.Hide();
                    }
                    else if (u.role == "Student")
                    {
                        GetStudentInfo();
                        StudentDashboardForm student = new StudentDashboardForm();
                        student.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }

                reader.Close();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm frm = new ForgotPasswordForm();
            frm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QRScannerForm frm = new QRScannerForm();
            frm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
