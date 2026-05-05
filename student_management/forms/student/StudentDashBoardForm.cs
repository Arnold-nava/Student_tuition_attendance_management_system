using System;
using System.Windows.Forms;
using crud;
using MySql.Data.MySqlClient;
using student_management.Helpers;
using System.Drawing.Drawing2D;

namespace student_management.forms.student
{

    public partial class StudentDashBoardForm : Form
    {
        public StudentDashBoardForm()
        {
            InitializeComponent();
        }

        private void RoundControl(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();
            control.Region = new Region(path);
        }

        private void StudentDashBoardForm_Load(object sender, EventArgs e)
        {
            LoadDashboard();
            RoundControl(panelSidebar, 25);

            RoundControl(btnDashboard, 15);
            RoundControl(btnMyQR, 15);
            RoundControl(btnAttendance, 15);
            RoundControl(btnProfile, 15);
            RoundControl(btnLogout, 15);

            RoundControl(panelStatus, 15);
            RoundControl(panelPresent, 15);
            RoundControl(panelAbsent, 15);
            RoundControl(panelLate, 15);
            RoundControl(panelPending, 15);
            RoundControl(panelTodayClass, 15);

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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}