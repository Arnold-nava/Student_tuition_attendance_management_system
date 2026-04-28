using crud;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using student_management.forms.Admin;
using student_management.forms.Auth;
using student_management.forms.student;
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

namespace student_management.forms
{
    public partial class StudentDashboardForm : Form
    {
        public StudentDashboardForm()
        {
            InitializeComponent();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            TuitionManagementForm frm = new TuitionManagementForm();
            frm.Show();
            this.Hide();
        }



        public void LoadTuitionInfo()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT * FROM tuition WHERE student_id=@student_id ORDER BY id DESC LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@student_id", Session.studentId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    decimal balance = Convert.ToDecimal(reader["balance"]);
                    string status = reader["status"].ToString();

                    lblBalance.Text = "₱" + balance.ToString("N2");
                    lblStatus.Text = status;
                }
                else
                {
                    lblBalance.Text = "₱0.00";
                    lblStatus.Text = "No Tuition";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tuition: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        // Helped by A.I
        public void LoadNextDue()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                                SELECT *
                                FROM installments i
                                INNER JOIN tuition t ON i.tuition_id = t.id
                                WHERE t.student_id=@student_id
                                AND i.status='Unpaid'
                                ORDER BY i.due_date ASC
                                LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@student_id", Session.studentId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DateTime due = Convert.ToDateTime(reader["due_date"]);
                    lblNextDue.Text = due.ToString("MMM dd, yyyy");
                }
                else
                {
                    lblNextDue.Text = "No due";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading due date: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        public void LoadRecentPayments()
        {
            panelRecentPayments.Controls.Clear();

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
            SELECT 
                i.month_name,
                p.amount_paid,
                p.status,
                p.paid_at
            FROM payments p
            INNER JOIN installments i ON p.installment_id = i.id
            WHERE p.student_id = @student_id
            ORDER BY p.paid_at DESC
            LIMIT 5";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@student_id", Session.studentId);

                MySqlDataReader reader = cmd.ExecuteReader();

                int y = 0;

                // HELPED BY A.I
                while (reader.Read())
                {
                    Panel row = new Panel();
                    row.Width = panelRecentPayments.Width - 10;
                    row.Height = 35;
                    row.Left = 0;
                    row.Top = y;

                    Label lblMonth = new Label();
                    lblMonth.Text = reader["month_name"].ToString();
                    lblMonth.Left = 10;
                    lblMonth.Top = 8;
                    lblMonth.Width = 100;

                    Label lblAmount = new Label();
                    decimal amount = Convert.ToDecimal(reader["amount_paid"]);
                    lblAmount.Text = "₱" + amount.ToString("N2");
                    lblAmount.Left = 130;
                    lblAmount.Top = 8;
                    lblAmount.Width = 100;

                    Label lblStatus = new Label();
                    lblStatus.Text = reader["status"].ToString();
                    lblStatus.Left = 250;
                    lblStatus.Top = 8;
                    lblStatus.Width = 80;

                    if (lblStatus.Text == "Success")
                    {
                        lblStatus.ForeColor = Color.Green;
                    }

                    Label lblDate = new Label();
                    DateTime paidDate = Convert.ToDateTime(reader["paid_at"]);
                    lblDate.Text = paidDate.ToString("MMM dd, yyyy");
                    lblDate.Left = 350;
                    lblDate.Top = 8;
                    lblDate.Width = 120;

                    row.Controls.Add(lblMonth);
                    row.Controls.Add(lblAmount);
                    row.Controls.Add(lblStatus);
                    row.Controls.Add(lblDate);

                    panelRecentPayments.Controls.Add(row);

                    y = y + 40;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recent payments: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void StudentDashboardForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Hello, " + Session.fullName + "! 👋";

            LoadTuitionInfo();
            LoadNextDue();
            LoadRecentPayments();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            AttendanceHistoryForm frm = new AttendanceHistoryForm();
            frm.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            StudentDashboardForm frm = new StudentDashboardForm();
            frm.Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            TuitionForm frm = new TuitionForm();
            frm.Show();
            this.Hide();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AttendanceHistoryForm frm = new AttendanceHistoryForm();
            frm.Show();
            this.Hide();
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            MyQRCodeForm frm = new MyQRCodeForm();
            frm.Show();
            this.Hide();
        }

        private void btnPaynow_Click(object sender, EventArgs e)
        {
            TuitionForm frm = new TuitionForm();
            frm.Show();
            this.Hide();
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            MyQRCodeForm frm = new MyQRCodeForm();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TuitionManagementForm frm = new TuitionManagementForm();
            frm.Show();
            this.Hide();
        }
    }
}
