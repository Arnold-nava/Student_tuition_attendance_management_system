using crud;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using student_management.Helpers;

namespace student_management.forms.student
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void LoadProfile()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT 
                        s.full_name,
                        s.student_id,
                        s.email,
                        s.status,
                        c.class_name
                    FROM students s
                    JOIN classes c ON s.class_id = c.id
                    WHERE s.id = @student_id";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@student_id", Session.studentId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblName.Text = reader["full_name"].ToString();
                    lblStudentNo.Text = reader["student_id"].ToString();
                    lblEmail.Text = reader["email"].ToString();
                    lblClass.Text = reader["class_name"].ToString();
                    lblStatus.Text = reader["status"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}