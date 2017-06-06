using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQExam
{
    class AddQuestionsController
    {
        Connection conString = new Connection();

        public void addQuestionToBank(string question, string optionA, string optionB, string optionC, string optionD, string correctOption, string examId)
        {

            string addQuestionToBank = "insert into questionBank(question,optionA,optionB,optionC,optionD,correctOption,examId) values (@question,@optionA,@optionB,@optionC,@optionD,@correctOption,@examId)";
            try
            {
                //int examId = 1;
                System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();
                connection.Open();

                SqlCommand cmd = new SqlCommand(addQuestionToBank, connection);
                //cmd.Parameters.Add("1", SqlDbType.Int,-1, "questionBankId");
                SqlParameter p1 = cmd.Parameters.Add("@question", SqlDbType.VarChar, -1, "question");
                SqlParameter p2 = cmd.Parameters.Add("@optionA", SqlDbType.VarChar, -1, "optionA");
                SqlParameter p3 = cmd.Parameters.Add("@optionB", SqlDbType.VarChar, -1, "optionB");
                SqlParameter p4 = cmd.Parameters.Add("@optionC", SqlDbType.VarChar, -1, "optionC");
                SqlParameter p5 = cmd.Parameters.Add("@optionD", SqlDbType.VarChar, -1, "optionD");
                SqlParameter p6 = cmd.Parameters.Add("@correctOption", SqlDbType.VarChar, -1, "correctOption");
                SqlParameter p7 = cmd.Parameters.Add("@examId", SqlDbType.Int, 4, "examId");

                p1.Value = question;
                p2.Value = optionA;
                p3.Value = optionB;
                p4.Value = optionC;
                p5.Value = optionD;
                p6.Value = correctOption;
                p7.Value = Convert.ToInt32(examId);
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
