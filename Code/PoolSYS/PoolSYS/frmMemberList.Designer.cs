namespace PoolSYS
{
    partial class frmMemberList
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
            this.grdMember = new System.Windows.Forms.DataGridView();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.radSurname = new System.Windows.Forms.RadioButton();
            this.radMemId = new System.Windows.Forms.RadioButton();
            this.mmuMain = new System.Windows.Forms.MenuStrip();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdMember)).BeginInit();
            this.grpOrder.SuspendLayout();
            this.mmuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdMember
            // 
            this.grdMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMember.Location = new System.Drawing.Point(18, 127);
            this.grdMember.Name = "grdMember";
            this.grdMember.Size = new System.Drawing.Size(681, 163);
            this.grdMember.TabIndex = 0;
            this.grdMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMember_CellContentClick);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.radSurname);
            this.grpOrder.Controls.Add(this.radMemId);
            this.grpOrder.Location = new System.Drawing.Point(18, 31);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(329, 74);
            this.grpOrder.TabIndex = 3;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order By";
            // 
            // radSurname
            // 
            this.radSurname.AutoSize = true;
            this.radSurname.Location = new System.Drawing.Point(111, 19);
            this.radSurname.Name = "radSurname";
            this.radSurname.Size = new System.Drawing.Size(67, 17);
            this.radSurname.TabIndex = 4;
            this.radSurname.TabStop = true;
            this.radSurname.Text = "Surname";
            this.radSurname.UseVisualStyleBackColor = true;
            this.radSurname.Click += new System.EventHandler(this.radSurname_Click);
            // 
            // radMemId
            // 
            this.radMemId.AutoSize = true;
            this.radMemId.Checked = true;
            this.radMemId.Location = new System.Drawing.Point(6, 19);
            this.radMemId.Name = "radMemId";
            this.radMemId.Size = new System.Drawing.Size(75, 17);
            this.radMemId.TabIndex = 3;
            this.radMemId.TabStop = true;
            this.radMemId.Text = "Member Id";
            this.radMemId.UseVisualStyleBackColor = true;
            this.radMemId.Click += new System.EventHandler(this.radMemId_Click);
            // 
            // mmuMain
            // 
            this.mmuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.activitiesToolStripMenuItem});
            this.mmuMain.Location = new System.Drawing.Point(0, 0);
            this.mmuMain.Name = "mmuMain";
            this.mmuMain.Size = new System.Drawing.Size(715, 24);
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
            // frmMemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 335);
            this.Controls.Add(this.mmuMain);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grdMember);
            this.Name = "frmMemberList";
            this.Text = "Member List";
            this.Load += new System.EventHandler(this.frmMemberList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMember)).EndInit();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.mmuMain.ResumeLayout(false);
            this.mmuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMember;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.RadioButton radSurname;
        private System.Windows.Forms.RadioButton radMemId;
        private System.Windows.Forms.MenuStrip mmuMain;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
    }
}