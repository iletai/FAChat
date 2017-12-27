﻿namespace FAChatServer
{
    partial class FrmData
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
            this.GrpBoxUsrSrch = new System.Windows.Forms.GroupBox();
            this.TxtBoxSrhLoggedLastLogged = new System.Windows.Forms.TextBox();
            this.TxtBoxSrhUserName = new System.Windows.Forms.TextBox();
            this.TxtBoxSrhID = new System.Windows.Forms.TextBox();
            this.BtnSrhName = new System.Windows.Forms.Button();
            this.BtnSrhUserName = new System.Windows.Forms.Button();
            this.BtnSrhID = new System.Windows.Forms.Button();
            this.GrpBoxMsgSrch = new System.Windows.Forms.GroupBox();
            this.TxtBoxPrivate = new System.Windows.Forms.TextBox();
            this.TxtBoxSrhDate = new System.Windows.Forms.TextBox();
            this.TxtBoxSrhKeyWord = new System.Windows.Forms.TextBox();
            this.BtnSrhPrivate = new System.Windows.Forms.Button();
            this.BtnSrhDate = new System.Windows.Forms.Button();
            this.BtnSrhKeyWord = new System.Windows.Forms.Button();
            this.DataGridClientsDB = new System.Windows.Forms.DataGridView();
            this.DataGridMessagesDB = new System.Windows.Forms.DataGridView();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.GrpBoxUsrSrch.SuspendLayout();
            this.GrpBoxMsgSrch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClientsDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMessagesDB)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBoxUsrSrch
            // 
            this.GrpBoxUsrSrch.Controls.Add(this.TxtBoxSrhLoggedLastLogged);
            this.GrpBoxUsrSrch.Controls.Add(this.TxtBoxSrhUserName);
            this.GrpBoxUsrSrch.Controls.Add(this.TxtBoxSrhID);
            this.GrpBoxUsrSrch.Controls.Add(this.BtnSrhName);
            this.GrpBoxUsrSrch.Controls.Add(this.BtnSrhUserName);
            this.GrpBoxUsrSrch.Controls.Add(this.BtnSrhID);
            this.GrpBoxUsrSrch.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBoxUsrSrch.Location = new System.Drawing.Point(12, 316);
            this.GrpBoxUsrSrch.Name = "GrpBoxUsrSrch";
            this.GrpBoxUsrSrch.Size = new System.Drawing.Size(311, 111);
            this.GrpBoxUsrSrch.TabIndex = 3;
            this.GrpBoxUsrSrch.TabStop = false;
            this.GrpBoxUsrSrch.Text = "Users Search";
            // 
            // TxtBoxSrhLoggedLastLogged
            // 
            this.TxtBoxSrhLoggedLastLogged.Location = new System.Drawing.Point(6, 79);
            this.TxtBoxSrhLoggedLastLogged.Name = "TxtBoxSrhLoggedLastLogged";
            this.TxtBoxSrhLoggedLastLogged.Size = new System.Drawing.Size(130, 23);
            this.TxtBoxSrhLoggedLastLogged.TabIndex = 9;
            // 
            // TxtBoxSrhUserName
            // 
            this.TxtBoxSrhUserName.Location = new System.Drawing.Point(6, 50);
            this.TxtBoxSrhUserName.Name = "TxtBoxSrhUserName";
            this.TxtBoxSrhUserName.Size = new System.Drawing.Size(130, 23);
            this.TxtBoxSrhUserName.TabIndex = 8;
            // 
            // TxtBoxSrhID
            // 
            this.TxtBoxSrhID.Location = new System.Drawing.Point(5, 21);
            this.TxtBoxSrhID.Name = "TxtBoxSrhID";
            this.TxtBoxSrhID.Size = new System.Drawing.Size(131, 23);
            this.TxtBoxSrhID.TabIndex = 7;
            // 
            // BtnSrhName
            // 
            this.BtnSrhName.Location = new System.Drawing.Point(139, 77);
            this.BtnSrhName.Name = "BtnSrhName";
            this.BtnSrhName.Size = new System.Drawing.Size(167, 23);
            this.BtnSrhName.TabIndex = 6;
            this.BtnSrhName.Text = "Search by &Logged/Last Logged";
            this.BtnSrhName.UseVisualStyleBackColor = true;
            this.BtnSrhName.Click += new System.EventHandler(this.BtnSrhName_Click);
            // 
            // BtnSrhUserName
            // 
            this.BtnSrhUserName.Location = new System.Drawing.Point(139, 48);
            this.BtnSrhUserName.Name = "BtnSrhUserName";
            this.BtnSrhUserName.Size = new System.Drawing.Size(167, 23);
            this.BtnSrhUserName.TabIndex = 5;
            this.BtnSrhUserName.Text = "Search by &User Name";
            this.BtnSrhUserName.UseVisualStyleBackColor = true;
            this.BtnSrhUserName.Click += new System.EventHandler(this.BtnSrhUserName_Click);
            // 
            // BtnSrhID
            // 
            this.BtnSrhID.Location = new System.Drawing.Point(139, 19);
            this.BtnSrhID.Name = "BtnSrhID";
            this.BtnSrhID.Size = new System.Drawing.Size(167, 23);
            this.BtnSrhID.TabIndex = 4;
            this.BtnSrhID.Text = "Search by &ID";
            this.BtnSrhID.UseVisualStyleBackColor = true;
            this.BtnSrhID.Click += new System.EventHandler(this.BtnSrhID_Click);
            // 
            // GrpBoxMsgSrch
            // 
            this.GrpBoxMsgSrch.Controls.Add(this.TxtBoxPrivate);
            this.GrpBoxMsgSrch.Controls.Add(this.TxtBoxSrhDate);
            this.GrpBoxMsgSrch.Controls.Add(this.TxtBoxSrhKeyWord);
            this.GrpBoxMsgSrch.Controls.Add(this.BtnSrhPrivate);
            this.GrpBoxMsgSrch.Controls.Add(this.BtnSrhDate);
            this.GrpBoxMsgSrch.Controls.Add(this.BtnSrhKeyWord);
            this.GrpBoxMsgSrch.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBoxMsgSrch.Location = new System.Drawing.Point(793, 316);
            this.GrpBoxMsgSrch.Name = "GrpBoxMsgSrch";
            this.GrpBoxMsgSrch.Size = new System.Drawing.Size(342, 111);
            this.GrpBoxMsgSrch.TabIndex = 7;
            this.GrpBoxMsgSrch.TabStop = false;
            this.GrpBoxMsgSrch.Text = "Messages Search";
            // 
            // TxtBoxPrivate
            // 
            this.TxtBoxPrivate.Location = new System.Drawing.Point(6, 79);
            this.TxtBoxPrivate.Name = "TxtBoxPrivate";
            this.TxtBoxPrivate.Size = new System.Drawing.Size(199, 23);
            this.TxtBoxPrivate.TabIndex = 12;
            // 
            // TxtBoxSrhDate
            // 
            this.TxtBoxSrhDate.Location = new System.Drawing.Point(6, 50);
            this.TxtBoxSrhDate.Name = "TxtBoxSrhDate";
            this.TxtBoxSrhDate.Size = new System.Drawing.Size(199, 23);
            this.TxtBoxSrhDate.TabIndex = 11;
            // 
            // TxtBoxSrhKeyWord
            // 
            this.TxtBoxSrhKeyWord.Location = new System.Drawing.Point(6, 21);
            this.TxtBoxSrhKeyWord.Name = "TxtBoxSrhKeyWord";
            this.TxtBoxSrhKeyWord.Size = new System.Drawing.Size(199, 23);
            this.TxtBoxSrhKeyWord.TabIndex = 10;
            // 
            // BtnSrhPrivate
            // 
            this.BtnSrhPrivate.Location = new System.Drawing.Point(209, 77);
            this.BtnSrhPrivate.Name = "BtnSrhPrivate";
            this.BtnSrhPrivate.Size = new System.Drawing.Size(127, 23);
            this.BtnSrhPrivate.TabIndex = 6;
            this.BtnSrhPrivate.Text = "Search by Private";
            this.BtnSrhPrivate.UseVisualStyleBackColor = true;
            this.BtnSrhPrivate.Click += new System.EventHandler(this.BtnSrhPrivate_Click);
            // 
            // BtnSrhDate
            // 
            this.BtnSrhDate.Location = new System.Drawing.Point(209, 48);
            this.BtnSrhDate.Name = "BtnSrhDate";
            this.BtnSrhDate.Size = new System.Drawing.Size(127, 23);
            this.BtnSrhDate.TabIndex = 5;
            this.BtnSrhDate.Text = "Search by &Date";
            this.BtnSrhDate.UseVisualStyleBackColor = true;
            this.BtnSrhDate.Click += new System.EventHandler(this.BtnSrhDate_Click);
            // 
            // BtnSrhKeyWord
            // 
            this.BtnSrhKeyWord.Location = new System.Drawing.Point(209, 19);
            this.BtnSrhKeyWord.Name = "BtnSrhKeyWord";
            this.BtnSrhKeyWord.Size = new System.Drawing.Size(127, 23);
            this.BtnSrhKeyWord.TabIndex = 4;
            this.BtnSrhKeyWord.Text = "Search by &Key word";
            this.BtnSrhKeyWord.UseVisualStyleBackColor = true;
            this.BtnSrhKeyWord.Click += new System.EventHandler(this.BtnSrhKeyWord_Click);
            // 
            // DataGridClientsDB
            // 
            this.DataGridClientsDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridClientsDB.Location = new System.Drawing.Point(12, 12);
            this.DataGridClientsDB.Name = "DataGridClientsDB";
            this.DataGridClientsDB.Size = new System.Drawing.Size(543, 298);
            this.DataGridClientsDB.TabIndex = 0;
            // 
            // DataGridMessagesDB
            // 
            this.DataGridMessagesDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMessagesDB.Location = new System.Drawing.Point(561, 12);
            this.DataGridMessagesDB.Name = "DataGridMessagesDB";
            this.DataGridMessagesDB.Size = new System.Drawing.Size(574, 298);
            this.DataGridMessagesDB.TabIndex = 1;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Location = new System.Drawing.Point(500, 335);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(126, 71);
            this.BtnRefresh.TabIndex = 2;
            this.BtnRefresh.Text = "&Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // FrmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 433);
            this.Controls.Add(this.DataGridClientsDB);
            this.Controls.Add(this.DataGridMessagesDB);
            this.Controls.Add(this.GrpBoxMsgSrch);
            this.Controls.Add(this.GrpBoxUsrSrch);
            this.Controls.Add(this.BtnRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmData";
            this.Text = "FrmHisotry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHisotry_FormClosing);
            this.Load += new System.EventHandler(this.FrmHisotry_Load);
            this.Shown += new System.EventHandler(this.FrmData_Shown);
            this.GrpBoxUsrSrch.ResumeLayout(false);
            this.GrpBoxUsrSrch.PerformLayout();
            this.GrpBoxMsgSrch.ResumeLayout(false);
            this.GrpBoxMsgSrch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClientsDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMessagesDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridClientsDB;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.DataGridView DataGridMessagesDB;
        private System.Windows.Forms.Button BtnSrhName;
        private System.Windows.Forms.Button BtnSrhUserName;
        private System.Windows.Forms.Button BtnSrhID;
        private System.Windows.Forms.Button BtnSrhPrivate;
        private System.Windows.Forms.Button BtnSrhDate;
        private System.Windows.Forms.Button BtnSrhKeyWord;
        private System.Windows.Forms.TextBox TxtBoxSrhLoggedLastLogged;
        private System.Windows.Forms.TextBox TxtBoxSrhUserName;
        private System.Windows.Forms.TextBox TxtBoxSrhID;
        private System.Windows.Forms.TextBox TxtBoxPrivate;
        private System.Windows.Forms.TextBox TxtBoxSrhDate;
        private System.Windows.Forms.TextBox TxtBoxSrhKeyWord;
        private System.Windows.Forms.GroupBox GrpBoxUsrSrch;
        private System.Windows.Forms.GroupBox GrpBoxMsgSrch;
    }
}