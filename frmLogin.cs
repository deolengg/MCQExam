using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCQExam
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(startSplashScreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void startSplashScreen()
        {
            Application.Run(new frmSplashScreenForm());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text =="")
            {
                MessageBox.Show("Please Enter Value in UserName");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Value Password");
            }
            else
            {
                LoginController login = new LoginController();
                int usertype = login.DoLogin(txtUserName.Text, txtPassword.Text);

                if (usertype == 1)
                {
                    string passWordVal = login.checkCurrentPassword(txtUserName.Text);
                    if (passWordVal == txtPassword.Text)
                    {
                        Hide();
                        frmAdminPanel fap = new frmAdminPanel();
                        fap.storeUserName(txtUserName.Text);
                        fap.ShowDialog();
                        
                        
                    }
                    else { MessageBox.Show("Authentication Failed"); }

                }
                else
                {
                    string passWordVal = login.checkCurrentPassword(txtUserName.Text);

                    if (passWordVal == txtPassword.Text)
                    {
                        Hide();
                        frmStudentPanel fsp = new frmStudentPanel();
                        fsp.storeUserName(txtUserName.Text);
                        fsp.ShowDialog();
                        frmLogin fl = new frmLogin();
                        fl.Close();
                        
                    }
                    else { MessageBox.Show("Authentication Failed"); }
                }
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
