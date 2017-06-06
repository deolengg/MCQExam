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
    public partial class frmChangePasswordForStudent : Form
    {
        public frmChangePasswordForStudent()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public void resetText()
        {
            comboBoxStudentName.Items.Clear();
            txtNewPassWord.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetText();
        }

        private void frmChangePasswordForStudent_Load(object sender, EventArgs e)
        {
            getStudentNames();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxStudentName.Text == "")
            {
                MessageBox.Show("Please Select a Student");
            }
            else if (txtNewPassWord.Text == "")
            {
                MessageBox.Show("Please Enter New Password for Student");
            }
            else if (!ValidatePassword(txtNewPassWord.Text))
            {
                MessageBox.Show("Please Enter Password with Capital Letters, Small Letters and Digits");
            }
            else
            {
                CreateStudentController csc = new CreateStudentController();
                csc.changeStudentPassword(comboBoxStudentName.Text, txtNewPassWord.Text);
                //csc.changeStudentPasswordForLogin(comboBoxStudentName.Text, txtNewPassWord.Text);
                MessageBox.Show("Password has Changed for " + comboBoxStudentName.Text);
                resetText();
                getStudentNames();
            }
        }
        public void getStudentNames()
        {
            comboBoxStudentName.Items.Clear();
            Connection conString = new Connection();
            string getStudentNames = "select studentName from student";
            System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();

            SqlDataAdapter gettingExamNames = new SqlDataAdapter(getStudentNames, connection);
            connection.Open();
            DataSet ds = new DataSet();
            gettingExamNames.Fill(ds, "studentName");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBoxStudentName.Items.Add(ds.Tables[0].Rows[i]["studentName"].ToString());
            }
            comboBoxStudentName.Items.Insert(0, "Select Student");
            comboBoxStudentName.SelectedIndex = 0;
        }

        static bool ValidatePassword(string password)
        {
            const int MIN_LENGTH = 6;
            const int MAX_LENGTH = 15;

            if (password == null) throw new ArgumentNullException();

            bool meetsLengthRequirements = password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;

            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                }
            }

            bool isValid = meetsLengthRequirements
                        && hasUpperCaseLetter
                        && hasLowerCaseLetter
                        && hasDecimalDigit
                        ;
            return isValid;

        }
    }
}

