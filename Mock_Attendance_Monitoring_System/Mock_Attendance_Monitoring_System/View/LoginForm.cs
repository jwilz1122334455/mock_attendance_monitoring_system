using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mock_Attendance_Monitoring_System.Viewmodel;

namespace Mock_Attendance_Monitoring_System.View
{
    public partial class LoginForm : Form
    {
        private System.Windows.Forms.Timer errorTimer;
        int attempt = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            btn_login.Enabled = false;

            string uname = txtuname.Text.Trim();
            string upassword = txtpword.Text.Trim();

            LoginViewModel loginViewModel = new LoginViewModel();
            bool isValid = loginViewModel.getAdmin(new Model.adminModel(uname, upassword));

            if (isValid)
            {
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access denied");
                txtuname.Text = "";
                txtpword.Text = "";

                attempt++;
                if (attempt >= 5)
                {
                    MessageBox.Show("Five failed attempts. Login disabled for 30 seconds.");
                    DisableLoginTemporarily();
                }
            }
        }

        private void DisableLoginTemporarily()
        {
            btn_login.Enabled = false;
            errorTimer = new System.Windows.Forms.Timer();
            errorTimer.Interval = 30000; // 30 seconds
            errorTimer.Tick += (s, e) =>
            {
                btn_login.Enabled = true;
                attempt = 0; // reset attempts
                errorTimer.Stop();
            };
            errorTimer.Start();
        }

        private void txtpword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
