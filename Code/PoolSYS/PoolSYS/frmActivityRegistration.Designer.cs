namespace PoolSYS
{
    partial class frmActivityRegistration
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
            this.grpActivity = new System.Windows.Forms.GroupBox();
            this.grdActivity = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtActivityName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegistration_No = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpReg = new System.Windows.Forms.GroupBox();
            this.txtAvail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRegDate = new System.Windows.Forms.TextBox();
            this.txtActNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMem_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mmuMain = new System.Windows.Forms.MenuStrip();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.grdMembers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSrh = new System.Windows.Forms.TextBox();
            this.grpActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdActivity)).BeginInit();
            this.grpReg.SuspendLayout();
            this.mmuMain.SuspendLayout();
            this.grpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // grpActivity
            // 
            this.grpActivity.Controls.Add(this.grdActivity);
            this.grpActivity.Controls.Add(this.btnFind);
            this.grpActivity.Controls.Add(this.txtActivityName);
            this.grpActivity.Controls.Add(this.label5);
            this.grpActivity.Location = new System.Drawing.Point(12, 243);
            this.grpActivity.Name = "grpActivity";
            this.grpActivity.Size = new System.Drawing.Size(634, 170);
            this.grpActivity.TabIndex = 2;
            this.grpActivity.TabStop = false;
            this.grpActivity.Text = "Activity Details";
            this.grpActivity.Visible = false;
            this.grpActivity.Enter += new System.EventHandler(this.grpActivity_Enter);
            // 
            // grdActivity
            // 
            this.grdActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdActivity.Location = new System.Drawing.Point(24, 67);
            this.grdActivity.Name = "grdActivity";
            this.grdActivity.Size = new System.Drawing.Size(472, 82);
            this.grdActivity.TabIndex = 53;
            this.grdActivity.Visible = false;
            this.grdActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdActivity_CellClick);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(313, 29);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(74, 22);
            this.btnFind.TabIndex = 51;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtActivityName
            // 
            this.txtActivityName.Location = new System.Drawing.Point(139, 31);
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(154, 20);
            this.txtActivityName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Enter Activity Name";
            // 
            // txtRegistration_No
            // 
            this.txtRegistration_No.Enabled = false;
            this.txtRegistration_No.Location = new System.Drawing.Point(546, 36);
            this.txtRegistration_No.Name = "txtRegistration_No";
            this.txtRegistration_No.Size = new System.Drawing.Size(54, 20);
            this.txtRegistration_No.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Registration No";
            // 
            // grpReg
            // 
            this.grpReg.Controls.Add(this.txtAvail);
            this.grpReg.Controls.Add(this.label9);
            this.grpReg.Controls.Add(this.label8);
            this.grpReg.Controls.Add(this.txtRegDate);
            this.grpReg.Controls.Add(this.txtActNo);
            this.grpReg.Controls.Add(this.label7);
            this.grpReg.Controls.Add(this.txtRegistration_No);
            this.grpReg.Controls.Add(this.label4);
            this.grpReg.Controls.Add(this.txtActivity);
            this.grpReg.Controls.Add(this.label3);
            this.grpReg.Controls.Add(this.txtAmount);
            this.grpReg.Controls.Add(this.label6);
            this.grpReg.Controls.Add(this.btnConfirm);
            this.grpReg.Controls.Add(this.txtName);
            this.grpReg.Controls.Add(this.label1);
            this.grpReg.Controls.Add(this.txtMem_id);
            this.grpReg.Controls.Add(this.label2);
            this.grpReg.Location = new System.Drawing.Point(12, 428);
            this.grpReg.Name = "grpReg";
            this.grpReg.Size = new System.Drawing.Size(634, 206);
            this.grpReg.TabIndex = 52;
            this.grpReg.TabStop = false;
            this.grpReg.Text = "Confirm Registration";
            this.grpReg.Visible = false;
            this.grpReg.Enter += new System.EventHandler(this.grpReg_Enter);
            // 
            // txtAvail
            // 
            this.txtAvail.Enabled = false;
            this.txtAvail.Location = new System.Drawing.Point(111, 124);
            this.txtAvail.Name = "txtAvail";
            this.txtAvail.Size = new System.Drawing.Size(85, 20);
            this.txtAvail.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Availability";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Date";
            // 
            // txtRegDate
            // 
            this.txtRegDate.Enabled = false;
            this.txtRegDate.Location = new System.Drawing.Point(546, 72);
            this.txtRegDate.Name = "txtRegDate";
            this.txtRegDate.Size = new System.Drawing.Size(54, 20);
            this.txtRegDate.TabIndex = 58;
            // 
            // txtActNo
            // 
            this.txtActNo.Enabled = false;
            this.txtActNo.Location = new System.Drawing.Point(111, 72);
            this.txtActNo.Name = "txtActNo";
            this.txtActNo.Size = new System.Drawing.Size(63, 20);
            this.txtActNo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Activity No";
            // 
            // txtActivity
            // 
            this.txtActivity.Enabled = false;
            this.txtActivity.Location = new System.Drawing.Point(111, 98);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(185, 20);
            this.txtActivity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Activity";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(111, 147);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(82, 20);
            this.txtAmount.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Amount";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(534, 152);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(76, 27);
            this.btnConfirm.TabIndex = 45;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(108, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Members Name";
            // 
            // txtMem_id
            // 
            this.txtMem_id.Enabled = false;
            this.txtMem_id.Location = new System.Drawing.Point(108, 19);
            this.txtMem_id.Name = "txtMem_id";
            this.txtMem_id.Size = new System.Drawing.Size(66, 20);
            this.txtMem_id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 24);
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
            this.mmuMain.Size = new System.Drawing.Size(658, 24);
            this.mmuMain.TabIndex = 53;
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
            // grpMember
            // 
            this.grpMember.Controls.Add(this.grdMembers);
            this.grpMember.Controls.Add(this.button1);
            this.grpMember.Controls.Add(this.label12);
            this.grpMember.Controls.Add(this.txtSrh);
            this.grpMember.Location = new System.Drawing.Point(12, 65);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(634, 155);
            this.grpMember.TabIndex = 54;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Members Details";
            // 
            // grdMembers
            // 
            this.grdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMembers.Location = new System.Drawing.Point(20, 64);
            this.grdMembers.Name = "grdMembers";
            this.grdMembers.Size = new System.Drawing.Size(476, 77);
            this.grdMembers.TabIndex = 30;
            this.grdMembers.Visible = false;
            this.grdMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMembers_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Members Surname";
            // 
            // txtSrh
            // 
            this.txtSrh.Location = new System.Drawing.Point(111, 35);
            this.txtSrh.Name = "txtSrh";
            this.txtSrh.Size = new System.Drawing.Size(133, 20);
            this.txtSrh.TabIndex = 1;
            // 
            // frmActivityRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 646);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.mmuMain);
            this.Controls.Add(this.grpReg);
            this.Controls.Add(this.grpActivity);
            this.Name = "frmActivityRegistration";
            this.Text = "frmActivityRegistration";
            this.Load += new System.EventHandler(this.frmActivityRegistration_Load);
            this.grpActivity.ResumeLayout(false);
            this.grpActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdActivity)).EndInit();
            this.grpReg.ResumeLayout(false);
            this.grpReg.PerformLayout();
            this.mmuMain.ResumeLayout(false);
            this.mmuMain.PerformLayout();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpActivity;
        private System.Windows.Forms.TextBox txtActivityName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpReg;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMem_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.MenuStrip mmuMain;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdActivity;
        private System.Windows.Forms.TextBox txtRegistration_No;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.DataGridView grdMembers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSrh;
        private System.Windows.Forms.TextBox txtActNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRegDate;
        private System.Windows.Forms.TextBox txtAvail;
        private System.Windows.Forms.Label label9;
    }
}