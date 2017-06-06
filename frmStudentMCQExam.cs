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
    public partial class frmStudentMCQExam : Form
    {
        private string userNameStored;
        string setExamId = "";
        public frmStudentMCQExam()
        {
            InitializeComponent();
        }
        public void storeUserName(string name)
        {
            userNameStored = name;
        }

        private void frmStudentMCQExam_Load(object sender, EventArgs e)
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
            comboBoxExamName.SelectedIndex = -1;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            frmStudentPanel fsp = new frmStudentPanel();
            fsp.ShowDialog();
        }

        private void comboBoxExamName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Connection conString = new Connection();
                string getExamId = "select examId from exam where examName= '" + comboBoxExamName.Text + "'  ";
                System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();
                SqlDataReader myReader = null;
                SqlCommand gettingExamId = new SqlCommand(getExamId, connection);
                connection.Open();
                //string setExamId = "";
                myReader = gettingExamId.ExecuteReader();
                while (myReader.Read())
                {
                    setExamId = (myReader["examId"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Type: {0}", ex.GetType());
                Console.WriteLine("Message: {0}", ex.Message);
            }


        }

        private void btnBeginTest_Click(object sender, EventArgs e)
        {
            
            studentMCQExamController smec = new studentMCQExamController();
            string gotExamDate = smec.getExamDate(comboBoxExamName.Text);
            DateTime examDateV = DateTime.Parse(gotExamDate);
            DateTime localDate = DateTime.Now;
            // MessageBox.Show(localDate.ToString());

            if (examDateV.Date > localDate.Date)
            {
                MessageBox.Show("You cant give exam before " + examDateV.ToString());
            }
            else
            {
                MessageBox.Show("Good luck for exam");
                pictureBoxHide.Visible = false;


                DataSet ds = smec.getQuestionToBank(setExamId);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        lblQuestionOne.Text = ds.Tables[0].Rows[i]["question"].ToString();
                        radioBtnQOneOptionA.Text = ds.Tables[0].Rows[i]["optionA"].ToString();
                        radioBtnQOneOptionB.Text = ds.Tables[0].Rows[i]["optionB"].ToString();
                        radioBtnQOneOptionC.Text = ds.Tables[0].Rows[i]["optionC"].ToString();
                        radioBtnQOneOptionD.Text = ds.Tables[0].Rows[i]["optionD"].ToString();
                    }
                    else if (i == 1)
                    {
                        lblQuestionTwo.Text = ds.Tables[0].Rows[i]["question"].ToString();
                        radioBtnQTwoOptionA.Text = ds.Tables[0].Rows[i]["optionA"].ToString();
                        radioBtnQTwoOptionB.Text = ds.Tables[0].Rows[i]["optionB"].ToString();
                        radioBtnQTwoOptionC.Text = ds.Tables[0].Rows[i]["optionC"].ToString();
                        radioBtnQTwoOptionD.Text = ds.Tables[0].Rows[i]["optionD"].ToString();
                    }
                    else if (i == 2)
                    {
                        lblQuestionThree.Text = ds.Tables[0].Rows[i]["question"].ToString();
                        radioBtnQThreeOptionA.Text = ds.Tables[0].Rows[i]["optionA"].ToString();
                        radioBtnQThreeOptionB.Text = ds.Tables[0].Rows[i]["optionB"].ToString();
                        radioBtnQThreeOptionC.Text = ds.Tables[0].Rows[i]["optionC"].ToString();
                        radioBtnQThreeOptionD.Text = ds.Tables[0].Rows[i]["optionD"].ToString();
                    }
                    else
                    {
                        lblQuestionFour.Text = ds.Tables[0].Rows[i]["question"].ToString();
                        radioBtnQFourOptionA.Text = ds.Tables[0].Rows[i]["optionA"].ToString();
                        radioBtnQFourOptionB.Text = ds.Tables[0].Rows[i]["optionB"].ToString();
                        radioBtnQFourOptionC.Text = ds.Tables[0].Rows[i]["optionC"].ToString();
                        radioBtnQFourOptionD.Text = ds.Tables[0].Rows[i]["optionD"].ToString();
                    }
                }
            }
        }

        private void radioBtnQFourOptionC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            int counter=0;
            studentMCQExamController smec = new studentMCQExamController();
            DataSet ds = smec.getQuestionToBank(setExamId);
            string correctAnswerOne = "";
            string correctAnswerTwo = "";
            string correctAnswerThree = "";
            string correctAnswerFour = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (i == 0)
                {
                    correctAnswerOne = ds.Tables[0].Rows[i]["correctOption"].ToString();
                }
                else if (i == 1)
                {
                    correctAnswerTwo = ds.Tables[0].Rows[i]["correctOption"].ToString();
                }
                else if (i == 2)
                {
                    correctAnswerThree = ds.Tables[0].Rows[i]["correctOption"].ToString();
                }
                else
                {
                    correctAnswerFour = ds.Tables[0].Rows[i]["correctOption"].ToString();
                }
            }
            foreach (Control c in groupBoxQuestionOne.Controls)
            {
                if (c is RadioButton && ((RadioButton)c).Checked == true)
                {
                    if (c.Text == correctAnswerOne)
                    {
                        counter++;
                    }
                }
            }
            foreach (Control c in groupBoxQuestionTwo.Controls)
            {
                if (c is RadioButton && ((RadioButton)c).Checked == true)
                {
                    if (c.Text == correctAnswerTwo)
                    {
                        counter++;
                    }
                }
            }
            foreach (Control c in groupBoxQuestionThree.Controls)
            {
                if (c is RadioButton && ((RadioButton)c).Checked == true)
                {
                    if (c.Text == correctAnswerThree)
                    {
                        counter++;
                    }
                }
            }
            foreach (Control c in groupBoxQuestionFour.Controls)
            {
                if (c is RadioButton && ((RadioButton)c).Checked == true)
                {
                    if (c.Text == correctAnswerFour)
                    {
                        counter++;
                    }
                }
            }
            MessageBox.Show("your score is " +counter);
            scoreController sc = new scoreController();
            sc.addScore(sc.getExamId(comboBoxExamName.Text), sc.getStudentId(userNameStored), counter.ToString());

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
