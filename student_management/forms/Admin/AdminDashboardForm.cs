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

        public void LoadRecentPayments()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                // HELPED BY A.I
                string query = @"
                SELECT 
                s.student_number AS Student_No,
                CONCAT(s.first_name, ' ', s.last_name) AS Student,
                p.amount_paid AS Amount,
                p.payment_method AS Method,
                p.status AS Status,
                    p.paid_at AS Date_Paid
                FROM payments p
                INNER JOIN students s ON p.student_id = s.id
                ORDER BY p.paid_at DESC
                LIMIT 10";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.Connection);
                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvRecentPayments.DataSource = table;

                dgvRecentPayments.Height = dgvRecentPayments.ColumnHeadersHeight;

                foreach (DataGridViewRow row in dgvRecentPayments.Rows)
                {
                    dgvRecentPayments.Height += row.Height;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message);
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
            LoadRecentPayments();
       
        }
    }
}
