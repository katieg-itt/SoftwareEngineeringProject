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
    public partial class frmViewAllActivities : Form
    {
        Activity newActivity = new Activity();
        public frmViewAllActivities()
        {
            InitializeComponent();
        }
        private void frmViewAllActivitiesList_Load(object sender, EventArgs e)
        {
            FillGrid("Activity_No");
        }

        public void FillGrid(String SortOrder)
        {
            int intNextActivity_No;

            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT * FROM Activities ORDER BY " + SortOrder;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //Create OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Activity");
            grdActivity.DataSource = ds.Tables["Activity"];

            myConn.Close();
        }
        private void lstMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpActivities.Visible = true;
        }

        private void bttnFind_Click(object sender, EventArgs e)
        {
            //get all activities with matching name
            grdActivity.DataSource = newActivity.findActivities(txtActivityName.Text).Tables["Act"];
            
            grdActivity.Visible = true;
        }

        private void grpActivities_Enter(object sender, EventArgs e)
        {

        }

        private void bttn_Click(object sender, EventArgs e)
        {
            if (txtActivityName.Text.Equals(""))
            {
                MessageBox.Show("Activity Name must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtActivityName.Focus();
                return;
            }
            if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("Description must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
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

            if (txtSpaces.Text.Equals(""))
            {
                MessageBox.Show("Availability must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSpaces.Focus();
                return;
            }
            if (txtDuration.Text.Equals(""))
            {
                MessageBox.Show("Duration must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuration.Focus();
            }

            //invoke insActivity()
            //Instantiate object variables

            newActivity.setActivity_Name(txtActivityName.Text);
            newActivity.setdescription(txtDescription.Text);
            newActivity.setDuration(Convert.ToInt32(txtDuration.Text));
            newActivity.setNo_Of_Spaces(Convert.ToInt32(txtNoOfSpaces.Text));
            newActivity.setAvailability(Convert.ToInt32(txtSpaces.Text));
            newActivity.setRate(Convert.ToInt32(txtRate.Text));

            MessageBox.Show("Activities Listed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtActivityName.Text = "";
            txtDescription.Text = "";
            txtNoOfSpaces.Text = "";
            txtSpaces.Text = "";
            txtRate.Text = "";
            txtDuration.Text = "";
            txtActivityName.Focus();
            grpActivities.Visible = false;
            grdActivity.Visible = false;
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

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void frmViewAllActivities_Load(object sender, EventArgs e)
        {

        }

        private void grdActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //get activity details
            newActivity.getActivity(Convert.ToInt32(grdActivity.Rows[grdActivity.CurrentCell.RowIndex].Cells[0].Value));
            //display details

            txtActivityName2.Text = newActivity.getActivity_Name();
            txtDescription.Text = newActivity.getDescription();
            txtDuration.Text = newActivity.getDuration().ToString();
            txtNoOfSpaces.Text = newActivity.getNo_Of_Spaces().ToString();
            txtSpaces.Text = newActivity.getAvailability().ToString();
            txtRate.Text = newActivity.getRate().ToString();
            grpActivities.Visible = true;
        }
    }
}
