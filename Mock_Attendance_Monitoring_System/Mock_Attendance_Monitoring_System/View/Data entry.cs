using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mock_Attendance_Monitoring_System.Model;
using Mock_Attendance_Monitoring_System.Viewmodel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Mock_Attendance_Monitoring_System.View
{
    public partial class Data_entry : Form
    {
        public Data_entry()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string lastName = txtlastname.Text;
            string firstName = txtfirstname.Text;
            string midinitial = txtmidinitial.Text;
            string employeeDept = cmbdept.Text;
            string employeePosition = cmbposition.Text;
            string civilStatus = cmb_civilstat.Text;

            if (txtlastname.Text.Trim() == "" || txtfirstname.Text.Trim() == "" || txtmidinitial.Text.Trim() == "" || cmbdept.Text.Trim() == "" || cmbposition.Text.Trim() == "" || cmb_civilstat.Text.Trim() == "")
            {
                MessageBox.Show("Input all fields.", "Add data entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AttendanceViewModel attendanceViewModel = new AttendanceViewModel();
                bool attendance = attendanceViewModel.DataEntry(lastName,firstName,midinitial,employeeDept,employeePosition,civilStatus);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MenuForm dashboard = new MenuForm();
            dashboard.Show();
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtlastname.Text = string.Empty;
            txtfirstname.Text = string.Empty;
            txtmidinitial.Text = string.Empty;
            cmbdept.Text = string.Empty;
            cmbposition.Text = string.Empty;
            cmb_civilstat.Text = string.Empty;
        }
    }
}
