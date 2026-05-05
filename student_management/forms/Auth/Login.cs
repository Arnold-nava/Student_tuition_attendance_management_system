using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crud;
using MySql.Data.MySqlClient;
using student_management.forms.Admin;
using student_management.forms.student;
using student_management.Helpers;

namespace student_management.forms.Auth
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter both username and password.", "Error");
                return;
            }

            DBConnect db  = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT * FROM users WHERE username = @username AND password = @password";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@password", pass);


                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["role"].ToString();
                    int userId = Convert.ToInt32(reader["id"]);

                    Session.userId = userId;
                    Session.username = reader["username"].ToString();
                    Session.role = role;

                    MessageBox.Show("Login successful!");

                    reader.Close();

                    if (role == "teacher")
                    {
                        TeacherDashBoard frm = new TeacherDashBoard();
                        frm.Show();
                        this.Hide();
                    }
                    else if (role == "student")
                    {
                        StudentDashBoard frm = new StudentDashBoard();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.",
                        "Login Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error");
            }
            finally
            {
                db.Close();
            }   
        }
    }
}
