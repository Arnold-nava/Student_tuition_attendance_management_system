using student_management.forms.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using student_management.Helpers;

namespace student_management.forms.Admin
{
    public partial class AttendanceHistoryForm : Form
    {
        public AttendanceHistoryForm()
        {
            InitializeComponent();
        }

        private void btnDaashboard_Click(object sender, EventArgs e)
        {
            TeacherDashBoard frm = new TeacherDashBoard();
            frm.Show();
            this.Hide();
        }

        private void btnScanner_Click(object sender, EventArgs e)
        {
            QRScannerForm frm = new QRScannerForm();
            frm.Show();
            this.Hide();
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            StudentManagementForm frm = new StudentManagementForm();
            frm.Show();
            this.Hide();
        }

        private void btnAttendanceRecords_Click(object sender, EventArgs e)
        {
            AttendanceHistoryForm frm = new AttendanceHistoryForm();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AttendanceHistoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
