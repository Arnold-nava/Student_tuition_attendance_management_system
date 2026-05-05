using crud;
using MySql.Data.MySqlClient;
using System;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}