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

        }

        private void StudentDashboardForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Hello, " + Session.fullName + "!";
        }
    }
}
