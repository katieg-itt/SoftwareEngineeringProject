namespace PoolSYS
{
    partial class frmAmendActivity
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
            this.txtSrh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mmuMain = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpActivity = new System.Windows.Forms.GroupBox();
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
            this.txtDesc = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtSrh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(21, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // grdActivity
            // 
            this.grdActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdActivity.Location = new System.Drawing.Point(9, 69);
            this.grdActivity.Name = "grdActivity";
            this.grdActivity.Size = new System.Drawing.Size(450, 86);
            this.grdActivity.TabIndex = 53;
            this.grdActivity.Visible = false;
            this.grdActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdActivity_CellContentClick);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(351, 28);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(85, 26);
            this.btnFind.TabIndex = 51;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSrh
            // 
            this.txtSrh.Location = new System.Drawing.Point(139, 31);
            this.txtSrh.Name = "txtSrh";
            this.txtSrh.Size = new System.Drawing.Size(176, 20);
            this.txtSrh.TabIndex = 49;
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
            // mmuMain
            // 
            this.mmuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.mmuMain.Location = new System.Drawing.Point(0, 0);
            this.mmuMain.Name = "mmuMain";
            this.mmuMain.Size = new System.Drawing.Size(749, 24);
            this.mmuMain.TabIndex = 50;
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
            this.grpActivity.Controls.Add(this.txtDesc);
            this.grpActivity.Controls.Add(this.txtDuration);
            this.grpActivity.Controls.Add(this.groupBox3);
            this.grpActivity.Controls.Add(this.txtRate);
            this.grpActivity.Controls.Add(this.label2);
            this.grpActivity.Controls.Add(this.txtSpaces);
            this.grpActivity.Controls.Add(this.txtNoOfSpaces);
            this.grpActivity.Controls.Add(this.txtActivityName2);
            this.grpActivity.Controls.Add(this.label1);
            this.grpActivity.Controls.Add(this.label4);
            this.grpActivity.Controls.Add(this.label11);
            this.grpActivity.Controls.Add(this.label10);
            this.grpActivity.Controls.Add(this.label6);
            this.grpActivity.Location = new System.Drawing.Point(21, 251);
            this.grpActivity.Name = "grpActivity";
            this.grpActivity.Size = new System.Drawing.Size(660, 406);
            this.grpActivity.TabIndex = 51;
            this.grpActivity.TabStop = false;
            this.grpActivity.Text = "Activity Details";
            this.grpActivity.Visible = false;
            this.grpActivity.Enter += new System.EventHandler(this.grpActivity_Enter);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(115, 176);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(94, 20);
            this.txtDuration.TabIndex = 60;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttn);
            this.groupBox3.Location = new System.Drawing.Point(538, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 93);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            // 
            // bttn
            // 
            this.bttn.Location = new System.Drawing.Point(18, 24);
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
            this.txtSpaces.Location = new System.Drawing.Point(115, 292);
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
            this.label10.Location = new System.Drawing.Point(14, 179);
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
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(104, 69);
            this.txtDesc.MaxLength = 75;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(185, 58);
            this.txtDesc.TabIndex = 62;
            // 
            // frmAmendActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 694);
            this.Controls.Add(this.grpActivity);
            this.Controls.Add(this.mmuMain);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAmendActivity";
            this.Text = "Amend Activity";
            this.Load += new System.EventHandler(this.frmAmendActivity_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtSrh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip mmuMain;
        private System.Windows.Forms.GroupBox grpActivity;
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
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdActivity;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtDesc;
    }
}