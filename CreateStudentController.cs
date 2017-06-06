using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQExam
{
    class CreateStudentController
    {
        Connection conString = new Connection();
        public void changeStudentPassword(string studentName, string newPassWord)
        {
            string updateStudentPassWord = "update student set passWord=@newPassWord where studentName=@studentName";
            try
            {
                System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();
                connection.Open();

                SqlCommand cmd = new SqlCommand(updateStudentPassWord, connection);
                SqlParameter p1 = cmd.Parameters.Add("@studentName", SqlDbType.VarChar, -1, "studentName");
                SqlParameter p2 = cmd.Parameters.Add("@newPassWord", SqlDbType.VarChar, -1, "passWord");

                p1.Value = studentName;
                p2.Value = newPassWord;


                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);
            }
        }
        public string getStudentUserName(string studentName)
        {
            string gotUserName="";
            string getUserName = "select userName from student where studentName=@studentName";
            System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();
            connection.Open();

            SqlCommand cmd = new SqlCommand(getUserName, connection);
            SqlParameter p1 = cmd.Parameters.Add("@studentName", SqlDbType.VarChar, -1, "studentName");
            p1.Value = studentName;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                gotUserName = rdr[0].ToString();
            }

            connection.Close();
            return gotUserName;
        }
        public void changeStudentPasswordForLogin(string studentName, string password)
        {
            string userName = getStudentUserName(studentName);

            string updateStudentPassWord = "update loginType set password=@password where userName=@userName";
            try
            {
                System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();
                connection.Open();

                SqlCommand cmd = new SqlCommand(updateStudentPassWord, connection);
                SqlParameter p1 = cmd.Parameters.Add("@userName", SqlDbType.VarChar, -1, "userName");
                SqlParameter p2 = cmd.Parameters.Add("@password", SqlDbType.VarChar, -1, "password");

                p1.Value = userName;
                p2.Value = password;


                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);
            }
        }

        public void addStudent(string studentName, string userName, string passWord, string emailId)
        {
            string addStudentQuery = "insert into student values (@studentName,@userName,@emailId)";
            try
            {
                System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();
                connection.Open();

                SqlCommand cmd = new SqlCommand(addStudentQuery, connection);

                SqlParameter p1 = cmd.Parameters.Add("@studentName", SqlDbType.VarChar, -1, "studentName");
                SqlParameter p2 = cmd.Parameters.Add("@userName", SqlDbType.VarChar, -1, "userName");
                SqlParameter p3 = cmd.Parameters.Add("@emailId", SqlDbType.VarChar, -1, "emailId");

                p1.Value = studentName;
                p2.Value = userName;
                p3.Value = emailId;
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);
            }
        }


        public void addStudentToLoginType(string userName, string password)
        {
            string addStudentQuery = "insert into loginType values (@userTypeId,@userName,@password)";
            try
            {
                System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();
                connection.Open();

                SqlCommand cmd = new SqlCommand(addStudentQuery, connection);
                SqlParameter p1 = cmd.Parameters.Add("@userTypeId", SqlDbType.Int, -1, "userTypeId");
                SqlParameter p2 = cmd.Parameters.Add("@userName", SqlDbType.VarChar, -1, "userName");
                SqlParameter p3 = cmd.Parameters.Add("@password", SqlDbType.VarChar, -1, "password");
                p1.Value = 2;
                p2.Value = userName;
                p3.Value = password;
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);
            }
        }
    }
}
