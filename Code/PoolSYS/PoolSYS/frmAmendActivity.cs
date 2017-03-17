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
    public partial class frmAmendActivity : Form
    {
        Activity newActivity = new Activity();
        public frmAmendActivity()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            grdActivity.DataSource = newActivity.findActivities(txtSrh.Text).Tables["Act"];

            grdActivity.Visible = true;
        }

        private void lstActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpActivity.Visible = true;

        }

        private void bttn_Click(object sender, EventArgs e)
        {
            if (txtSrh.Text.Equals(""))
            {
                MessageBox.Show("Activity Name must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSrh.Focus();
                return;
            }
            if (txtDesc.Text.Equals(""))
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

            if (txtSpaces.Text.Equals(""))
            {
                MessageBox.Show("Spaces Available must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSpaces.Focus();
                return;
            }

            //invoke insActivity()
            //Instantiate object variables

            newActivity.setActivity_Name(txtSrh.Text);
            newActivity.setdescription(txtDesc.Text);
            newActivity.setDuration(Convert.ToInt32(txtDuration.Text));
            newActivity.setNo_Of_Spaces(Convert.ToInt32(txtNoOfSpaces.Text));
            newActivity.setAvailability(Convert.ToInt32(txtSpaces.Text));
            newActivity.setRate(Convert.ToInt32(txtRate.Text));

            newActivity.updateActivity();


            MessageBox.Show("Activity Amended", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtSrh.Text = "";
            txtDesc.Text = "";
            txtNoOfSpaces.Text = "";
            txtNoOfSpaces.Text = "";
            txtRate.Text = "";
            txtDuration.Text = "";
            grpActivity.Visible = false;
            grdActivity.Visible = false;

            txtSrh.Text = "";
            txtSrh.Focus();
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

        private void frmAmendActivity_Load(object sender, EventArgs e)
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
        public void findActivity(String name)
        {

            //Create database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);

            //Define Sql Query
            String strSQL = "Select Activity_No, Activity_No, Activity_Name, From Activities Where Activity_Name LIKE '" + txtSrh.Text.ToUpper() + "%'";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //Create OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Act");
            grdActivity.DataSource = ds.Tables["Act"];

            myConn.Close();
        }

        private void grdActivity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            newActivity.getActivity(Convert.ToInt32(grdActivity.Rows[grdActivity.CurrentCell.RowIndex].Cells[0].Value));

            //load instance variables into form controls
            txtSrh.Text = newActivity.getActivity_Name();
            txtActivityName2.Text = newActivity.getActivity_Name();
            txtDesc.Text = newActivity.getDescription();
            txtDuration.Text = newActivity.getDuration().ToString();
            txtNoOfSpaces.Text = newActivity.getNo_Of_Spaces().ToString();
            txtSpaces.Text = newActivity.getAvailability().ToString();
            txtRate.Text = newActivity.getRate().ToString();

            grpActivity.Visible = true;

        }

        private void grpActivity_Enter(object sender, EventArgs e)
        {

        }


    }
}
