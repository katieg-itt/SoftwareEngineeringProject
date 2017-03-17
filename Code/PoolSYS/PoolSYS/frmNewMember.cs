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
    public partial class frmNewMember : Form
    {
        frmMain parent;
        Member newMember = new Member();

        public frmNewMember()
        {
            InitializeComponent();
        }

        private void bttn_Click(object sender, EventArgs e)
        {
            if(txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }
            if (txtForename.Text.Equals("")) 
            {
                MessageBox.Show("Forename must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }
            if (txthouseNo.Text.Equals("")) 
            {
                MessageBox.Show("Address must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthouseNo.Focus();
                return;
            }
            if (txtStreet.Text.Equals("")) 
            {
                MessageBox.Show("Address must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }
            if (txtCounty.Text.Equals("")) 
            {
                MessageBox.Show("Forename must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Focus();
                return;
            }
            if (txtCounty.Text.Equals("")) 
            {
                MessageBox.Show("Town must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Focus();
                return;
            }
            if (txtPhone.Text.Equals("")) 
            {
                MessageBox.Show("Phone must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            if (txtEmail.Text.Equals("")) 
            {
                MessageBox.Show("Email must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            // save details in Member file
            newMember.setMemId(Convert.ToInt16(txtMemId.Text));
            newMember.setSurname(txtSurname.Text.ToUpper());
            newMember.setForename(txtForename.Text);
            newMember.setHouseNo(Convert.ToInt32(txthouseNo.Text));
            newMember.setStreet(txtStreet.Text);
            newMember.setTown(txtTown.Text);
            newMember.setCounty(txtCounty.Text);
            newMember.setPhone(txtPhone.Text);
            newMember.setEmail(txtEmail.Text);

            newMember.insMember();

            //display confirmation message
            MessageBox.Show("Member Added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //resetting the member object
            newMember = new Member();
            // reset ui
            txtMemId.Text = newMember.getNextMemId().ToString("0000");
            txtSurname.Text = "";
            txtForename.Text = "";
            txthouseNo.Text = "";
            txtStreet.Text = "";
            txtTown.Text = "";
            txtCounty.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";

            txtSurname.Focus();

         
        }

        private void frmNewMember_Load(object sender, EventArgs e)
        {
            txtMemId.Text = newMember.getNextMemId().ToString("0000");
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

        private void txtMemID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
