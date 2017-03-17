namespace PoolSYS
{
    partial class frmViewAllActivities
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
            this.bttnFind = new System.Windows.Forms.Button();
            this.txtActivityName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpActivities = new System.Windows.Forms.GroupBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bttn = new System.Windows.Forms.Button();
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
            this.mmuMain = new System.Windows.Forms.MenuStrip();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdActivity)).BeginInit();
            this.grpActivities.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.mmuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdActivity);
            this.groupBox1.Controls.Add(this.bttnFind);
            this.groupBox1.Controls.Add(this.txtActivityName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(27, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // grdActivity
            // 
            this.grdActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdActivity.Location = new System.Drawing.Point(4, 78);
            this.grdActivity.Name = "grdActivity";
            this.grdActivity.Size = new System.Drawing.Size(450, 86);
            this.grdActivity.TabIndex = 52;
            this.grdActivity.Visible = false;
            this.grdActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdActivity_CellClick);
            // 
            // bttnFind
            // 
            this.bttnFind.Location = new System.Drawing.Point(375, 32);
            this.bttnFind.Name = "bttnFind";
            this.bttnFind.Size = new System.Drawing.Size(70, 19);
            this.bttnFind.TabIndex = 51;
            this.bttnFind.Text = "Find";
            this.bttnFind.UseVisualStyleBackColor = true;
            this.bttnFind.Click += new System.EventHandler(this.bttnFind_Click);
            // 
            // txtActivityName
            // 
            this.txtActivityName.Location = new System.Drawing.Point(139, 31);
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(209, 20);
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
            // grpActivities
            // 
            this.grpActivities.Controls.Add(this.txtDescription);
            this.grpActivities.Controls.Add(this.txtDuration);
            this.grpActivities.Controls.Add(this.groupBox3);
            this.grpActivities.Controls.Add(this.txtRate);
            this.grpActivities.Controls.Add(this.label2);
            this.grpActivities.Controls.Add(this.txtSpaces);
            this.grpActivities.Controls.Add(this.txtNoOfSpaces);
            this.grpActivities.Controls.Add(this.txtActivityName2);
            this.grpActivities.Controls.Add(this.label1);
            this.grpActivities.Controls.Add(this.label4);
            this.grpActivities.Controls.Add(this.label11);
            this.grpActivities.Controls.Add(this.label10);
            this.grpActivities.Controls.Add(this.label6);
            this.grpActivities.Location = new System.Drawing.Point(27, 223);
            this.grpActivities.Name = "grpActivities";
            this.grpActivities.Size = new System.Drawing.Size(545, 422);
            this.grpActivities.TabIndex = 50;
            this.grpActivities.TabStop = false;
            this.grpActivities.Visible = false;
            this.grpActivities.Enter += new System.EventHandler(this.grpActivities_Enter);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(107, 171);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(200, 20);
            this.txtDuration.TabIndex = 60;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttn);
            this.groupBox3.Location = new System.Drawing.Point(439, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(96, 83);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            // 
            // bttn
            // 
            this.bttn.Location = new System.Drawing.Point(6, 19);
            this.bttn.Name = "bttn";
            this.bttn.Size = new System.Drawing.Size(81, 51);
            this.bttn.TabIndex = 0;
            this.bttn.Text = "Confirm";
            this.bttn.UseVisualStyleBackColor = true;
            this.bttn.Click += new System.EventHandler(this.bttn_Click);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(115, 349);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(94, 20);
            this.txtRate.TabIndex = 58;
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
            // txtSpaces
            // 
            this.txtSpaces.Location = new System.Drawing.Point(115, 294);
            this.txtSpaces.Name = "txtSpaces";
            this.txtSpaces.Size = new System.Drawing.Size(51, 20);
            this.txtSpaces.TabIndex = 52;
            // 
            // txtNoOfSpaces
            // 
            this.txtNoOfSpaces.Location = new System.Drawing.Point(115, 246);
            this.txtNoOfSpaces.Name = "txtNoOfSpaces";
            this.txtNoOfSpaces.Size = new System.Drawing.Size(51, 20);
            this.txtNoOfSpaces.TabIndex = 51;
            // 
            // txtActivityName2
            // 
            this.txtActivityName2.Location = new System.Drawing.Point(104, 32);
            this.txtActivityName2.Name = "txtActivityName2";
            this.txtActivityName2.Size = new System.Drawing.Size(185, 20);
            this.txtActivityName2.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Spaces Avaliable";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Number of Spaces";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Duration (Weeks)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Activity Name";
            // 
            // mmuMain
            // 
            this.mmuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.activitiesToolStripMenuItem});
            this.mmuMain.Location = new System.Drawing.Point(0, 0);
            this.mmuMain.Name = "mmuMain";
            this.mmuMain.Size = new System.Drawing.Size(782, 24);
            this.mmuMain.TabIndex = 51;
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
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(104, 78);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(422, 20);
            this.txtDescription.TabIndex = 61;
            // 
            // frmViewAllActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 657);
            this.Controls.Add(this.mmuMain);
            this.Controls.Add(this.grpActivities);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmViewAllActivities";
            this.Text = "View All Activities";
            this.Load += new System.EventHandler(this.frmViewAllActivities_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdActivity)).EndInit();
            this.grpActivities.ResumeLayout(false);
            this.grpActivities.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.mmuMain.ResumeLayout(false);
            this.mmuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtActivityName;
        private System.Windows.Forms.GroupBox grpActivities;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bttn;
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
        private System.Windows.Forms.Button bttnFind;
        private System.Windows.Forms.MenuStrip mmuMain;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.DataGridView grdActivity;
        private System.Windows.Forms.TextBox txtDescription;
    }
}