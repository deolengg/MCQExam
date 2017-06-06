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
    public partial class frmAddExam : Form
    {
        public frmAddExam()
        {
            InitializeComponent();
        }

        private void lblExamName_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxExamName.Text == "")
            {
                MessageBox.Show("Please Enter Name for Exam");
            }
            else if (txtBoxExamLocation.Text == "")
            {
                MessageBox.Show("Please Provide Location for Exam");
            }
            else if (comboBoxExamStatus.Text == "")
            {
                MessageBox.Show("Please Enter Status for Exam");
            }
            else
            {
                AddExamController aec = new AddExamController();
                aec.addQuestionToBank(txtBoxExamName.Text, dateTimePickerExamTime.Text, txtBoxExamLocation.Text, comboBoxExamStatus.Text);
                MessageBox.Show(txtBoxExamName.Text + " Exam Create");
                txtBoxExamLocation.Clear();
                txtBoxExamName.Clear();
                dateTimePickerExamTime.ResetText();
                comboBoxExamStatus.SelectedIndex = -1;
            }
            //comboBoxExamStatus.Items.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void frmAddExam_Load(object sender, EventArgs e)
        {

        }
    }
}
