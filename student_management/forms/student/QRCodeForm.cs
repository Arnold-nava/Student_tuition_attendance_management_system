using QRCoder;
using System;
using System.Drawing;
using System.Windows.Forms;
using student_management.Helpers;

namespace student_management.forms.student
{
    public partial class QRCodeForm : Form
    {
        public QRCodeForm()
        {
            InitializeComponent();
        }

        private void QRCodeForm_Load(object sender, EventArgs e)
        {
            // 🔥 Set student info
            lblName.Text = Session.fullName;
            lblStudentNo.Text = Session.studentNumber;

            // 🔥 Generate QR
            QRCodeGenerator qrGen = new QRCodeGenerator();
            QRCodeData qrData = qrGen.CreateQrCode(Session.studentNumber, QRCodeGenerator.ECCLevel.Q);
            QRCode qr = new QRCode(qrData);

            picQR.Image = qr.GetGraphic(8);
            picQR.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // 🏠 DASHBOARD
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new StudentDashBoardForm().Show(); // ✅ FIXED NAME
            this.Close();
        }

        // 📷 MY QR (CURRENT PAGE)
        private void btnMyQR_Click(object sender, EventArgs e)
        {
            // do nothing (already here)
        }

        // 📊 ATTENDANCE
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            new AttendanceHistoryForm().Show();
            this.Close();
        }

        // 👤 PROFILE
        private void btnProfile_Click(object sender, EventArgs e)
        {
            new ProfileForm().Show();
            this.Close();
        }

        // 🚪 LOGOUT
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            new student_management.forms.Auth.Login().Show();
            this.Close();
        }

        // 🔙 BACK (optional)
        private void btnBack_Click(object sender, EventArgs e)
        {
            new StudentDashBoardForm().Show();
            this.Close();
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}