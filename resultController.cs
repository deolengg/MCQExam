using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQExam
{
    class resultController
    {
        Connection conString = new Connection();

        public DataSet getScore()
        {
            DataSet gotScores = null;
            try
            {
                Connection conString = new Connection();
                string getScores = "select * from score_vw";

                SqlConnection connection = conString.GetConnectionString();
                SqlCommand gettingMCQuestions = new SqlCommand(getScores, connection);
                connection.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                gotScores = new DataSet();
                adap.SelectCommand = gettingMCQuestions;
                adap.Fill(gotScores);
                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Type: {0}", ex.GetType());
                Console.WriteLine("Message: {0}", ex.Message);
            }
            return gotScores;
        }
    }
}
