using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mock_Attendance_Monitoring_System.Model;

namespace Mock_Attendance_Monitoring_System.Viewmodel
{
    internal class AttendanceViewModel
    {
        string connectionstring = @"Server=localhost;Port=3306;Database=db_attendance1;Uid=root;SslMode=none";

        public Attendance GetAttendanceInfo(string accNo)
        {
            Attendance attendance = null;

            try
            {
                string query = $"SELECT * FROM tbl_accountlist WHERE acc_num = '{accNo}'";

                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int acc_num = reader.GetInt32("acc_num");
                            string firstName = reader.GetString("first_name");
                            string midInitial = reader.GetString("mid_initial");
                            string lastName = reader.GetString("last_name");
                            string employeeDept = reader.GetString("empl_dept");
                            string employeePosition = reader.GetString("empl_position");
                            string civilStatus = reader.GetString("civil_status");
                            TimeSpan timeIn = TimeSpan.Parse(reader.GetString("timelogin"));
                            TimeSpan timeOut = TimeSpan.Parse(reader.GetString("timelogout"));

                            attendance = new Attendance(acc_num, firstName, midInitial, lastName, employeeDept, employeePosition, civilStatus, timeIn, timeOut);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the attendance information. " + ex.Message);
            }

            return attendance;
        }

        public void UpdateTimeIn(string accNo)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    connection.Open();

                    string query = "UPDATE tbl_accountlist SET timelogin = @TimeIn WHERE acc_num = @acc_num";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TimeIn", DateTime.Now.ToString("HH:mm:ss"));
                    command.Parameters.AddWithValue("@acc_num", accNo);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the \"time in\"." + ex.Message);
            }
        }

        public void UpdateTimeOut(string accNo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                string query = "UPDATE tbl_accountlist SET timelogout = @TimeOut WHERE acc_num = @acc_num";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@TimeOut", DateTime.Now.ToString("HH:mm:ss"));
                command.Parameters.AddWithValue("@acc_num", accNo);
                command.ExecuteNonQuery();
            }
        }

        public void InsertAttendanceHistory(Attendance attendance)
        {
            int acc_num = attendance.AccNum;
            string acc_name = attendance.FirstName + " " + attendance.MiddleInitial + " " + attendance.LastName;
            string employeeDept = attendance.EmployeeDept;
            string employeePosition = attendance.EmployeePosition;
            string civilStatus = attendance.CivilStatus;
            string timeIn = attendance.TimeIn.ToString("hh\\:mm\\:ss");
            string timeOut = attendance.TimeOut.ToString("hh\\:mm\\:ss");
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();
                string query = "INSERT INTO tbl_accountlist_history (acc_num, acc_name, empl_dept, empl_position, civil_status, timelogin, timelogout, attendance_date) " +
                               "VALUES (@AccNum, @AccName, @EmplDept, @EmplPosition, @CivilStatus, @TimeIn, @TimeOut, @Date)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccNum", acc_num);
                command.Parameters.AddWithValue("@AccName", acc_name);
                command.Parameters.AddWithValue("@EmplDept", employeeDept);
                command.Parameters.AddWithValue("@EmplPosition", employeePosition);
                command.Parameters.AddWithValue("@CivilStatus", civilStatus);
                command.Parameters.AddWithValue("@TimeIn", timeIn);
                command.Parameters.AddWithValue("@TimeOut", timeOut);
                command.Parameters.AddWithValue("@Date", date);
                command.ExecuteNonQuery();
            }
        }

        public void ResetTimeInAndOut()
        {

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                string query = "UPDATE tbl_accountlist SET timelogin = '00:00:00', timelogout = '00:00:00'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }

        public List<Attendance> GetEmployees()
        {
            List<Attendance> getemployees = new List<Attendance>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    connection.Open();

                    string query = "SELECT * FROM tbl_accountlist";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int acc_num = reader.GetInt32("acc_num");
                            string firstName = reader.GetString("first_name");
                            string middleInitial = reader.GetString("mid_initial");
                            string lastName = reader.GetString("last_name");
                            string employeeDept = reader.GetString("empl_dept");
                            string employeePosition = reader.GetString("empl_position");
                            string civilStatus = reader.GetString("civil_status");
                            TimeSpan timeIn = TimeSpan.Parse(reader.GetString("timelogin"));
                            TimeSpan timeOut = TimeSpan.Parse(reader.GetString("timelogout"));

                            Attendance employees = new Attendance(acc_num, lastName, firstName, middleInitial, employeeDept, employeePosition, civilStatus);
                            getemployees.Add(employees);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
            return getemployees;
        }

        public List<Attendance> GetEmployeeAttendance() 
        {
            List<Attendance> getAttendance = new List<Attendance>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    connection.Open();

                    string query = "SELECT * FROM tbl_accountlist_history";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int acc_num = reader.GetInt32("acc_num");
                            string acc_name = reader.GetString("acc_name");
                            string department = reader.GetString("empl_dept");
                            string position = reader.GetString("empl_position");
                            string civilStatus = reader.GetString("civil_status");
                            TimeSpan timeIn = TimeSpan.Parse(reader.GetString("timelogin"));
                            TimeSpan timeOut = ParseTimeSpan(reader.GetString("timelogout"));
                            DateTime date = reader.GetDateTime("attendance_date");

                            Attendance attendance = new Attendance(acc_num, acc_name, department, position, civilStatus, timeIn, timeOut, date);
                            getAttendance.Add(attendance);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("An error occurred while fetching the data." + ex.Message);
            }

            return getAttendance;
        }

        private TimeSpan ParseTimeSpan(string timeString)
        {
            string[] parts = timeString.Split(':');
            int hours = int.Parse(parts[0]);
            int minutes = int.Parse(parts[1]);
            int seconds = int.Parse(parts[2]);

            return new TimeSpan(hours, minutes, seconds);
        }

        public bool DataEntry(string lastName, string firstName, string middleInitial, string employeeDept, string employeePosition, string civilStatus)
        {
            string query = "INSERT INTO tbl_accountlist (last_name,first_name, mid_initial,empl_dept,empl_position,civil_status) VALUES (@lastname,@firstname,@midinitial,@empldept,@emplposition,@civil_status)";

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                        cmd.Parameters.AddWithValue("@lastname", lastName);
                        cmd.Parameters.AddWithValue("@firstname", firstName);
                        cmd.Parameters.AddWithValue("@midinitial", middleInitial);
                        cmd.Parameters.AddWithValue("@empldept", employeeDept);
                        cmd.Parameters.AddWithValue("@emplposition", employeePosition);
                        cmd.Parameters.AddWithValue("@civil_status", civilStatus);
                        connection.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully added employee info!");

                        return rowsAffected > 0;
                }
            }
        }
    }
}
