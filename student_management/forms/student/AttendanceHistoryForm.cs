using crud;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using student_management.Helpers;

namespace student_management.forms.student
{
    public partial class AttendanceHistoryForm : Form
    {
        public AttendanceHistoryForm()
        {
            InitializeComponent();
        }

        private void AttendanceHistoryForm_Load(object sender, EventArgs e)
        {
            LoadAttendance();
        }

        private void LoadAttendance()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT 
                        a.attendance_date AS Date,
                        sub.subject_name AS Subject,
                        a.time_in AS TimeIn,
                        a.time_out AS TimeOut,
                        a.status AS Status
                    FROM attendance a
                    JOIN subjects sub ON a.subject_id = sub.id
                    WHERE a.student_id = @student_id
                    ORDER BY a.attendance_date DESC";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@student_id", Session.studentId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAttendance.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Attendance Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            StudentDashBoardForm frm = new StudentDashBoardForm();
            frm.Show();
            this.Close();
        }

        private void btnMyQR_Click(object sender, EventArgs e)
        {
            QRCodeForm frm = new QRCodeForm();
            frm.Show();
            this.Close();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AttendanceHistoryForm frm = new AttendanceHistoryForm();
            frm.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm frm = new ProfileForm();
            frm.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            new Auth.Login().Show();
            this.Close();
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {
            int radius = 25;

            GraphicsPath path = new GraphicsPath();

            path.AddLine(0, 0, panelSidebar.Width - radius, 0);
            path.AddArc(panelSidebar.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panelSidebar.Width - radius, panelSidebar.Height - radius, radius, radius, 0, 90);
            path.AddLine(0, panelSidebar.Height, 0, 0);

            path.CloseFigure();

            panelSidebar.Region = new System.Drawing.Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDashBoardForm frm = new StudentDashBoardForm();
            frm.Show();
            this.Close();
        }
    }
}