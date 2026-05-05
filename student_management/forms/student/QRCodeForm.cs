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
            lblName.Text = Session.fullName;
            lblStudentNo.Text = Session.studentNumber;

            QRCodeGenerator qrGen = new QRCodeGenerator();
            QRCodeData qrData = qrGen.CreateQrCode(Session.studentNumber, QRCodeGenerator.ECCLevel.Q);
            QRCode qr = new QRCode(qrData);

            picQR.Image = qr.GetGraphic(8);
            picQR.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}