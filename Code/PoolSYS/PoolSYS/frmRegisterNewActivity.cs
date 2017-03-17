using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolSYS
{
    public partial class frmRegisterNewActivity : Form
    {
        Activity newActivity = new Activity();

        public frmRegisterNewActivity()
        {
            InitializeComponent();
        }

        private void bttn_Click(object sender, EventArgs e)
        {
            if (txtActivityName.Text.Equals(""))
            {
                MessageBox.Show("Activity Name must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtActivityName.Focus();
                return;
            }
            if(txtDesc.Text.Equals(""))
            {
                MessageBox.Show("Description must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Focus();
                return;
            }
            if (txtNoOfSpaces.Text.Equals("")) 
            {
                MessageBox.Show("Number of spaces must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoOfSpaces.Focus();
                return;
            }
  
            if (txtRate.Text.Equals("")) 
            {
                MessageBox.Show("Rate must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                return;
            }

  
            if (txtDuration.Text.Equals(""))
            {
                MessageBox.Show("Duration must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuration.Focus();
            }

            //invoke insActivity()
            //Instantiate object variables

            newActivity.setActivity_No(Convert.ToInt32(txtActNo.Text));
            newActivity.setActivity_Name(txtActivityName.Text.ToUpper());
            newActivity.setdescription(txtDesc.Text.ToUpper());
            newActivity.setStart_Date(dtpStart_Date.Value.ToString("dd-MMM-yyyy"));
            newActivity.setDuration(Convert.ToInt32(txtDuration.Text));
            newActivity.setNo_Of_Spaces(Convert.ToInt32(txtNoOfSpaces.Text));
            newActivity.setAvailability(Convert.ToInt32(txtNoOfSpaces.Text));
            newActivity.setRate(Convert.ToDouble(txtRate.Text));

            newActivity.insActivity();

            //display confirmation message
            MessageBox.Show("Activity Added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // reset ui
            txtActivityName.Text = "";
            txtDesc.Text = "";
            txtNoOfSpaces.Text = "";
            txtRate.Text = "";
            txtDuration.Text = "";
            dtpStart_Date.Value = System.DateTime.Today;
            txtActNo.Text = newActivity.getNextActivity_No().ToString("0000");
            txtActivityName.Focus();
            
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newfrm = new frmMain();
            newfrm.Show();
            this.Close();
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRegisterNewActivity_Load(object sender, EventArgs e)
        {
            txtActNo.Text = newActivity.getNextActivity_No().ToString("0000");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtActNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
