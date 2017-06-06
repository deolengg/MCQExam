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
    public partial class frmQuestionBank : Form

    {
        static int counter;
        private string userNameStored;
        public frmQuestionBank()
        {
            InitializeComponent();
        }
        public void storeUserName(string name)
        {
            userNameStored = name;
        }

        private void frmQuestionBank_Load(object sender, EventArgs e)
        {
            counter = 0;
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
            comboBoxExamName.SelectedIndex = -1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetTexts();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxQuestion.Text == "")
            {
                MessageBox.Show("Please enter Question");
            }
            else if (txtBoxOptionA.Text =="" && txtBoxOptionB.Text=="" & txtBoxOptionC.Text=="" && txtBoxOptionD.Text == "")
            {
                MessageBox.Show("Please enter All the Options");

            }
            else if (comboBoxCorrectionOption.Text=="")
            {
                MessageBox.Show("Please Choose the Correct Option");
            }
            else
            {
                counter++;
                warningShout(counter);
                Connection conString = new Connection();
                string getExamId = "select examId from exam where examName= '" + comboBoxExamName.Text + "'  ";
                System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();
                SqlDataReader myReader = null;
                SqlCommand gettingExamId = new SqlCommand(getExamId, connection);
                connection.Open();
                string setExamId = "";
                myReader = gettingExamId.ExecuteReader();
                while (myReader.Read())
                {
                    setExamId = (myReader["examId"].ToString());
                }
                connection.Close();
                AddQuestionsController aqtb = new AddQuestionsController();
                aqtb.addQuestionToBank(txtBoxQuestion.Text, txtBoxOptionA.Text, txtBoxOptionB.Text, txtBoxOptionC.Text, txtBoxOptionD.Text, giveCorrectOptionValue(comboBoxCorrectionOption.Text), setExamId.ToString());
                MessageBox.Show("Question added");
                resetTexts();
            }
        }
        public void warningShout(int counting)
        {
            if (counting == 4)
            {
                lblWarning.Text = "Warning,Dont Add more then 4 questions !";
            }
            else if(counting == 3)
            {
                lblWarning.Text = "Warning, Add one More Question !";
            }
            else if (counting == 2)
            {
                lblWarning.Text = "Warning, Add Two More Questions !";
            }
            else if (counting == 1)
            {
                lblWarning.Text = "Warning, Add Three More Questions !";
            }
            
        }
        public void resetTexts()
        {
            txtBoxOptionA.Clear();
            txtBoxOptionB.Clear();
            txtBoxOptionC.Clear();
            txtBoxOptionD.Clear();
            txtBoxQuestion.Clear();
            //comboBoxCorrectionOption.Items.Clear();
            comboBoxCorrectionOption.SelectedIndex = -1;
        }
    }
}
