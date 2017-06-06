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
    public partial class frmUserChangePassword : Form
    {
        private string userNameStored;
        public frmUserChangePassword()
        {
            InitializeComponent();
        }
        public void storeUserName(string name)
        {
           userNameStored=name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetText();
        }
        public void resetText()
        {
            txtboxConfirmPassword.Clear();
            txtBoxNewPassword.Clear();
 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
         if (txtBoxNewPassword.Text == "")
            {
                MessageBox.Show("Please Enter New Password");
            }
         else if (txtboxConfirmPassword.Text == "")
            {
                MessageBox.Show("Please Enter Confirm Password");
            }
            else if (!ValidatePassword(txtBoxNewPassword.Text))
            {
                MessageBox.Show("Please Enter Password with Capital Letters, Small Letters and Digits");
            }
            else if (txtBoxNewPassword.Text != txtboxConfirmPassword.Text)
            {
                MessageBox.Show("New Passsword and Confirm Password Mis-Match");
            }
         else { 
                string changePassword = "update loginType set password=@password where userName=@userName";
                try
                {
                    Connection conString = new Connection();
                    System.Data.SqlClient.SqlConnection connection = conString.GetConnectionString();
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(changePassword, connection);
                    SqlParameter p1 = cmd.Parameters.Add("@userName", SqlDbType.VarChar, -1, "userName");
                    SqlParameter p2 = cmd.Parameters.Add("@password", SqlDbType.VarChar, -1, "password");


                    p1.Value = userNameStored;
                    p2.Value = txtBoxNewPassword.Text;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Password has been Reset");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);
                }
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
