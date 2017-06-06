using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MCQExam
{
    public partial class frmCreateStudent : Form
    {
        public frmCreateStudent()
        {
            InitializeComponent();
        }


        private void createStd_Load(object sender, EventArgs e)
        {

        }

        private void lblStudentPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetTexts();
        }
        public void resetTexts()
        {
            txtBoxEmailId.Clear();
            txtBoxPassword.Clear();
            txtBoxStudentName.Clear();
            txtBoxUserName.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxStudentName.Text == "")
            {
                MessageBox.Show("Please Enter the Student Name");
            }
            else if (txtBoxUserName.Text == "")
            {
                MessageBox.Show("Please Enter the User Name");
            }
            else if (txtBoxPassword.Text == "")
            {
                MessageBox.Show("Please Enter New Password for Student");
            }
            else if (!ValidatePassword(txtBoxPassword.Text))
            {
                MessageBox.Show("Please Enter Password with Capital Letters, Small Letters and Digits");
            }
            else if (!IsValidEmail(txtBoxEmailId.Text))
            {
                MessageBox.Show("Please Re-Enter Email Address");
            }
            else
            {
                CreateStudentController csc = new CreateStudentController();
                csc.addStudent(txtBoxStudentName.Text, txtBoxUserName.Text, txtBoxPassword.Text, txtBoxEmailId.Text);
                csc.addStudentToLoginType(txtBoxUserName.Text, txtBoxPassword.Text);
                MessageBox.Show(txtBoxStudentName.Text + " as Student is created");
                resetTexts();
            }
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
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

