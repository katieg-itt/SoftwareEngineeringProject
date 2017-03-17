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
    public partial class frmAmendMember : Form
    {
        Member newMember = new Member();

        public frmAmendMember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //validate data
            if (txtHouseNo.Text.Equals("")) 
            {
                MessageBox.Show("Address must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHouseNo.Focus();
                return;
            }
            if (txtStreet.Text.Equals("")) 
            {
                MessageBox.Show("Address must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }
            if (txtTown.Text.Equals("")) 
            {
                MessageBox.Show("Forename must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }
            if (txtCounty.Text.Equals("")) 
            {
                MessageBox.Show("Town must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Focus();
                return;
            }
            if (txtPhoneNo.Text.Equals("")) 
            {
                MessageBox.Show("Phone must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();
                return;
            }

            newMember.setSurname(txtSurname.Text);
            newMember.setForename(txtForename.Text);
            newMember.setHouseNo(Convert.ToInt32(txtHouseNo.Text));
            newMember.setStreet(txtStreet.Text);
            newMember.setTown(txtTown.Text);
            newMember.setCounty(txtCounty.Text);
            newMember.setPhone(txtPhoneNo.Text);

            newMember.updateMember();

            // display confirmation message
            MessageBox.Show("Member Amended", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            grpMember.Visible = false;
            grdMembers.Visible = false;

            txtSrh.Text = "";
            txtSrh.Focus();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void membersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var newfrm = new frmMain();
            newfrm.Show();
            this.Close();
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            findMembers(txtSrh.Text);
        }

        private void lstMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpMember.Visible = true;
        }

        private void grdMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(grdMembers.Rows[0].Cells[0].Value.ToString());

            //int memId = (int)grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value;
            newMember.getMember(Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value));

            //load instance variables into form controls
            txtSurname.Text = newMember.getSurname();
            txtForename.Text = newMember.getForename();
            txtHouseNo.Text = newMember.getHouseNo().ToString();
            txtStreet.Text = newMember.getStreet();
            txtTown.Text = newMember.getTown();
            txtCounty.Text = newMember.getCounty();
            txtStreet.Text = newMember.getStreet();
            txtPhoneNo.Text = newMember.getPhone();
            txtEmail.Text =  newMember.getEmail();



           if (newMember.getStatus().Equals("B"))
            {
                rbttnBlockedYes.Checked = true;
            }
            else
            {
                rbttnBlockedNo.Checked = true;
            } 


            grpMember.Visible = true;
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

        private void grdMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grpMember_Enter(object sender, EventArgs e)
        {

        }

        private void frmAmendMember_Load(object sender, EventArgs e)
        {

        }

        private void rbttnBlockedYes_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
