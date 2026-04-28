using crud;
using MySql.Data.MySqlClient;
using student_management.forms.Auth;
using student_management.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace student_management.forms.Admin
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminDashboardForm frm = new AdminDashboardForm();
            frm.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StudentManagementForm frm = new StudentManagementForm();
            frm.Show();
            this.Hide();
        }

        private void btnTuitionManagement_Click(object sender, EventArgs e)
        {
            TuitionManagementForm frm = new TuitionManagementForm();
            frm.Show();
            this.Hide();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            PaymentForm frm = new PaymentForm();
            frm.Show();
            this.Hide();
        }

        private void btnScanner_Click_1(object sender, EventArgs e)
        {
            QRCodeScannerForm frm = new QRCodeScannerForm();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Session.Clear();

            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }

        public void LoadTotalStudents()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT COUNT(*) FROM students";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                int total = Convert.ToInt32(cmd.ExecuteScalar());

                lblStudents.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        public void LoadTotalRevenue()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT IFNULL(SUM(amount_paid), 0) FROM payments WHERE status='Success'";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                decimal total = Convert.ToDecimal(cmd.ExecuteScalar());

                lblRevenue.Text = "₱" + total.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading revenue: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

  
        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadTotalStudents();
            LoadTotalRevenue();
       
        }
    }
}
