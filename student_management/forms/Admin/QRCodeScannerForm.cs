using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using crud;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ZXing;
using ZXing.Aztec;
using ZXing.Windows.Compatibility;

namespace student_management.forms.Admin
{
    public partial class QRCodeScannerForm : Form
    {
        bool scan = false;
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public QRCodeScannerForm()
        {
            InitializeComponent();
        }

        private void QRCodeScannerForm_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                cmbCamera.Items.Add(Device.Name);
            cmbCamera.SelectedIndex = 0;

            FinalFrame = new VideoCaptureDevice();

            timer1.Interval = 500;
            timer1.Enabled = false;

            lblMessage.Text = "";
            lblSubMessage.Text = "";
            lblName.Text = "";
            lblStudentNo.Text = "";
            lblCourseYear.Text = "";
            lblDate.Text = "";
            lblTimeIn.Text = "";
            lblStatus.Text = "";

            // keep these visible
            lblDateText.Text = "Date:";
            lblTimeInText.Text = "Time In:";
            lblStatusText.Text = "Status:";

            scan = false;
        }

        public void StopCamera()
        {
            timer1.Stop();

            if (FinalFrame != null && FinalFrame.IsRunning)
            {
                FinalFrame.NewFrame -= FinalFrame_NewFrame;
                FinalFrame.SignalToStop();
                FinalFrame.WaitForStop();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StopCamera();
            scan = false;

            FinalFrame = new VideoCaptureDevice
                (CaptureDevice[cmbCamera.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();



            timer1.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QRCodeScannerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();

            if (FinalFrame != null && FinalFrame.IsRunning)
            {
                FinalFrame.SignalToStop();
                FinalFrame.WaitForStop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxCamera.Image == null || scan == true)
            {
                return;
            }

            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)pictureBoxCamera.Image);

            if (result != null)
            {
                scan = true;

                string qrValue = result.Text;

                GetStudentFromQR(qrValue);

                // wait 2 seconds before allowing next scan
                // HELPED BY A.I
                System.Windows.Forms.Timer delay = new System.Windows.Forms.Timer();
                delay.Interval = 2000;

                delay.Tick += (s, ev) =>
                {
                    scan = false;

                    

                    delay.Stop();
                    delay.Dispose();

                    clear();
                };

                delay.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopCamera();
            pictureBoxCamera.Image = null;

            MessageBox.Show("Camera stopped");
        }

        private void clear()
        {
            System.Windows.Forms.Timer delay = new System.Windows.Forms.Timer();

            delay.Interval = 2000;

            lblMessage.Text = "";
            lblSubMessage.Text = "";
            lblName.Text = "";
            lblStudentNo.Text = "";
            lblCourseYear.Text = "";
            lblDate.Text = "";
            lblTimeIn.Text = "";
            lblStatus.Text = "";

            // keep these visible
            lblDateText.Text = "Date:";
            lblTimeInText.Text = "Time In:";
            lblStatusText.Text = "Status:";

            scan = false;
        }

        public void ShowResult(string name, string studentNo, string courseYear)
        {

            lblMessage.Text = "Scan Successful!";
            lblSubMessage.Text = "Attendance recorded.";

            lblName.Text = name;
            lblStudentNo.Text = "" + studentNo;
            lblCourseYear.Text = "" + courseYear;

            lblDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
            lblTimeIn.Text = DateTime.Now.ToString("hh:mm tt");
            lblStatus.Text = "Present";

            lblStatus.ForeColor = Color.Green;
        }

        public void GetStudentFromQR(string qrValue)
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

                int studentId = Convert.ToInt32(reader["id"]);
                string fullName = reader["first_name"] + " " + reader["last_name"];
                string studentNo = reader["student_number"].ToString();
                string courseYear = reader["course"] + " - " + reader["year_level"];

                reader.Close();

                string checkQuery = @"
                                    SELECT COUNT(*) 
                                    FROM attendance_logs 
                                    WHERE student_id=@student_id 
                                    AND attendance_date=CURDATE()";

                MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.Connection);
                checkCmd.Parameters.AddWithValue("@student_id", studentId);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Already scanned today!");
                    return;
                }

               
                string insertQuery = @"
                                    INSERT INTO attendance_logs (student_id, attendance_date, time_in)
                                    VALUES (@student_id, CURDATE(), CURTIME())";

                MySqlCommand insertCmd = new MySqlCommand(insertQuery, db.Connection);
                insertCmd.Parameters.AddWithValue("@student_id", studentId);
                insertCmd.ExecuteNonQuery();

                ShowResult(fullName, studentNo, courseYear);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }
        }
    }
}