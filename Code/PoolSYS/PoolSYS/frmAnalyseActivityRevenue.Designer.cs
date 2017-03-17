namespace PoolSYS
{
    partial class frmAnalyseActivityRevenue
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdActivity = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtActivityName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpActivityRevenue = new System.Windows.Forms.GroupBox();
            this.txtActivityID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpaces = new System.Windows.Forms.TextBox();
            this.txtNoOfSpaces = new System.Windows.Forms.TextBox();
            this.txtActivityName2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpCalculator = new System.Windows.Forms.GroupBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoOfActivities = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mmuMain = new System.Windows.Forms.MenuStrip();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bttnConfirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdActivity)).BeginInit();
            this.grpActivityRevenue.SuspendLayout();
            this.grpCalculator.SuspendLayout();
            this.mmuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdActivity);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtActivityName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activity Details";
            // 
            // grdActivity
            // 
            this.grdActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdActivity.Location = new System.Drawing.Point(9, 72);
            this.grdActivity.Name = "grdActivity";
            this.grdActivity.Size = new System.Drawing.Size(483, 82);
            this.grdActivity.TabIndex = 62;
            this.grdActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdActivity_CellClick);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(415, 31);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(77, 19);
            this.btnFind.TabIndex = 51;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtActivityName
            // 
            this.txtActivityName.Location = new System.Drawing.Point(139, 31);
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(267, 20);
            this.txtActivityName.TabIndex = 49;
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
            // grpActivityRevenue
            // 
            this.grpActivityRevenue.Controls.Add(this.txtActivityID);
            this.grpActivityRevenue.Controls.Add(this.label8);
            this.grpActivityRevenue.Controls.Add(this.txtDuration);
            this.grpActivityRevenue.Controls.Add(this.txtDesc);
            this.grpActivityRevenue.Controls.Add(this.btnEnter);
            this.grpActivityRevenue.Controls.Add(this.txtRate);
            this.grpActivityRevenue.Controls.Add(this.label2);
            this.grpActivityRevenue.Controls.Add(this.txtSpaces);
            this.grpActivityRevenue.Controls.Add(this.txtNoOfSpaces);
            this.grpActivityRevenue.Controls.Add(this.txtActivityName2);
            this.grpActivityRevenue.Controls.Add(this.label1);
            this.grpActivityRevenue.Controls.Add(this.label4);
            this.grpActivityRevenue.Controls.Add(this.label11);
            this.grpActivityRevenue.Controls.Add(this.label10);
            this.grpActivityRevenue.Controls.Add(this.label6);
            this.grpActivityRevenue.Location = new System.Drawing.Point(21, 226);
            this.grpActivityRevenue.Name = "grpActivityRevenue";
            this.grpActivityRevenue.Size = new System.Drawing.Size(460, 434);
            this.grpActivityRevenue.TabIndex = 54;
            this.grpActivityRevenue.TabStop = false;
            this.grpActivityRevenue.Visible = false;
            // 
            // txtActivityID
            // 
            this.txtActivityID.Location = new System.Drawing.Point(113, 51);
            this.txtActivityID.Name = "txtActivityID";
            this.txtActivityID.Size = new System.Drawing.Size(185, 20);
            this.txtActivityID.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Activity ID";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(113, 221);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(113, 20);
            this.txtDuration.TabIndex = 68;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(113, 114);
            this.txtDesc.MaxLength = 75;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(185, 58);
            this.txtDesc.TabIndex = 61;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(364, 340);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(81, 41);
            this.btnEnter.TabIndex = 59;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(124, 394);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(94, 20);
            this.txtRate.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Description";
            // 
            // txtSpaces
            // 
            this.txtSpaces.Location = new System.Drawing.Point(124, 337);
            this.txtSpaces.Name = "txtSpaces";
            this.txtSpaces.Size = new System.Drawing.Size(51, 20);
            this.txtSpaces.TabIndex = 52;
            // 
            // txtNoOfSpaces
            // 
            this.txtNoOfSpaces.Location = new System.Drawing.Point(124, 291);
            this.txtNoOfSpaces.Name = "txtNoOfSpaces";
            this.txtNoOfSpaces.Size = new System.Drawing.Size(51, 20);
            this.txtNoOfSpaces.TabIndex = 51;
            // 
            // txtActivityName2
            // 
            this.txtActivityName2.Location = new System.Drawing.Point(113, 77);
            this.txtActivityName2.Name = "txtActivityName2";
            this.txtActivityName2.Size = new System.Drawing.Size(185, 20);
            this.txtActivityName2.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Spaces Avaliable";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Number of Spaces";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Activity Name";
            // 
            // grpCalculator
            // 
            this.grpCalculator.Controls.Add(this.bttnConfirm);
            this.grpCalculator.Controls.Add(this.txtGross);
            this.grpCalculator.Controls.Add(this.label7);
            this.grpCalculator.Controls.Add(this.txtNoOfActivities);
            this.grpCalculator.Controls.Add(this.label3);
            this.grpCalculator.Location = new System.Drawing.Point(594, 347);
            this.grpCalculator.Name = "grpCalculator";
            this.grpCalculator.Size = new System.Drawing.Size(426, 282);
            this.grpCalculator.TabIndex = 60;
            this.grpCalculator.TabStop = false;
            this.grpCalculator.Text = "Activity Cost Calculation";
            this.grpCalculator.Visible = false;
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(165, 86);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(89, 20);
            this.txtGross.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Gross income for Activities";
            // 
            // txtNoOfActivities
            // 
            this.txtNoOfActivities.Location = new System.Drawing.Point(165, 31);
            this.txtNoOfActivities.Name = "txtNoOfActivities";
            this.txtNoOfActivities.Size = new System.Drawing.Size(58, 20);
            this.txtNoOfActivities.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Number of Activities";
            // 
            // mmuMain
            // 
            this.mmuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.activitiesToolStripMenuItem});
            this.mmuMain.Location = new System.Drawing.Point(0, 0);
            this.mmuMain.Name = "mmuMain";
            this.mmuMain.Size = new System.Drawing.Size(1119, 24);
            this.mmuMain.TabIndex = 61;
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
            // bttnConfirm
            // 
            this.bttnConfirm.Location = new System.Drawing.Point(325, 223);
            this.bttnConfirm.Name = "bttnConfirm";
            this.bttnConfirm.Size = new System.Drawing.Size(81, 41);
            this.bttnConfirm.TabIndex = 71;
            this.bttnConfirm.Text = "Confirm";
            this.bttnConfirm.UseVisualStyleBackColor = true;
            this.bttnConfirm.Click += new System.EventHandler(this.bttnConfirm_Click);
            // 
            // frmAnalyseActivityRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 672);
            this.Controls.Add(this.mmuMain);
            this.Controls.Add(this.grpCalculator);
            this.Controls.Add(this.grpActivityRevenue);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAnalyseActivityRevenue";
            this.Text = "Analyse Activity Revenue";
            this.Load += new System.EventHandler(this.frmAnalyseActivityRevenue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdActivity)).EndInit();
            this.grpActivityRevenue.ResumeLayout(false);
            this.grpActivityRevenue.PerformLayout();
            this.grpCalculator.ResumeLayout(false);
            this.grpCalculator.PerformLayout();
            this.mmuMain.ResumeLayout(false);
            this.mmuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtActivityName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpActivityRevenue;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpaces;
        private System.Windows.Forms.TextBox txtNoOfSpaces;
        private System.Windows.Forms.TextBox txtActivityName2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpCalculator;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoOfActivities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.MenuStrip mmuMain;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdActivity;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtActivityID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttnConfirm;
    }
}