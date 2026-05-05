using System;
using System.Windows.Forms;
using crud;
using MySql.Data.MySqlClient;
using student_management.Helpers;

namespace student_management.forms.student
{
    public partial class StudentDashBoardForm : Form
    {
        public StudentDashBoardForm()
        {
            InitializeComponent();
        }

        private void StudentDashBoardForm_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        // 🔥 LOAD DASHBOARD DATA
        private void LoadDashboard()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT 
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
                    lblTodayClass.Text = reader["class_name"].ToString();

                    lblStatus.Text = reader["status"] == DBNull.Value
                        ? "Not Yet Scanned"
                        : reader["status"].ToString();

                    lblTimeIn.Text = reader["time_in"] == DBNull.Value
                        ? "--"
                        : reader["time_in"].ToString();

                    lblTimeOut.Text = reader["time_out"] == DBNull.Value
                        ? "--"
                        : reader["time_out"].ToString();
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

        // 🏠 DASHBOARD BUTTON (reload itself)
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            StudentDashBoardForm frm = new StudentDashBoardForm();
            frm.Show();
            this.Close();
        }

        // 📷 QR
        private void btnMyQR_Click(object sender, EventArgs e)
        {
            QRCodeForm frm = new QRCodeForm();
            frm.Show();
            this.Close();
        }

        // 📊 ATTENDANCE
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AttendanceHistoryForm frm = new AttendanceHistoryForm();
            frm.Show();
            this.Close();
        }

        // 👤 PROFILE
        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm frm = new ProfileForm();
            frm.Show();
            this.Close();
        }

        // 🚪 LOGOUT
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            new student_management.forms.Auth.Login().Show();
            this.Close();
        }
    }
}