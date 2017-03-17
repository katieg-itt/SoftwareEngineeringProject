namespace PoolSYS
{
    partial class frmActivityRota
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
            this.mmuMain = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpActivity = new System.Windows.Forms.GroupBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bttn = new System.Windows.Forms.Button();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.txtNoOfSpaces = new System.Windows.Forms.TextBox();
            this.txtActivityName2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdActivity)).BeginInit();
            this.mmuMain.SuspendLayout();
            this.grpActivity.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdActivity);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 149);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activity Details";
            // 
            // grdActivity
            // 
            this.grdActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdActivity.Location = new System.Drawing.Point(9, 30);
            this.grdActivity.Name = "grdActivity";
            this.grdActivity.Size = new System.Drawing.Size(445, 103);
            this.grdActivity.TabIndex = 54;
            this.grdActivity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdActivity_CellContentClick);
            // 
            // mmuMain
            // 
            this.mmuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.mmuMain.Location = new System.Drawing.Point(0, 0);
            this.mmuMain.Name = "mmuMain";
            this.mmuMain.Size = new System.Drawing.Size(512, 24);
            this.mmuMain.TabIndex = 52;
            this.mmuMain.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // grpActivity
            // 
            this.grpActivity.Controls.Add(this.txtDuration);
            this.grpActivity.Controls.Add(this.groupBox3);
            this.grpActivity.Controls.Add(this.txtAvailable);
            this.grpActivity.Controls.Add(this.txtNoOfSpaces);
            this.grpActivity.Controls.Add(this.txtActivityName2);
            this.grpActivity.Controls.Add(this.label4);
            this.grpActivity.Controls.Add(this.label11);
            this.grpActivity.Controls.Add(this.label10);
            this.grpActivity.Controls.Add(this.label6);
            this.grpActivity.Location = new System.Drawing.Point(12, 245);
            this.grpActivity.Name = "grpActivity";
            this.grpActivity.Size = new System.Drawing.Size(314, 342);
            this.grpActivity.TabIndex = 53;
            this.grpActivity.TabStop = false;
            this.grpActivity.Text = "Activity Details";
            this.grpActivity.Visible = false;
            this.grpActivity.Enter += new System.EventHandler(this.grpActivity_Enter_1);
            // 
            // txtDuration
            // 
            this.txtDuration.Enabled = false;
            this.txtDuration.Location = new System.Drawing.Point(115, 78);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(62, 20);
            this.txtDuration.TabIndex = 63;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttn);
            this.groupBox3.Location = new System.Drawing.Point(189, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 93);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            // 
            // bttn
            // 
            this.bttn.Location = new System.Drawing.Point(22, 19);
            this.bttn.Name = "bttn";
            this.bttn.Size = new System.Drawing.Size(81, 51);
            this.bttn.TabIndex = 0;
            this.bttn.Text = "Confirm";
            this.bttn.UseVisualStyleBackColor = true;
            this.bttn.Click += new System.EventHandler(this.bttn_Click);
            // 
            // txtAvailable
            // 
            this.txtAvailable.Enabled = false;
            this.txtAvailable.Location = new System.Drawing.Point(115, 167);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(51, 20);
            this.txtAvailable.TabIndex = 52;
            // 
            // txtNoOfSpaces
            // 
            this.txtNoOfSpaces.Enabled = false;
            this.txtNoOfSpaces.Location = new System.Drawing.Point(115, 123);
            this.txtNoOfSpaces.Name = "txtNoOfSpaces";
            this.txtNoOfSpaces.Size = new System.Drawing.Size(51, 20);
            this.txtNoOfSpaces.TabIndex = 51;
            // 
            // txtActivityName2
            // 
            this.txtActivityName2.Enabled = false;
            this.txtActivityName2.Location = new System.Drawing.Point(115, 32);
            this.txtActivityName2.Name = "txtActivityName2";
            this.txtActivityName2.Size = new System.Drawing.Size(185, 20);
            this.txtActivityName2.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Spaces Avaliable";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Number of Spaces";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Duration";
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
            // frmActivityRota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 598);
            this.Controls.Add(this.grpActivity);
            this.Controls.Add(this.mmuMain);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmActivityRota";
            this.Text = "Activity Rota";
            this.Load += new System.EventHandler(this.frmActivityRota_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdActivity)).EndInit();
            this.mmuMain.ResumeLayout(false);
            this.mmuMain.PerformLayout();
            this.grpActivity.ResumeLayout(false);
            this.grpActivity.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip mmuMain;
        private System.Windows.Forms.GroupBox grpActivity;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bttn;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.TextBox txtNoOfSpaces;
        private System.Windows.Forms.TextBox txtActivityName2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.DataGridView grdActivity;
    }
}