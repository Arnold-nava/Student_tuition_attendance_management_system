using crud;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using student_management.Helpers;

namespace student_management.forms.student
{
    public partial class StudentDashBoard : Form
    {
        public StudentDashBoard()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            QRCodeForm frm = new QRCodeForm();
            frm.ShowDialog();
        }
        private void StudentDashBoard_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT 
                        s.full_name,
                        s.student_id,
                        c.class_name,
                        a.status,
                        a.time_in,
                        a.time_out
                    FROM students s
                    JOIN classes c ON s.class_id = c.id
                    LEFT JOIN attendance a 
                        ON a.student_id = s.id
                        AND a.attendance_date = CURDATE()
                    WHERE s.user_id = @user_id";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@user_id", Session.userId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblStatus.Text = reader["status"] == DBNull.Value ? "Not Yet Scanned" : reader["status"].ToString();
                    lblTimeIn.Text = reader["time_in"] == DBNull.Value ? "--" : reader["time_in"].ToString();
                    lblTimeOut.Text = reader["time_out"] == DBNull.Value ? "--" : reader["time_out"].ToString();
                    lblTodayClass.Text = reader["class_name"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.userId = 0;
            Session.username = "";
            Session.role = "";

            this.Hide();
            new Auth.Login().Show();
        }
    }
}