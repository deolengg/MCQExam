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
    public partial class frmAdminViewScore : Form
    {
        public frmAdminViewScore()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void frmAdminViewScore_Load(object sender, EventArgs e)
        {
            resultController rc = new resultController();
            DataSet ds=rc.getScore();
            dataGridViewScore.DataSource = ds.Tables[0];
            dataGridViewScore.ReadOnly = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
