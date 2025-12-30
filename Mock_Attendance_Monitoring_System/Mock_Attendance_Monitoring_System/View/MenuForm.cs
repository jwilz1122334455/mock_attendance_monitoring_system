using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mock_Attendance_Monitoring_System.View
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btn_attenddashboard_Click(object sender, EventArgs e)
        {
            AttendanceDashboard dashboard = new AttendanceDashboard();
            dashboard.Show();
        }

        private void btn_dataentry_Click(object sender, EventArgs e)
        {
            Data_entry dataentrywindow = new Data_entry();
            dataentrywindow.Show();
        }

        private void btn_accountlist_Click(object sender, EventArgs e)
        {
            Accountlist mlistdashboard = new Accountlist();
            mlistdashboard.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            LoginForm formhome = new LoginForm();
            formhome.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to log out of the system?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}