namespace PoolSYS
{
    partial class frmListMembers
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
            this.lstMembers = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBlock = new System.Windows.Forms.Button();
            this.txtMemType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMem_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mmuMain = new System.Windows.Forms.MenuStrip();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.grpMember.SuspendLayout();
            this.mmuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMembers
            // 
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.Items.AddRange(new object[] {
            "0017 Walker        Anne         12/01/1978",
            "0004 Wilson       James        15/09/1992",
            "0007 Woods      Catherine  12/07/1995"});
            this.lstMembers.Location = new System.Drawing.Point(19, 75);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(407, 56);
            this.lstMembers.TabIndex = 45;
            this.lstMembers.Visible = false;
            this.lstMembers.SelectedIndexChanged += new System.EventHandler(this.lstMembers_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Enter Surname:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtSname);
            this.groupBox1.Controls.Add(this.lstMembers);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(13, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 185);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(371, 29);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(103, 22);
            this.btnFind.TabIndex = 48;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(118, 29);
            this.txtSname.MaxLength = 25;
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(209, 20);
            this.txtSname.TabIndex = 47;
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.radioButton2);
            this.grpMember.Controls.Add(this.radioButton1);
            this.grpMember.Controls.Add(this.label6);
            this.grpMember.Controls.Add(this.btnBlock);
            this.grpMember.Controls.Add(this.txtMemType);
            this.grpMember.Controls.Add(this.label4);
            this.grpMember.Controls.Add(this.txtDOB);
            this.grpMember.Controls.Add(this.label9);
            this.grpMember.Controls.Add(this.txtCounty);
            this.grpMember.Controls.Add(this.label11);
            this.grpMember.Controls.Add(this.label10);
            this.grpMember.Controls.Add(this.txtTown);
            this.grpMember.Controls.Add(this.txtAddress2);
            this.grpMember.Controls.Add(this.txtAddress);
            this.grpMember.Controls.Add(this.txtName);
            this.grpMember.Controls.Add(this.label3);
            this.grpMember.Controls.Add(this.label1);
            this.grpMember.Controls.Add(this.txtMem_id);
            this.grpMember.Controls.Add(this.label2);
            this.grpMember.Location = new System.Drawing.Point(13, 235);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(691, 288);
            this.grpMember.TabIndex = 49;
            this.grpMember.TabStop = false;
            this.grpMember.Visible = false;
            this.grpMember.Enter += new System.EventHandler(this.grpMember_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(576, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 48;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(503, 66);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 47;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Membership Blocked";
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(496, 235);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(76, 27);
            this.btnBlock.TabIndex = 45;
            this.btnBlock.Text = "Confirm";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // txtMemType
            // 
            this.txtMemType.Location = new System.Drawing.Point(503, 28);
            this.txtMemType.Name = "txtMemType";
            this.txtMemType.Size = new System.Drawing.Size(182, 20);
            this.txtMemType.TabIndex = 41;
            this.txtMemType.Text = "12 Months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Membership Type";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(108, 232);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(121, 20);
            this.txtDOB.TabIndex = 39;
            this.txtDOB.Text = "12/07/1995";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Date Of Birth";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(108, 194);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(121, 20);
            this.txtCounty.TabIndex = 33;
            this.txtCounty.Text = "Co.Kerry";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "County";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Town";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(108, 156);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(149, 20);
            this.txtTown.TabIndex = 30;
            this.txtTown.Text = "Tralee";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(108, 130);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(185, 20);
            this.txtAddress2.TabIndex = 29;
            this.txtAddress2.Text = "LakeLands";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(108, 98);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(238, 20);
            this.txtAddress.TabIndex = 28;
            this.txtAddress.Text = "141";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 27;
            this.txtName.Text = "Catherine Woods";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = " Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Members Name";
            // 
            // txtMem_id
            // 
            this.txtMem_id.Location = new System.Drawing.Point(108, 25);
            this.txtMem_id.Name = "txtMem_id";
            this.txtMem_id.Size = new System.Drawing.Size(66, 20);
            this.txtMem_id.TabIndex = 24;
            this.txtMem_id.Text = "0007";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Members_Id";
            // 
            // mmuMain
            // 
            this.mmuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.activitiesToolStripMenuItem});
            this.mmuMain.Location = new System.Drawing.Point(0, 0);
            this.mmuMain.Name = "mmuMain";
            this.mmuMain.Size = new System.Drawing.Size(716, 24);
            this.mmuMain.TabIndex = 50;
            this.mmuMain.Text = "menuStrip1";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.membersToolStripMenuItem.Text = "Back";
            this.membersToolStripMenuItem.Click += new System.EventHandler(this.membersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.activitiesToolStripMenuItem.Text = "Quit";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.activitiesToolStripMenuItem_Click);
            // 
            // frmListMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 525);
            this.Controls.Add(this.mmuMain);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListMembers";
            this.Text = "List Members";
            this.Load += new System.EventHandler(this.frmListMembers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.mmuMain.ResumeLayout(false);
            this.mmuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMembers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.TextBox txtMemType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMem_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip mmuMain;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
    }
}