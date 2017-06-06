using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQExam
{
    public class LoginController
    {
        Connection conString = new Connection();

        public int DoLogin(string username, string password)
        {
            int userexsist = -1;
            string loginQuery = "select * from logintype where userName=@username and password=@password";

            SqlConnection connection = conString.GetConnectionString();
            connection.Open();
            SqlCommand cmd = new SqlCommand(loginQuery, connection);
            SqlParameter sp_username = cmd.Parameters.Add("@username", SqlDbType.VarChar, 40, "userName");
            SqlParameter sp_password = cmd.Parameters.Add("@password", SqlDbType.VarChar, 40, "password");

            sp_username.Value = username;
            sp_password.Value = password;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if(username.ToLower()==dr[2].ToString().ToLower() && password.ToLower() == dr[3].ToString().ToLower())
                {
                    userexsist = Convert.ToInt32(dr[1].ToString());
                }
            }
            return userexsist;
        }
        public string checkCurrentPassword(string userName)
        {
            string checkPassWord = "";
            string getPassword = "select passWord from loginType where userName=@userName";
            SqlConnection connection = conString.GetConnectionString();
            connection.Open();
            SqlCommand cmd = new SqlCommand(getPassword, connection);
            SqlParameter sp_username = cmd.Parameters.Add("@userName", SqlDbType.VarChar, 40, "userName");
            sp_username.Value = userName;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                checkPassWord= dr[0].ToString().ToLower();
            }
            return checkPassWord;
        }
    }
}
