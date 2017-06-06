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
    public partial class frmAdminPanel : Form
    {
        private string userNameStored;
        public frmAdminPanel()
        {
            InitializeComponent();
        }
        public void storeUserName(string name)
        {
            userNameStored = name;
        }

        private void addExamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddExam fae = new frmAddExam();
            fae.ShowDialog();
        }

        private void addMCQsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuestionBank fqb = new frmQuestionBank();
            fqb.ShowDialog();
        }

        private void editDeleteMCQsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmforChangeInQuestionBank ffciqb = new frmforChangeInQuestionBank();
            ffciqb.ShowDialog();
        }

        private void createStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserChangePassword fucp = new frmUserChangePassword();
            fucp.storeUserName(userNameStored);

            frmCreateStudent fcs = new frmCreateStudent();
            fcs.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePasswordForStudent fcpfs = new frmChangePasswordForStudent();
            fcpfs.ShowDialog();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUserChangePassword facp = new frmUserChangePassword();
            facp.storeUserName(userNameStored);
            facp.ShowDialog();

        }

        private void viewResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminViewScore favs = new frmAdminViewScore();
            favs.ShowDialog();
        }

        private void frmAdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
        }
    }
}
