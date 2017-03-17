using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace PoolSYS
{
    public partial class frmActivityRota : Form
    {
        Activity newActivity = new Activity();
        public frmActivityRota()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
        }

        private void lstActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpActivity.Visible = true;
        }

        private void bttn_Click(object sender, EventArgs e)
        {
            newActivity.setActivity_Name(txtActivityName2.Text);
            newActivity.setDuration(Convert.ToInt32(txtDuration.Text));
            newActivity.setNo_Of_Spaces(Convert.ToInt32(txtNoOfSpaces.Text));
            newActivity.setAvailability(Convert.ToInt32(txtAvailable.Text));

            MessageBox.Show("Activity Rota Viewed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtActivityName2.Text = "";
            txtDuration.Text = "";
            txtNoOfSpaces.Text = "";
            txtAvailable.Text = "";

            txtActivityName2.Text = "";
            txtActivityName2.Focus();
            grpActivity.Visible = false;
            grdActivity.Visible = true;
            txtActivityName2.Focus();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newfrm = new frmMain();
            newfrm.Show();
            this.Close();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmActivityRota_Load(object sender, EventArgs e)
        {
   
            //get all activities with matching name
            grdActivity.DataSource = newActivity.findActivities(txtActivityName2.Text).Tables["Act"];
            grdActivity.Visible = true;
        }

        private void grdActivity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //get activity details
            newActivity.getActivity(Convert.ToInt32(grdActivity.Rows[grdActivity.CurrentCell.RowIndex].Cells[0].Value));
            //display details

            txtActivityName2.Text = newActivity.getActivity_Name();
            txtDuration.Text = newActivity.getDuration().ToString();
            txtNoOfSpaces.Text = newActivity.getNo_Of_Spaces().ToString();
            txtAvailable.Text = newActivity.getAvailability().ToString();

            grpActivity.Visible = true; 

        }

        private void grpActivity_Enter(object sender, EventArgs e)
        {

        }

        private void grpActivity_Enter_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
    }
}
