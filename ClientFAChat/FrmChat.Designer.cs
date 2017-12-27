using System.Windows.Forms;

namespace FAChatClient
{
    partial class FrmChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChat));
            this.MenuStripClient = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.TabPagePublicChatClient = new System.Windows.Forms.TabPage();
            this.BtnSendPhotoPublic = new System.Windows.Forms.Button();
            this.RichTextClientPub = new System.Windows.Forms.RichTextBox();
            this.TextBoxPubMsg = new System.Windows.Forms.TextBox();
            this.BtnPubSnd = new System.Windows.Forms.Button();
            this.ListBoxClientList = new System.Windows.Forms.ListBox();
            this.BtnColorPick = new System.Windows.Forms.Button();
            this.TabControlClient = new System.Windows.Forms.TabControl();
            this.MenuStripClient.SuspendLayout();
            this.TabPagePublicChatClient.SuspendLayout();
            this.TabControlClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripClient
            // 
            this.MenuStripClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.chatToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStripClient.Location = new System.Drawing.Point(0, 0);
            this.MenuStripClient.Name = "MenuStripClient";
            this.MenuStripClient.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStripClient.Size = new System.Drawing.Size(778, 25);
            this.MenuStripClient.TabIndex = 6;
            this.MenuStripClient.Text = "MenuStripClient";
            this.MenuStripClient.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStripClient_ItemClicked);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaticsToolStripMenuItem,
            this.ReconnectToolStripMenuItem,
            this.DisconnectToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.FileToolStripMenuItem.Text = "Thao tác";
            // 
            // StaticsToolStripMenuItem
            // 
            this.StaticsToolStripMenuItem.Name = "StaticsToolStripMenuItem";
            this.StaticsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.StaticsToolStripMenuItem.Text = "Trạng thái";
            this.StaticsToolStripMenuItem.Click += new System.EventHandler(this.StaticsToolStripMenuItem_Click);
            // 
            // ReconnectToolStripMenuItem
            // 
            this.ReconnectToolStripMenuItem.Name = "ReconnectToolStripMenuItem";
            this.ReconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ReconnectToolStripMenuItem.Text = "Kết nối lại";
            this.ReconnectToolStripMenuItem.Click += new System.EventHandler(this.ReconnectToolStripMenuItem_Click);
            // 
            // DisconnectToolStripMenuItem
            // 
            this.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem";
            this.DisconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DisconnectToolStripMenuItem.Text = "Đóng kết nối";
            this.DisconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "Thoát";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ClickExitToolStripMenuItem);
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeNameToolStripMenuItem,
            this.ChangeColorToolStripMenuItem,
            this.receivedImagesToolStripMenuItem});
            this.chatToolStripMenuItem.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.chatToolStripMenuItem.Text = "&Chat";
            // 
            // ChangeNameToolStripMenuItem
            // 
            this.ChangeNameToolStripMenuItem.Name = "ChangeNameToolStripMenuItem";
            this.ChangeNameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ChangeNameToolStripMenuItem.Text = "Đổi tên";
            this.ChangeNameToolStripMenuItem.Click += new System.EventHandler(this.ChangeNameToolStripMenuItem_Click);
            // 
            // ChangeColorToolStripMenuItem
            // 
            this.ChangeColorToolStripMenuItem.Name = "ChangeColorToolStripMenuItem";
            this.ChangeColorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ChangeColorToolStripMenuItem.Text = "Đổi tên";
            this.ChangeColorToolStripMenuItem.Click += new System.EventHandler(this.ChangeColorToolStripMenuItem_Click);
            // 
            // receivedImagesToolStripMenuItem
            // 
            this.receivedImagesToolStripMenuItem.Name = "receivedImagesToolStripMenuItem";
            this.receivedImagesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.receivedImagesToolStripMenuItem.Text = "Hình đã nhận";
            this.receivedImagesToolStripMenuItem.Click += new System.EventHandler(this.receivedImagesToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.HelpToolStripMenuItem.Text = "Giúp đở";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AboutToolStripMenuItem.Text = "Giới thiệu";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // TabPagePublicChatClient
            // 
            this.TabPagePublicChatClient.Controls.Add(this.BtnSendPhotoPublic);
            this.TabPagePublicChatClient.Controls.Add(this.RichTextClientPub);
            this.TabPagePublicChatClient.Controls.Add(this.TextBoxPubMsg);
            this.TabPagePublicChatClient.Controls.Add(this.BtnPubSnd);
            this.TabPagePublicChatClient.Controls.Add(this.ListBoxClientList);
            this.TabPagePublicChatClient.Controls.Add(this.BtnColorPick);
            this.TabPagePublicChatClient.Location = new System.Drawing.Point(4, 28);
            this.TabPagePublicChatClient.Name = "TabPagePublicChatClient";
            this.TabPagePublicChatClient.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagePublicChatClient.Size = new System.Drawing.Size(713, 502);
            this.TabPagePublicChatClient.TabIndex = 10;
            this.TabPagePublicChatClient.Text = "Public Chat";
            this.TabPagePublicChatClient.UseVisualStyleBackColor = true;
            // 
            // BtnSendPhotoPublic
            // 
            this.BtnSendPhotoPublic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSendPhotoPublic.BackgroundImage")));
            this.BtnSendPhotoPublic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSendPhotoPublic.Location = new System.Drawing.Point(541, 464);
            this.BtnSendPhotoPublic.Name = "BtnSendPhotoPublic";
            this.BtnSendPhotoPublic.Size = new System.Drawing.Size(27, 29);
            this.BtnSendPhotoPublic.TabIndex = 9;
            this.BtnSendPhotoPublic.UseVisualStyleBackColor = true;
            this.BtnSendPhotoPublic.Click += new System.EventHandler(this.BtnSendPhotoPublic_Click);
            // 
            // RichTextClientPub
            // 
            this.RichTextClientPub.BackColor = System.Drawing.Color.White;
            this.RichTextClientPub.ForeColor = System.Drawing.Color.Black;
            this.RichTextClientPub.Location = new System.Drawing.Point(3, 3);
            this.RichTextClientPub.Name = "RichTextClientPub";
            this.RichTextClientPub.ReadOnly = true;
            this.RichTextClientPub.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextClientPub.Size = new System.Drawing.Size(595, 454);
            this.RichTextClientPub.TabIndex = 8;
            this.RichTextClientPub.Text = "";
            this.RichTextClientPub.TextChanged += new System.EventHandler(this.RichTextChatBoxText_Changed);
            // 
            // TextBoxPubMsg
            // 
            this.TextBoxPubMsg.Location = new System.Drawing.Point(3, 466);
            this.TextBoxPubMsg.Name = "TextBoxPubMsg";
            this.TextBoxPubMsg.Size = new System.Drawing.Size(530, 24);
            this.TextBoxPubMsg.TabIndex = 0;
            // 
            // BtnPubSnd
            // 
            this.BtnPubSnd.Location = new System.Drawing.Point(607, 464);
            this.BtnPubSnd.Name = "BtnPubSnd";
            this.BtnPubSnd.Size = new System.Drawing.Size(104, 29);
            this.BtnPubSnd.TabIndex = 1;
            this.BtnPubSnd.Text = "&Send";
            this.BtnPubSnd.UseVisualStyleBackColor = true;
            this.BtnPubSnd.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // ListBoxClientList
            // 
            this.ListBoxClientList.FormattingEnabled = true;
            this.ListBoxClientList.ItemHeight = 16;
            this.ListBoxClientList.Location = new System.Drawing.Point(607, 3);
            this.ListBoxClientList.Name = "ListBoxClientList";
            this.ListBoxClientList.Size = new System.Drawing.Size(101, 452);
            this.ListBoxClientList.TabIndex = 5;
            this.ListBoxClientList.DoubleClick += new System.EventHandler(this.ListBoxClientList_DoubleClick);
            // 
            // BtnColorPick
            // 
            this.BtnColorPick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnColorPick.BackgroundImage")));
            this.BtnColorPick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnColorPick.Location = new System.Drawing.Point(573, 464);
            this.BtnColorPick.Name = "BtnColorPick";
            this.BtnColorPick.Size = new System.Drawing.Size(27, 29);
            this.BtnColorPick.TabIndex = 2;
            this.BtnColorPick.UseVisualStyleBackColor = true;
            this.BtnColorPick.Click += new System.EventHandler(this.BtnColorPick_Click);
            // 
            // TabControlClient
            // 
            this.TabControlClient.Controls.Add(this.TabPagePublicChatClient);
            this.TabControlClient.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabControlClient.ItemSize = new System.Drawing.Size(80, 24);
            this.TabControlClient.Location = new System.Drawing.Point(3, 26);
            this.TabControlClient.Name = "TabControlClient";
            this.TabControlClient.SelectedIndex = 0;
            this.TabControlClient.Size = new System.Drawing.Size(721, 534);
            this.TabControlClient.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControlClient.TabIndex = 9;
            this.TabControlClient.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabControlClient_DrawItem);
            this.TabControlClient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabControlClient_MouseClick);
            // 
            // FrmChat
            // 
            this.AcceptButton = this.BtnPubSnd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(778, 560);
            this.Controls.Add(this.TabControlClient);
            this.Controls.Add(this.MenuStripClient);
            this.Font = new System.Drawing.Font("UTM Avo", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStripClient;
            this.MaximizeBox = false;
            this.Name = "FrmChat";
            this.Text = "Phòng Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmChat_FormClosing);
            this.Load += new System.EventHandler(this.FrmChat_Load);
            this.MenuStripClient.ResumeLayout(false);
            this.MenuStripClient.PerformLayout();
            this.TabPagePublicChatClient.ResumeLayout(false);
            this.TabPagePublicChatClient.PerformLayout();
            this.TabControlClient.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStripClient;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisconnectToolStripMenuItem;
        private ColorDialog ColorPicker;
        private ToolStripMenuItem ChangeColorToolStripMenuItem;
        private TabPage TabPagePublicChatClient;
        private RichTextBox RichTextClientPub;
        private TextBox TextBoxPubMsg;
        private Button BtnPubSnd;
        private ListBox ListBoxClientList;
        private Button BtnColorPick;
        private TabControl TabControlClient;
        private ToolStripMenuItem StaticsToolStripMenuItem;
        private ToolStripMenuItem receivedImagesToolStripMenuItem;
        private Button BtnSendPhotoPublic;
    }
}