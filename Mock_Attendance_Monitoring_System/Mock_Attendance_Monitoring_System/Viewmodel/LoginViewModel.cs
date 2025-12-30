using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Mock_Attendance_Monitoring_System.Viewmodel
{
    internal class LoginViewModel
    {
        private readonly string sqlconnect = @"Server=localhost;Port=3306;Database=db_attendance1;Uid=root;SslMode=none";

        public bool getAdmin(Model.adminModel Admin)
        {
            bool isLogin = false;
            using (MySqlConnection conn = new MySqlConnection(sqlconnect))
            {
                conn.Open();
                string query = "SELECT username, userpassword FROM tbl_adminlogin WHERE username = @uName AND userpassword = @uPassword";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@uName", Admin.AdminName);
                    command.Parameters.AddWithValue("@uPassword", Admin.AdminPassword);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            isLogin = true;
                        }
                        else
                        {
                            isLogin = false;
                        }
                    }
                }
            }
            return isLogin;
        }
    }
}
