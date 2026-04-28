using AForge.Video;
using AForge.Video.DirectShow;
using crud;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.Windows.Compatibility;

namespace student_management.forms.Admin
{
    public partial class QRScannerForm : Form
    {
        // 🔥 GLOBAL VARIABLES (IMPORTANT)
        FilterInfoCollection cameras;
        VideoCaptureDevice camera;
        bool scanned = false;

        public QRScannerForm()
        {
            InitializeComponent();
        }

        // 🔥 FORM LOAD
        private void QRScannerForm_Load(object sender, EventArgs e)
        {
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (cameras.Count == 0)
            {
                MessageBox.Show("No camera found.");
            }
        }

        // 🔥 START CAMERA
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cameras.Count == 0)
            {
                MessageBox.Show("No camera available.");
                return;
            }

            scanned = false;

            camera = new VideoCaptureDevice(cameras[0].MonikerString);
            camera.NewFrame += Camera_NewFrame;
            camera.Start();
        }

        // 🔥 CAMERA FRAME + QR SCAN
        private void Camera_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            this.Invoke(new Action(() =>
            {
                pictureBoxCamera.Image = bitmap;
            }));

            if (!scanned)
            {
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(bitmap);

                if (result != null)
                {
                    scanned = true;
                    string qrValue = result.Text;

                    this.Invoke(new Action(() =>
                    {
                        StopCamera();
                        RecordAttendance(qrValue);
                    }));
                }
            }
        }

        // 🔥 STOP BUTTON
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopCamera();
        }

        // 🔥 STOP CAMERA FUNCTION
        public void StopCamera()
        {
            if (camera != null && camera.IsRunning)
            {
                camera.SignalToStop();
            }
        }

        // 🔥 RECORD ATTENDANCE + SHOW RESULT
        public void RecordAttendance(string qrValue)
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT * FROM students WHERE qr_code_value=@qr";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@qr", qrValue);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Student not found.");
                    reader.Close();
                    return;
                }

                string fullName = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                string studentNo = reader["student_number"].ToString();
                string courseYear = reader["course"].ToString() + " - " + reader["year_level"].ToString();

                reader.Close();

                // 🔥 DISPLAY RESULT
                lblName.Text = fullName;
                lblStudentNo.Text = studentNo;
                lblCourseYear.Text = courseYear;
                lblDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
                lblTimeIn.Text = DateTime.Now.ToString("hh:mm tt");
                lblStatus.Text = "Present";
                lblMessage.Text = "Scan Successful!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        // 🔥 STOP CAMERA WHEN FORM CLOSE
        private void QRScannerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }
    }
}