using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock_Attendance_Monitoring_System.Model
{
    internal class adminModel
    {
        private int adminID;
        private string adminName;
        private string adminPassword;

        public int AdminID
        {
            get { return adminID; }
            set { adminID = value; }
        }
        public string AdminName
        {
            get { return adminName; }
            set { adminName = value; }
        }
        public string AdminPassword
        {
            get { return adminPassword; }
            set { adminPassword = value; }
        }

        public adminModel(string adminName, string adminPassword)
        {
            this.AdminName = adminName;
            this.AdminPassword = adminPassword;
        }
    }
}
