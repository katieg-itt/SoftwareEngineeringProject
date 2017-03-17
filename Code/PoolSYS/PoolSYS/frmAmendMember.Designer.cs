namespace PoolSYS
{
    partial class frmAmendMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConfirm = new System.Windows.Forms.Button();
            this.mmuMain = new System.Windows.Forms.MenuStrip();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdMembers = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSrh = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHouseNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbttnBlockedYes = new System.Windows.Forms.RadioButton();
            this.rbttnBlockedNo = new System.Windows.Forms.RadioButton();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mmuMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
            this.grpMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(358, 262);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(123, 33);
            this.btnConfirm.TabIndex = 28;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // mmuMain
            // 
            this.mmuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.activitiesToolStripMenuItem});
            this.mmuMain.Location = new System.Drawing.Point(0, 0);
            this.mmuMain.Name = "mmuMain";
            this.mmuMain.Size = new System.Drawing.Size(611, 24);
            this.mmuMain.TabIndex = 29;
            this.mmuMain.Text = "menuStrip1";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.membersToolStripMenuItem.Text = "Back";
            this.membersToolStripMenuItem.Click += new System.EventHandler(this.membersToolStripMenuItem_Click_1);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.activitiesToolStripMenuItem.Text = "Quit";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.activitiesToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdMembers);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtSrh);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 155);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Members Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grdMembers
            // 
            this.grdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMembers.Location = new System.Drawing.Point(20, 64);
            this.grdMembers.Name = "grdMembers";
            this.grdMembers.Size = new System.Drawing.Size(476, 77);
            this.grdMembers.TabIndex = 30;
            this.grdMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMembers_CellClick);
            this.grdMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMembers_CellContentClick);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(274, 35);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 29;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Members Surname";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSrh
            // 
            this.txtSrh.Location = new System.Drawing.Point(111, 35);
            this.txtSrh.Name = "txtSrh";
            this.txtSrh.Size = new System.Drawing.Size(133, 20);
            this.txtSrh.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "House No";
            // 
            // txtHouseNo
            // 
            this.txtHouseNo.Location = new System.Drawing.Point(130, 65);
            this.txtHouseNo.Name = "txtHouseNo";
            this.txtHouseNo.Size = new System.Drawing.Size(39, 20);
            this.txtHouseNo.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Phone Number";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(129, 204);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(133, 20);
            this.txtPhoneNo.TabIndex = 7;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(130, 92);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(155, 20);
            this.txtStreet.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Town";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(130, 130);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(155, 20);
            this.txtTown.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 162);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "County";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(130, 162);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(121, 20);
            this.txtCounty.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Blocked Membership";
            // 
            // rbttnBlockedYes
            // 
            this.rbttnBlockedYes.AutoSize = true;
            this.rbttnBlockedYes.Location = new System.Drawing.Point(127, 278);
            this.rbttnBlockedYes.Name = "rbttnBlockedYes";
            this.rbttnBlockedYes.Size = new System.Drawing.Size(43, 17);
            this.rbttnBlockedYes.TabIndex = 15;
            this.rbttnBlockedYes.Text = "Yes";
            this.rbttnBlockedYes.UseVisualStyleBackColor = true;
            this.rbttnBlockedYes.CheckedChanged += new System.EventHandler(this.rbttnBlockedYes_CheckedChanged);
            // 
            // rbttnBlockedNo
            // 
            this.rbttnBlockedNo.AutoSize = true;
            this.rbttnBlockedNo.Location = new System.Drawing.Point(184, 277);
            this.rbttnBlockedNo.Name = "rbttnBlockedNo";
            this.rbttnBlockedNo.Size = new System.Drawing.Size(39, 17);
            this.rbttnBlockedNo.TabIndex = 16;
            this.rbttnBlockedNo.Text = "No";
            this.rbttnBlockedNo.UseVisualStyleBackColor = true;
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.label4);
            this.grpMember.Controls.Add(this.txtForename);
            this.grpMember.Controls.Add(this.label3);
            this.grpMember.Controls.Add(this.txtSurname);
            this.grpMember.Controls.Add(this.txtEmail);
            this.grpMember.Controls.Add(this.label2);
            this.grpMember.Controls.Add(this.label1);
            this.grpMember.Controls.Add(this.txtCounty);
            this.grpMember.Controls.Add(this.txtTown);
            this.grpMember.Controls.Add(this.btnConfirm);
            this.grpMember.Controls.Add(this.txtStreet);
            this.grpMember.Controls.Add(this.rbttnBlockedNo);
            this.grpMember.Controls.Add(this.txtPhoneNo);
            this.grpMember.Controls.Add(this.rbttnBlockedYes);
            this.grpMember.Controls.Add(this.label16);
            this.grpMember.Controls.Add(this.label7);
            this.grpMember.Controls.Add(this.label14);
            this.grpMember.Controls.Add(this.txtHouseNo);
            this.grpMember.Controls.Add(this.label17);
            this.grpMember.Controls.Add(this.label13);
            this.grpMember.Location = new System.Drawing.Point(14, 198);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(546, 308);
            this.grpMember.TabIndex = 31;
            this.grpMember.TabStop = false;
            this.grpMember.Visible = false;
            this.grpMember.Enter += new System.EventHandler(this.grpMember_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Forename";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(357, 22);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(89, 20);
            this.txtForename.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(127, 19);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(89, 20);
            this.txtSurname.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 242);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(133, 20);
            this.txtEmail.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Street";
            // 
            // frmAmendMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 513);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mmuMain);
            this.Name = "frmAmendMember";
            this.Text = "Amend Member -Pool Sys";
            this.Load += new System.EventHandler(this.frmAmendMember_Load);
            this.mmuMain.ResumeLayout(false);
            this.mmuMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.MenuStrip mmuMain;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSrh;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.RadioButton rbttnBlockedNo;
        private System.Windows.Forms.RadioButton rbttnBlockedYes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtHouseNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.DataGridView grdMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
    }
}