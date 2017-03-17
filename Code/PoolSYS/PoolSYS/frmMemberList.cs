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
    public partial class frmMemberList : Form
    {
        public frmMemberList()
        {
            InitializeComponent();
        }

        private void frmMemberList_Load(object sender, EventArgs e)
        {
            FillGrid("Member_Id");
        }

        public void FillGrid(String SortOrder)
        {
            int intNextMemId;

            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT * FROM Members ORDER BY " + SortOrder;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //Create OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Mem");
            grdMember.DataSource = ds.Tables["Mem"];

            myConn.Close();
        }

        private void radMemId_Click(object sender, EventArgs e)
        {
            FillGrid("Member_Id");
        }

        private void radSurname_Click(object sender, EventArgs e)
        {
            FillGrid("Surname");
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

        private void grdMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
