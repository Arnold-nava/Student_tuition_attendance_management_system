using QRCoder;
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
using student_management.models;

namespace student_management.forms.student
{
    public partial class MyQRCodeForm : Form
    {
        public MyQRCodeForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyQRCodeForm_Load(object sender, EventArgs e)
        {
            string qrValue = Session.studentNumber; // student number like 05-123456

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrData = qrGenerator.CreateQrCode(qrValue, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrData);

            Bitmap qrImage = qrCode.GetGraphic(20);

            pictureBoxQR.Image = qrImage;
            lblStudentNumber.Text = qrValue;
        }
    }
}
