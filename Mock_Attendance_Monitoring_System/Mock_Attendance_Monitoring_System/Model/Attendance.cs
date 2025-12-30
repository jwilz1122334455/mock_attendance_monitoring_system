using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Mock_Attendance_Monitoring_System.Model
{
    internal class Attendance
    {
        private int acc_num;
        private string acc_name;
        private string lastName;
        private string firstName;
        private string middleInitial;
        private string employeeDept;
        private string employeePosition;
        private string civil_status;
        private TimeSpan timeIn;
        private TimeSpan timeOut;
        private DateTime date;

        public int AccNum
        {
            get { return acc_num; }
            set { acc_num = value; }
        }

        public string AccName
        {
            get { return acc_name; }
            set { acc_name = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleInitial
        {
            get { return middleInitial; }
            set { middleInitial = value; }
        }

        public string EmployeeDept
        {
            get { return employeeDept; }
            set { employeeDept = value; }
        }

        public string EmployeePosition
        {
            get { return employeePosition; }
            set { employeePosition = value; }
        }

        public string CivilStatus
        {
            get { return civil_status; }
            set { civil_status = value; }
        }

        public TimeSpan TimeIn
        {
            get { return timeIn; }
            set { timeIn = value; }
        }

        public TimeSpan TimeOut
        {
            get { return timeOut; }
            set { timeOut = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public Attendance(int acc_num, string lastName, string firstName, string middleInitial, string employeeDept, string employeePosition, string civil_status)
        {
            AccNum = acc_num;
            LastName = lastName;
            FirstName = firstName;
            MiddleInitial = middleInitial;
            EmployeeDept = employeeDept;
            EmployeePosition = employeePosition;
            CivilStatus = civil_status;
        }

        public Attendance(int acc_num, string firstName, string middleInitial, string lastName, string employeeDept, string employeePosition, string civil_status, TimeSpan timeIn, TimeSpan timeOut)
        {
            AccNum = acc_num;
            FirstName = firstName;
            MiddleInitial = middleInitial;
            LastName = lastName;
            EmployeeDept = employeeDept;
            EmployeePosition = employeePosition;
            CivilStatus= civil_status;
            TimeIn = timeIn;
            TimeOut = timeOut;
        }

        public Attendance(int acc_num, string acc_name, string employeeDept, string employeePosition, string civil_status, TimeSpan timeIn, TimeSpan timeOut, DateTime date)
        {
            AccNum = acc_num;
            AccName = acc_name;
            EmployeeDept = employeeDept;
            EmployeePosition = employeePosition;
            CivilStatus = civil_status;
            TimeIn = timeIn;
            TimeOut = timeOut;
            Date = date;
        }

        public Attendance(int acc_num, string acc_name, string employeeDept, string employeePosition, string civil_status, TimeSpan timeIn)
        {
            AccNum = acc_num;
            AccName = acc_name;
            EmployeeDept = employeeDept;
            EmployeePosition = employeePosition;
            CivilStatus = civil_status;
        }

        public Attendance(int acc_num, string acc_name, string employeeDept, string employeePosition, string civil_status, TimeSpan timeIn, TimeSpan timeOut) : this(acc_num, acc_name, employeeDept, employeePosition, civil_status, timeIn)
        {
            AccNum = acc_num;
            AccName = acc_name;
            EmployeeDept = employeeDept;
            EmployeePosition = employeePosition;
            CivilStatus = civil_status;
            TimeIn = timeIn;
            TimeOut = timeOut;
        }
    }
}
