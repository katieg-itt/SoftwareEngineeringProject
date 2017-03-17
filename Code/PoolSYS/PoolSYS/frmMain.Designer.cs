namespace PoolSYS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mmuMain = new System.Windows.Forms.MenuStrip();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amendMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amendActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityRotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyliseActivityRevenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.mmuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // mmuMain
            // 
            this.mmuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.registrationsToolStripMenuItem,
            this.mnuExit});
            this.mmuMain.Location = new System.Drawing.Point(0, 0);
            this.mmuMain.Name = "mmuMain";
            this.mmuMain.Size = new System.Drawing.Size(750, 24);
            this.mmuMain.TabIndex = 0;
            this.mmuMain.Text = "menuStrip1";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMemberToolStripMenuItem,
            this.amendMemberToolStripMenuItem,
            this.blockMemberToolStripMenuItem,
            this.listMemberToolStripMenuItem});
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.membersToolStripMenuItem.Text = "Members";
            this.membersToolStripMenuItem.Click += new System.EventHandler(this.membersToolStripMenuItem_Click);
            // 
            // amendMemberToolStripMenuItem
            // 
            this.amendMemberToolStripMenuItem.Name = "amendMemberToolStripMenuItem";
            this.amendMemberToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.amendMemberToolStripMenuItem.Text = "Amend Member";
            this.amendMemberToolStripMenuItem.Click += new System.EventHandler(this.amendMemberToolStripMenuItem_Click);
            // 
            // blockMemberToolStripMenuItem
            // 
            this.blockMemberToolStripMenuItem.Name = "blockMemberToolStripMenuItem";
            this.blockMemberToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.blockMemberToolStripMenuItem.Text = "Block Member";
            this.blockMemberToolStripMenuItem.Click += new System.EventHandler(this.blockMemberToolStripMenuItem_Click);
            // 
            // listMemberToolStripMenuItem
            // 
            this.listMemberToolStripMenuItem.Name = "listMemberToolStripMenuItem";
            this.listMemberToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.listMemberToolStripMenuItem.Text = "List Member";
            this.listMemberToolStripMenuItem.Click += new System.EventHandler(this.listMemberToolStripMenuItem_Click);
            // 
            // newMemberToolStripMenuItem
            // 
            this.newMemberToolStripMenuItem.Name = "newMemberToolStripMenuItem";
            this.newMemberToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newMemberToolStripMenuItem.Text = "New Member";
            this.newMemberToolStripMenuItem.Click += new System.EventHandler(this.newMemberToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newActivityToolStripMenuItem,
            this.viewActivityToolStripMenuItem,
            this.amendActivityToolStripMenuItem});
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // newActivityToolStripMenuItem
            // 
            this.newActivityToolStripMenuItem.Name = "newActivityToolStripMenuItem";
            this.newActivityToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newActivityToolStripMenuItem.Text = "New Activity";
            this.newActivityToolStripMenuItem.Click += new System.EventHandler(this.newActivityToolStripMenuItem_Click);
            // 
            // viewActivityToolStripMenuItem
            // 
            this.viewActivityToolStripMenuItem.Name = "viewActivityToolStripMenuItem";
            this.viewActivityToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.viewActivityToolStripMenuItem.Text = "View Activity";
            this.viewActivityToolStripMenuItem.Click += new System.EventHandler(this.viewActivityToolStripMenuItem_Click);
            // 
            // amendActivityToolStripMenuItem
            // 
            this.amendActivityToolStripMenuItem.Name = "amendActivityToolStripMenuItem";
            this.amendActivityToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.amendActivityToolStripMenuItem.Text = "Amend Activity";
            this.amendActivityToolStripMenuItem.Click += new System.EventHandler(this.amendActivityToolStripMenuItem_Click);
            // 
            // registrationsToolStripMenuItem
            // 
            this.registrationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activityRegistrationToolStripMenuItem,
            this.activityRotaToolStripMenuItem,
            this.analyliseActivityRevenueToolStripMenuItem});
            this.registrationsToolStripMenuItem.Name = "registrationsToolStripMenuItem";
            this.registrationsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.registrationsToolStripMenuItem.Text = "Registrations";
            // 
            // activityRegistrationToolStripMenuItem
            // 
            this.activityRegistrationToolStripMenuItem.Name = "activityRegistrationToolStripMenuItem";
            this.activityRegistrationToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.activityRegistrationToolStripMenuItem.Text = "Activity Registration";
            this.activityRegistrationToolStripMenuItem.Click += new System.EventHandler(this.activityRegistrationToolStripMenuItem_Click);
            // 
            // activityRotaToolStripMenuItem
            // 
            this.activityRotaToolStripMenuItem.Name = "activityRotaToolStripMenuItem";
            this.activityRotaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.activityRotaToolStripMenuItem.Text = "Activity Rota";
            this.activityRotaToolStripMenuItem.Click += new System.EventHandler(this.activityRotaToolStripMenuItem_Click);
            // 
            // analyliseActivityRevenueToolStripMenuItem
            // 
            this.analyliseActivityRevenueToolStripMenuItem.Name = "analyliseActivityRevenueToolStripMenuItem";
            this.analyliseActivityRevenueToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.analyliseActivityRevenueToolStripMenuItem.Text = "Analylise Activity Revenue";
            this.analyliseActivityRevenueToolStripMenuItem.Click += new System.EventHandler(this.analyliseActivityRevenueToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // picMain
            // 
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(15, 72);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(723, 416);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 1;
            this.picMain.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 505);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.mmuMain);
            this.MainMenuStrip = this.mmuMain;
            this.Name = "frmMain";
            this.Text = "Pool Sys - Main Menu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mmuMain.ResumeLayout(false);
            this.mmuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mmuMain;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.ToolStripMenuItem amendMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newActivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewActivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amendActivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityRotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyliseActivityRevenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMemberToolStripMenuItem;
    }
}

