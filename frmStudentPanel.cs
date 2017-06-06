using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCQExam
{
    public partial class frmStudentPanel : Form
    {
        private string userNameStored;
        public frmStudentPanel()
        {
            InitializeComponent();
        }
        public void storeUserName(string name)
        {
            userNameStored = name;
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUserChangePassword fucp = new frmUserChangePassword();
            fucp.storeUserName(userNameStored);
            fucp.ShowDialog();
        }

        private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are Signing out");
            Hide();
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentMCQExam fsme = new frmStudentMCQExam();
            fsme.storeUserName(userNameStored);
            fsme.ShowDialog();
        }
    }
}
