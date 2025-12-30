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

namespace Mock_Attendance_Monitoring_System.View
{
    public partial class Accountlist : Form
    {
        public Accountlist()
        {
            InitializeComponent();
        }

        private void AccountlistLoad(object sender, EventArgs e)
        {
            loadAttendance();
        }

        private void loadAttendance()
        {
            AttendanceViewModel attendanceViewModel = new AttendanceViewModel();

            List<Attendance> employees = attendanceViewModel.GetEmployees();

            dataGridView1.Rows.Clear();

            foreach (var attendance in employees)
            {
                dataGridView1.Rows.Add(
                    attendance.AccNum,
                    attendance.LastName,
                    attendance.FirstName,
                    attendance.MiddleInitial,
                    attendance.EmployeeDept,
                    attendance.EmployeePosition,
                    attendance.CivilStatus
                );
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MenuForm dashboard = new MenuForm();
            dashboard.Show();
            this.Close();
        }
    }
}
