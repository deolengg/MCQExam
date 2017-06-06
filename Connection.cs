using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQExam
{
    public class Connection
    {
        public SqlConnection GetConnectionString()
        {
            return new SqlConnection("Data Source=KARAN\\SQLEXPRESS;Initial Catalog=MCQExam;Integrated Security=True");
        }
    }
}
