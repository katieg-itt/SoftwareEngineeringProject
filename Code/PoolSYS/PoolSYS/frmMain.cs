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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void amendMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newfrm = new frmAmendMember();
            newfrm.Show();
            this.Hide();
        }

        private void blockMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newfrm = new frmBlockMember();
            newfrm.Show();
            this.Hide();
        }

        private void listMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newfrm = new frmMemberList();
            newfrm.Show();
            this.Hide();
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newfrm = new frmNewMember();
            newfrm.Show();
            this.Hide();
        }

        private void newActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newfrm = new frmRegisterNewActivity();
            newfrm.Show();
            this.Hide();
        }

        private void viewActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newfrm = new frmViewAllActivities();
            newfrm.Show();
            this.Hide();
        }

        private void amendActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newfrm = new frmAmendActivity();
            newfrm.Show();
            this.Hide();
        }

        private void activityRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newfrm = new frmActivityRegistration();
            newfrm.Show();
            this.Hide();
        }

        private void activityRotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newfrm = new frmActivityRota();
            newfrm.Show();
            this.Hide();
        }

        private void analyliseActivityRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newfrm = new frmAnalyseActivityRevenue();
            newfrm.Show();
            this.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
