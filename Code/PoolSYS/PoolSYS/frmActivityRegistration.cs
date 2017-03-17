using System;
using System.Data.OracleClient;
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
    public partial class frmActivityRegistration : Form
    {
        Registration newReg = new Registration();
        Member newMember = new Member();
        Activity newActivity = new Activity();


        public frmActivityRegistration()
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
            grpReg.Visible = true;
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

        private void frmActivityRegistration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            findMembers(txtSrh.Text);
            grdMembers.Visible = true;
        }

        public void findMembers(String sname)
        {

            //Create database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);

            //Define Sql Query
            String strSQL = "Select Member_ID, Surname, Forename, Street From Members Where Surname LIKE '" + txtSrh.Text.ToUpper() + "%'";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //Create OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Mem");
            grdMembers.DataSource = ds.Tables["Mem"];

            myConn.Close();
        }

        private void grdMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpActivity.Visible = true;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            //instantiate object variables
            newReg.setRegistration_No(Convert.ToInt32(txtRegistration_No.Text));
            newReg.setMember_Id(Convert.ToInt32(txtMem_id.Text));
            newReg.setRegistration_Date(DateTime.Today.ToString("dd-MMM-yy"));
            newReg.setActivity_No(Convert.ToInt32(txtActNo.Text));

            if (!newReg.isRegistered(Convert.ToInt32(txtActNo.Text), Convert.ToInt32(txtMem_id.Text)))
            {
                //insert registraion into Registration Table
                newReg.insRegistration();

                //Reduce places available in activity
                newActivity.reducePlaces(Convert.ToInt32(txtActNo.Text));
                //Display confirmation message

                MessageBox.Show("Member Added to Activity Registration", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reset UI
                txtSrh.Text = "";
                txtActivityName.Text = "";
                txtMem_id.Text = newMember.getNextMemId().ToString("0000");
                txtName.Text = "";
                txtActNo.Text = newActivity.getNextActivity_No().ToString("0000");
                txtActivity.Text = "";
                txtAmount.Text = "";

                grpReg.Visible = false;
                grpActivity.Visible = false;
                grdMembers.Visible = false;
                grdActivity.Visible = false;
            }
            else
            {
                MessageBox.Show("Error Member is already registered to an Activity ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grdActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //puts values into required fields
            newActivity.getActivity(Convert.ToInt32(grdActivity.Rows[grdActivity.CurrentCell.RowIndex].Cells[0].Value));
            txtActivity.Text = newActivity.getActivity_Name();
            txtAmount.Text = newActivity.getRate().ToString();
            txtActNo.Text = newActivity.getActivity_No().ToString();
            txtAvail.Text = newActivity.getAvailability().ToString();

            newMember.getMember(Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value));
            txtMem_id.Text = newMember.getMemId().ToString();
            txtName.Text = newMember.getForename();

            txtRegDate.Text = DateTime.Now.ToString("dd-MMM-yy");
            txtRegistration_No.Text = newReg.getNextRegistration_No().ToString("0000");
            grpReg.Visible = true;

        }

        private void grpReg_Enter(object sender, EventArgs e)
        {

        }

        private void grpActivity_Enter(object sender, EventArgs e)
        {

        }

    }
}
