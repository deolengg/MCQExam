using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQExam
{
    class AddExamController
    {
        Connection conString = new Connection();

        public void addQuestionToBank(string examName, string examDate, string examLocation, string examStatus)
        {
            string addQuestionToBank = "insert into exam values (@examName,@examDate,@examLocation,@examStatus)";
            try
            {
                System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();
                connection.Open();

                SqlCommand cmd = new SqlCommand(addQuestionToBank, connection);
                //SqlParameter p1 = cmd.Parameters.Add("1", SqlDbType.Int, -1, "examId");
                SqlParameter p1 = cmd.Parameters.Add("@examName", SqlDbType.VarChar, -1, "examName");
                SqlParameter p2 = cmd.Parameters.Add("@examDate", SqlDbType.DateTime, -1, "examDate");
                SqlParameter p3 = cmd.Parameters.Add("@examLocation", SqlDbType.VarChar, -1, "examLocation");
                SqlParameter p4 = cmd.Parameters.Add("@examStatus", SqlDbType.VarChar, -1, "examStatus");

                //p1.Value = 1;
                p1.Value = examName;
                p2.Value = Convert.ToDateTime(examDate);
                p3.Value = examLocation;
                p4.Value = examStatus;

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
