namespace PoolSYS
{
    partial class frmRegisterNewActivity
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
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.dtpStart_Date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtActNo = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttn = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoOfSpaces = new System.Windows.Forms.TextBox();
            this.txtActivityName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mmuMain = new System.Windows.Forms.MenuStrip();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mmuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDuration);
            this.groupBox1.Controls.Add(this.dtpStart_Date);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtActNo);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNoOfSpaces);
            this.groupBox1.Controls.Add(this.txtActivityName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 414);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(412, 154);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(113, 20);
            this.txtDuration.TabIndex = 3;
            // 
            // dtpStart_Date
            // 
            this.dtpStart_Date.Location = new System.Drawing.Point(104, 156);
            this.dtpStart_Date.MinDate = new System.DateTime(2016, 4, 12, 0, 0, 0, 0);
            this.dtpStart_Date.Name = "dtpStart_Date";
            this.dtpStart_Date.Size = new System.Drawing.Size(184, 20);
            this.dtpStart_Date.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Activity No";
            // 
            // txtActNo
            // 
            this.txtActNo.Enabled = false;
            this.txtActNo.Location = new System.Drawing.Point(414, 32);
            this.txtActNo.MaxLength = 30;
            this.txtActNo.Name = "txtActNo";
            this.txtActNo.Size = new System.Drawing.Size(47, 20);
            this.txtActNo.TabIndex = 61;
            this.txtActNo.TextChanged += new System.EventHandler(this.txtActNo_TextChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(105, 65);
            this.txtDesc.MaxLength = 75;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(194, 58);
            this.txtDesc.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttn);
            this.groupBox2.Location = new System.Drawing.Point(462, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 93);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            // 
            // bttn
            // 
            this.bttn.Location = new System.Drawing.Point(17, 19);
            this.bttn.Name = "bttn";
            this.bttn.Size = new System.Drawing.Size(81, 51);
            this.bttn.TabIndex = 0;
            this.bttn.Text = "Confirm";
            this.bttn.UseVisualStyleBackColor = true;
            this.bttn.Click += new System.EventHandler(this.bttn_Click);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(125, 277);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(94, 20);
            this.txtRate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Description";
            // 
            // txtNoOfSpaces
            // 
            this.txtNoOfSpaces.Location = new System.Drawing.Point(126, 215);
            this.txtNoOfSpaces.Name = "txtNoOfSpaces";
            this.txtNoOfSpaces.Size = new System.Drawing.Size(51, 20);
            this.txtNoOfSpaces.TabIndex = 4;
            // 
            // txtActivityName
            // 
            this.txtActivityName.Location = new System.Drawing.Point(104, 32);
            this.txtActivityName.MaxLength = 30;
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(195, 20);
            this.txtActivityName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Number of Spaces";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Duration (Weeks)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Activity Name";
            // 
            // mmuMain
            // 
            this.mmuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.activitiesToolStripMenuItem});
            this.mmuMain.Location = new System.Drawing.Point(0, 0);
            this.mmuMain.Name = "mmuMain";
            this.mmuMain.Size = new System.Drawing.Size(610, 24);
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
            // frmRegisterNewActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 460);
            this.Controls.Add(this.mmuMain);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegisterNewActivity";
            this.Text = "Register New Activity";
            this.Load += new System.EventHandler(this.frmRegisterNewActivity_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.mmuMain.ResumeLayout(false);
            this.mmuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActivityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttn;
        private System.Windows.Forms.MenuStrip mmuMain;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtNoOfSpaces;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtActNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStart_Date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuration;
    }
}