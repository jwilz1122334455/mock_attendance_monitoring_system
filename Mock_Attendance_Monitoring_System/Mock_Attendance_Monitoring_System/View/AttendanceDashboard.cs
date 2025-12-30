using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mock_Attendance_Monitoring_System.Model;
using Mock_Attendance_Monitoring_System.Viewmodel;

namespace Mock_Attendance_Monitoring_System.View
{
    public partial class AttendanceDashboard : Form
    {
        public AttendanceDashboard()
        {
            InitializeComponent();
        }

        private void btn_enterID_Click(object sender, EventArgs e)
        {
            AttendanceViewModel attendanceviewmodel = new AttendanceViewModel();
            string acc_num = txt_accNum.Text;

            if (attendanceviewmodel != null)
            {
                Attendance attendance = attendanceviewmodel.GetAttendanceInfo(acc_num);

                if (attendance != null)
                {
                    if (attendance.TimeIn == TimeSpan.Parse("00:00:00"))
                    {
                        attendanceviewmodel.UpdateTimeIn(acc_num);

                        txtTimeout.Text = "";
                        txtTimein.Text = DateTime.Now.ToString("HH:mm:ss");

                        lblname.Text = attendance.FirstName + " " + attendance.MiddleInitial + " " + attendance.LastName;
                        txtdepartment.Text = attendance.EmployeeDept;
                        txtposition.Text = attendance.EmployeePosition;
                        txtcivilstat.Text = attendance.CivilStatus;

                    }
                    else if (attendance.TimeOut == TimeSpan.Parse("00:00:00"))
                    {
                        attendanceviewmodel.UpdateTimeOut(acc_num);

                        attendance = attendanceviewmodel.GetAttendanceInfo(acc_num);
                        lblname.Text = attendance.FirstName + " " + attendance.MiddleInitial + " " + attendance.LastName;
                        txtdepartment.Text = attendance.EmployeeDept;
                        txtposition.Text = attendance.EmployeePosition;
                        txtcivilstat.Text= attendance.CivilStatus;

                        txtTimein.Text = attendance.TimeIn.ToString();
                        txtTimeout.Text = attendance.TimeOut.ToString();
                        attendanceviewmodel.InsertAttendanceHistory(attendance);
                    }
                    else
                    {
                        MessageBox.Show("You have already logged out");

                        lblname.Text = "";
                        txtdepartment.Text = "";
                        txtposition.Text = "";
                        txtTimein.Text = "";
                        txtTimeout.Text = "";
                        txtcivilstat.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Employee not found.");
                }

            }
            else
            {
                MessageBox.Show("Invalid Employee ID");
            }
        }

        private void DPTattendance_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = DPTattendance.Value.Date;
            int attendanceCount = 0;

            foreach (DataGridViewRow row in AttendanceTable.Rows)
            {
                if (row.Cells[8].Value != null && DateTime.TryParse(row.Cells[8].Value.ToString(), out DateTime rowDate))
                {
                    bool isVisible = rowDate.Date == selectedDate;
                    row.Visible = isVisible;

                    if (isVisible)
                    {
                        attendanceCount++;
                    }
                }
            }
        }

        private void AttendanceListLoad(object sender, EventArgs e)
        {
            loadAttendance();
        }

        private void loadAttendance()
        {
            AttendanceViewModel attendanceviewmodel = new AttendanceViewModel();

            List<Attendance> employees = attendanceviewmodel.GetEmployeeAttendance();

            AttendanceTable.Rows.Clear();

            foreach (var attendance in employees)
            {
                AttendanceTable.Rows.Add(
                    attendance.AccNum,
                    attendance.AccName,
                    attendance.EmployeeDept,
                    attendance.EmployeePosition,
                    attendance.CivilStatus,
                    attendance.TimeIn,
                    attendance.TimeOut,
                    attendance.Date.ToShortDateString()
                );
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MenuForm dashboard = new MenuForm();
            dashboard.Show();
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            AttendanceViewModel attendanceviewmodel = new AttendanceViewModel();
            attendanceviewmodel.ResetTimeInAndOut();
            MessageBox.Show("Time in and Time out values have been reset for all employees.");
        }
    }
}
