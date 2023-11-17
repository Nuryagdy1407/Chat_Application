namespace LocalChat
{
    partial class UserListFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.newUserCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.cmUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startEncryptedMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ulanyjylar:";
            // 
            // lbUsers
            // 
            this.lbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsers.BackColor = System.Drawing.SystemColors.Menu;
            this.lbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 20;
            this.lbUsers.Location = new System.Drawing.Point(11, 62);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(496, 444);
            this.lbUsers.TabIndex = 1;
            this.lbUsers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbUsers_KeyPress);
            this.lbUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbUsers_DoubleClick);
            this.lbUsers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbUsers_MouseDown);
            // 
            // newUserCheckTimer
            // 
            this.newUserCheckTimer.Tick += new System.EventHandler(this.newUserCheckTimer_Tick);
            // 
            // cmUser
            // 
            this.cmUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startEncryptedMessageToolStripMenuItem});
            this.cmUser.Name = "cmUser";
            this.cmUser.Size = new System.Drawing.Size(204, 26);
            this.cmUser.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmUser_ItemClicked);
            // 
            // startEncryptedMessageToolStripMenuItem
            // 
            this.startEncryptedMessageToolStripMenuItem.Name = "startEncryptedMessageToolStripMenuItem";
            this.startEncryptedMessageToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.startEncryptedMessageToolStripMenuItem.Text = "Start encrypted message";
            // 
            // UserListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(519, 532);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserListFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ýerli Çat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserListFrm_FrmClsing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.USERLISTFRM_FRMCLSD);
            this.Load += new System.EventHandler(this.UserListFrm_Load);
            this.cmUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Timer newUserCheckTimer;
        private System.Windows.Forms.ContextMenuStrip cmUser;
        private System.Windows.Forms.ToolStripMenuItem startEncryptedMessageToolStripMenuItem;
    }
}

