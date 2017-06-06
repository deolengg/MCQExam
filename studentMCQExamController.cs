using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQExam
{
    class studentMCQExamController
    {
        Connection conString = new Connection();
        public string getExamDate(string examName)
        {
            string currentDate="";
            Connection conString = new Connection();
            string gettingExamDate = "select examDate from exam where examName =@examName";

            SqlConnection connection = conString.GetConnectionString();
            SqlCommand cmd = new SqlCommand(gettingExamDate, connection);
            connection.Open();
            SqlParameter p1 = cmd.Parameters.Add("@examName", SqlDbType.VarChar, -1, "examName");
            p1.Value = examName;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                currentDate = rdr[0].ToString();
            }

            connection.Close();
            return currentDate;
        }
        
        public DataSet getQuestionToBank(string examId)
        {
            DataSet dsMCQuestions = null;
            try
            {
                Connection conString = new Connection();
                string getMCQuestions = "select * from questionBank where examId =@examId";
                
                SqlConnection connection = conString.GetConnectionString();
                SqlCommand gettingMCQuestions = new SqlCommand(getMCQuestions, connection);
                
                SqlParameter p1 = gettingMCQuestions.Parameters.Add("@examId", SqlDbType.Int, -1, "examId");
                p1.Value = examId;
                SqlDataAdapter adap = new SqlDataAdapter();
                dsMCQuestions = new DataSet();
                adap.SelectCommand = gettingMCQuestions;
                adap.Fill(dsMCQuestions);
                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Type: {0}", ex.GetType());
                Console.WriteLine("Message: {0}", ex.Message);
            }
            return dsMCQuestions;
        }
    }
}
