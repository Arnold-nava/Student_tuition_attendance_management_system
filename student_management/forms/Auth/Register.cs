using crud;
using MySql.Data.MySqlClient;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNo.Text.Trim();
            string username = txtUser.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (studentNo == "" || username == "" || password == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                // 🔍 1. CHECK IF STUDENT EXISTS AND NOT REGISTERED
                string checkQuery = @"
            SELECT id FROM students 
            WHERE student_id = @student_id AND user_id IS NULL";

                MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.Connection);
                checkCmd.Parameters.AddWithValue("@student_id", studentNo);

                object result = checkCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Student number not found or already registered.");
                    return;
                }

                int studentDbId = Convert.ToInt32(result);

                // 🧾 2. INSERT INTO USERS TABLE
                string insertUserQuery = @"
            INSERT INTO users (username, password, role)
            VALUES (@username, @password, 'student')";

                MySqlCommand insertCmd = new MySqlCommand(insertUserQuery, db.Connection);
                insertCmd.Parameters.AddWithValue("@username", username);
                insertCmd.Parameters.AddWithValue("@password", password);

                insertCmd.ExecuteNonQuery();

                // 🆔 3. GET LAST INSERTED USER ID
                int userId = (int)insertCmd.LastInsertedId;

                // 🔗 4. LINK USER TO STUDENT
                string updateQuery = @"
            UPDATE students 
            SET user_id = @user_id 
            WHERE id = @student_id";

                MySqlCommand updateCmd = new MySqlCommand(updateQuery, db.Connection);
                updateCmd.Parameters.AddWithValue("@user_id", userId);
                updateCmd.Parameters.AddWithValue("@student_id", studentDbId);

                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Registration successful!");

                // clear fields
                txtStudentNo.Clear();
                txtUser.Clear();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }
    }
}
