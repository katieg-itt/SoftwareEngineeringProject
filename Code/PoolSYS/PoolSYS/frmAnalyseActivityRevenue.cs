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
    public partial class frmAnalyseActivityRevenue : Form
    {
        Registration newReg = new Registration();
        Activity newActivity = new Activity();

        int totalActivities = 0;
        int totalActivitiesGross = 0;
        List<int> addedActivities = new List<int>();

        public frmAnalyseActivityRevenue()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
          grdActivity.DataSource = newActivity.findActivities(txtActivityName.Text).Tables["Act"];
          grdActivity.Visible = true;
        }

        private void lstActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpActivityRevenue.Visible = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // check the list to see if the id is already there
            // if it is not, add it to the list and add the totals.
            int activity_id = Convert.ToInt32(txtActivityID.Text);
            if (addedActivities.Contains(activity_id))
            {
                // Do nothing, we already added this one
                MessageBox.Show("Activity Added Already", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // add it to the list, and do our calculations
                addedActivities.Add(activity_id);

                grpCalculator.Visible = true;
                totalActivities += 1;
                totalActivitiesGross += (Convert.ToInt32(txtNoOfSpaces.Text) * Convert.ToInt32(txtRate.Text));

                txtNoOfActivities.Text = totalActivities.ToString();
                txtGross.Text = totalActivitiesGross.ToString();
            }

        }

        private void bttn_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Activity Revenue complete", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            grpActivityRevenue.Visible = false;
            grdActivity.Visible = false;
            txtActivityName.Text = "";
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

        private void grdActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            newActivity.getActivity(Convert.ToInt32(grdActivity.Rows[grdActivity.CurrentCell.RowIndex].Cells[0].Value));

            txtActivityID.Text = newActivity.getActivity_No().ToString();
            txtActivityName2.Text = newActivity.getActivity_Name();
            txtDesc.Text = newActivity.getDescription();
            txtDuration.Text = newActivity.getDuration().ToString();
            txtNoOfSpaces.Text = newActivity.getNo_Of_Spaces().ToString();
            txtSpaces.Text = newActivity.getNo_Of_Spaces().ToString();
            txtRate.Text = newActivity.getRate().ToString();

            grpActivityRevenue.Visible = true;
        }

        private void frmAnalyseActivityRevenue_Load(object sender, EventArgs e)
        {

        }

        private void bttnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for viewing", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grpActivityRevenue.Visible = false;
            grdActivity.Visible = false;
            grpCalculator.Visible = false;
            txtActivityName.Text = "";
            txtActivityName.Focus();


        }
    }
}
