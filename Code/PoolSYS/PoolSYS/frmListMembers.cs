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
    public partial class frmListMembers : Form
    {
        public frmListMembers()
        {
            InitializeComponent();
        }

        private void frmListMembers_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lstMembers.Visible = true;
        }

        private void grpMember_Enter(object sender, EventArgs e)
        {
        }

        private void lstMembers_SelectedIndexChanged(object sender, EventArgs e)
        {

            grpMember.Visible = true;
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Members Listed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            grpMember.Visible = false;
            lstMembers.Visible = false;
            txtSname.Text = "";
            txtSname.Focus();
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
    }
}
