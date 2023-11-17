


namespace LocalChat
{
    partial class ChatFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatFrm));
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbMessages = new System.Windows.Forms.RichTextBox();
            this.tbUserMessage = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menýuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bizBaradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garaTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çykToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.Location = new System.Drawing.Point(11, 12);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(83, 25);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Ulanyjy";
            // 
            // tbMessages
            // 
            this.tbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessages.BackColor = System.Drawing.SystemColors.Menu;
            this.tbMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMessages.Location = new System.Drawing.Point(12, 47);
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ReadOnly = true;
            this.tbMessages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbMessages.Size = new System.Drawing.Size(495, 400);
            this.tbMessages.TabIndex = 3;
            this.tbMessages.Text = "";
            // 
            // tbUserMessage
            // 
            this.tbUserMessage.AcceptsReturn = true;
            this.tbUserMessage.AcceptsTab = true;
            this.tbUserMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserMessage.BackColor = System.Drawing.SystemColors.Menu;
            this.tbUserMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserMessage.Location = new System.Drawing.Point(12, 453);
            this.tbUserMessage.MaxLength = 140;
            this.tbUserMessage.MinimumSize = new System.Drawing.Size(4, 67);
            this.tbUserMessage.Multiline = true;
            this.tbUserMessage.Name = "tbUserMessage";
            this.tbUserMessage.Size = new System.Drawing.Size(409, 67);
            this.tbUserMessage.TabIndex = 2;
            this.tbUserMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserMessage_KeyPress);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Ýerli Çat";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menýuToolStripMenuItem,
            this.garaTemaToolStripMenuItem,
            this.çykToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 70);
            // 
            // menýuToolStripMenuItem
            // 
            this.menýuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bizBaradaToolStripMenuItem});
            this.menýuToolStripMenuItem.Name = "menýuToolStripMenuItem";
            this.menýuToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.menýuToolStripMenuItem.Text = "Menýu";
            // 
            // bizBaradaToolStripMenuItem
            // 
            this.bizBaradaToolStripMenuItem.Name = "bizBaradaToolStripMenuItem";
            this.bizBaradaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.bizBaradaToolStripMenuItem.Text = "Biz barada";
            // 
            // garaTemaToolStripMenuItem
            // 
            this.garaTemaToolStripMenuItem.Name = "garaTemaToolStripMenuItem";
            this.garaTemaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.garaTemaToolStripMenuItem.Text = "Gara tema";
            // 
            // çykToolStripMenuItem
            // 
            this.çykToolStripMenuItem.Name = "çykToolStripMenuItem";
            this.çykToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.çykToolStripMenuItem.Text = "Çyk";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::LocalChat.Properties.Resources.icons8_back_96px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(427, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 38);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LocalChat.Properties.Resources.icons8_email_send_96px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(427, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 66);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChatFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(519, 532);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.tbUserMessage);
            this.Controls.Add(this.lblUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(200, 300);
            this.Name = "ChatFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatFrm_FormClosing);
            this.Load += new System.EventHandler(this.ChatFrm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.RichTextBox tbMessages;
        private System.Windows.Forms.TextBox tbUserMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menýuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bizBaradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem garaTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çykToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}