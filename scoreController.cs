using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQExam
{
    class scoreController
    {
        Connection conString = new Connection();
        public string getExamId(string examName)
        {
            string gotExamId="";
            Connection conString = new Connection();
            string getExamId = "select examId from exam where examName=@examName";
            System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();
            connection.Open();

            SqlCommand cmd = new SqlCommand(getExamId, connection);
            SqlParameter p1 = cmd.Parameters.Add("@examName", SqlDbType.VarChar, -1, "examName");
            p1.Value = examName;


            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                gotExamId = rdr[0].ToString();
            }
            connection.Close();
            return gotExamId;
        }
        public string getStudentId(string userName)
        {
            string gotStudentId = "";
            string getStudentId = "select studentId from student where userName=@userName";
            System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();
            connection.Open();

            SqlCommand cmd = new SqlCommand(getStudentId, connection);
            SqlParameter p1 = cmd.Parameters.Add("@userName", SqlDbType.VarChar, -1, "userName");
            p1.Value = userName;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                gotStudentId = rdr[0].ToString();
            }
            connection.Close();
            return gotStudentId;
        }
        public void addScore(string examId,string studentId,string grade)
        {

            string setScore = "insert into score values (@examId,@studentId,@grade)";
            try
            {
                System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();
                connection.Open();

                SqlCommand cmd = new SqlCommand(setScore, connection);
                SqlParameter p1 = cmd.Parameters.Add("@examId", SqlDbType.VarChar, -1, "examId");
                SqlParameter p2 = cmd.Parameters.Add("@studentId", SqlDbType.VarChar, -1, "studentId");
                SqlParameter p3 = cmd.Parameters.Add("@grade", SqlDbType.VarChar, -1, "grade");
                

                p1.Value = examId;
                p2.Value = studentId;
                p3.Value = grade;
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Type: {0}", ex.GetType());
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }
    }
}


