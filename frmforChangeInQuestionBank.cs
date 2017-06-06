using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCQExam
{
    public partial class frmforChangeInQuestionBank : Form
    {
        public frmforChangeInQuestionBank()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void forChangeInQuestionBank_Load(object sender, EventArgs e)
        {
           
            Connection conString = new Connection();
            string getExamNames = "select examName from exam";
            System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();

            SqlDataAdapter gettingExamNames = new SqlDataAdapter(getExamNames, connection);
            connection.Open();
            DataSet ds = new DataSet();
            gettingExamNames.Fill(ds, "examName");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBoxExamName.Items.Add(ds.Tables[0].Rows[i]["examName"].ToString());
            }
            comboBoxExamName.Items.Insert(0, "Select Exam");
            comboBoxExamName.SelectedIndex = 0;
        }

        private void comboBoxQuestionName_SelectedIndexChanged(object sender, EventArgs e)
        {

            Connection conString = new Connection();
            string getAllQuestion = "select question,OptionA,OptionB,OptionC,OptionD from questionBank where question='"+ comboBoxQuestionName.SelectedItem.ToString() + "' ";
            System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();
            SqlDataReader myReader = null;
            SqlCommand gettingOptionsForQuestion = new SqlCommand(getAllQuestion, connection);
            connection.Open();

            myReader = gettingOptionsForQuestion.ExecuteReader();

            while (myReader.Read())
            {
                txtBoxQuestion.Text = (myReader["question"].ToString());
                txtBoxOptionA.Text = (myReader["optionA"].ToString());
                txtBoxOptionB.Text = (myReader["optionB"].ToString());
                txtBoxOptionC.Text = (myReader["optionC"].ToString());
                txtBoxOptionD.Text = (myReader["optionD"].ToString());
            }
            connection.Close();

        }

        private void txtBoxOptionA_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxExamName_SelectedIndexChanged(object sender, EventArgs e)
        {
            getQuestionforExams();
        }
        public string giveCorrectOptionValue(string abc)
        {
            if (comboBoxCorrectionOption.Text == "Option A")
            {
                return txtBoxOptionA.Text;
            }
            else if (comboBoxCorrectionOption.Text == "Option B")
            {
                return txtBoxOptionB.Text;
            }
            else if (comboBoxCorrectionOption.Text == "Option C")
            {
                return txtBoxOptionC.Text;
            }
            else
            {
                return txtBoxOptionD.Text;
            }
        }
        public void getQuestionforExams()
        {
            comboBoxQuestionName.Items.Clear();
            Connection conString = new Connection();
            string getAllQuestion = "select question from questionBank where examid=(select examid from exam where examName='" + comboBoxExamName.SelectedItem.ToString() + "')";
            System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();

            SqlDataAdapter gettingAllQuestions = new SqlDataAdapter(getAllQuestion, connection);
            connection.Open();
            DataSet ds = new DataSet();
            gettingAllQuestions.Fill(ds, "question");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBoxQuestionName.Items.Add(ds.Tables[0].Rows[i]["question"].ToString());
            }
            comboBoxQuestionName.Items.Insert(0, "Select Question");
            comboBoxQuestionName.SelectedIndex = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetTexts();

        }
        public void resetTexts()
        {
            txtBoxOptionA.Clear();
            txtBoxOptionB.Clear();
            txtBoxOptionC.Clear();
            txtBoxOptionD.Clear();
            txtBoxQuestion.Clear();
            comboBoxCorrectionOption.SelectedIndex = -1;
            comboBoxExamName.SelectedIndex = 0;
            comboBoxQuestionName.SelectedIndex = 0;
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connection conString = new Connection();
            string deleteQuestion = "delete from questionBank where question = '" + txtBoxQuestion.Text + "' ";
            System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();

            SqlCommand deletingQuestion = new SqlCommand(deleteQuestion, connection);
            connection.Open();
            deletingQuestion.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Whole Question Delete");
            resetTexts();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtBoxQuestion.Text == "")
            {
                MessageBox.Show("Please enter Question");
            }
            else if (txtBoxOptionA.Text == "" && txtBoxOptionB.Text == "" & txtBoxOptionC.Text == "" && txtBoxOptionD.Text == "")
            {
                MessageBox.Show("Please enter All the Options");

            }
            else if (comboBoxCorrectionOption.Text == "")
            {
                MessageBox.Show("Please Choose the Correct Option");
            }
            else
            {
                Connection conString = new Connection();
                string updateQuestion = "update questionBank set question = '" + txtBoxQuestion.Text + "' ,optionA='" + txtBoxOptionA.Text + "' ,optionB='" + txtBoxOptionB.Text + "',optionC='" + txtBoxOptionC.Text + "',optionD='" + txtBoxOptionD.Text + "' ,correctOption='" + giveCorrectOptionValue(comboBoxCorrectionOption.Text) + "' where question  = '" + comboBoxQuestionName.Text + "' ";

                System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();

                SqlCommand updatingQuestion = new SqlCommand(updateQuestion, connection);
                connection.Open();
                updatingQuestion.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Whole Question Updated for " + comboBoxQuestionName.Text);
                resetTexts();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
