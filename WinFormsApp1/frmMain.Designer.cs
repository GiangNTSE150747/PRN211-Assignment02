﻿namespace WinFormsApp1
{
    partial class frmMain : Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnMemberManagememt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnProductManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnOrderManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMemberManage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProductManagement = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOrderManagement = new System.Windows.Forms.ToolStripButton();
            this.pnContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(931, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogOut,
            this.btnExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.toolStripMenuItem1.Text = "System";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(143, 26);
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 26);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnMemberManagememt,
            this.tsBtnProductManagement,
            this.tsBtnOrderManagement});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(66, 24);
            this.toolStripMenuItem4.Text = "Action";
            // 
            // tsBtnMemberManagememt
            // 
            this.tsBtnMemberManagememt.Name = "tsBtnMemberManagememt";
            this.tsBtnMemberManagememt.Size = new System.Drawing.Size(240, 26);
            this.tsBtnMemberManagememt.Text = "Member Management";
            this.tsBtnMemberManagememt.Click += new System.EventHandler(this.tsBtnMemberManagememt_Click);
            // 
            // tsBtnProductManagement
            // 
            this.tsBtnProductManagement.Name = "tsBtnProductManagement";
            this.tsBtnProductManagement.Size = new System.Drawing.Size(240, 26);
            this.tsBtnProductManagement.Text = "Product Management";
            this.tsBtnProductManagement.Click += new System.EventHandler(this.tsBtnProductManagement_Click);
            // 
            // tsBtnOrderManagement
            // 
            this.tsBtnOrderManagement.Name = "tsBtnOrderManagement";
            this.tsBtnOrderManagement.Size = new System.Drawing.Size(240, 26);
            this.tsBtnOrderManagement.Text = "Order Management";
            this.tsBtnOrderManagement.Click += new System.EventHandler(this.tsBtnOrderManagement_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripSeparator4,
            this.toolStripMenuItem7});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItem5.Text = "Help";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(151, 26);
            this.toolStripMenuItem6.Text = "Guide";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(148, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(151, 26);
            this.toolStripMenuItem7.Text = "About us";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMemberManage,
            this.toolStripSeparator6,
            this.btnProductManagement,
            this.toolStripSeparator7,
            this.btnOrderManagement});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(931, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMemberManage
            // 
            this.btnMemberManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMemberManage.Image = ((System.Drawing.Image)(resources.GetObject("btnMemberManage.Image")));
            this.btnMemberManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMemberManage.Name = "btnMemberManage";
            this.btnMemberManage.Size = new System.Drawing.Size(161, 24);
            this.btnMemberManage.Text = "Member Management";
            this.btnMemberManage.Click += new System.EventHandler(this.btnMemberManage_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnProductManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnProductManagement.Image")));
            this.btnProductManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(156, 24);
            this.btnProductManagement.Text = "Product Management";
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOrderManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderManagement.Image")));
            this.btnOrderManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(143, 24);
            this.btnOrderManagement.Text = "Order Management";
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);
            // 
            // pnContent
            // 
            this.pnContent.Location = new System.Drawing.Point(3, 58);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(925, 590);
            this.pnContent.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 651);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStore";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem btnLogOut;
        private ToolStripMenuItem btnExit;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem tsBtnMemberManagememt;
        private ToolStripMenuItem tsBtnProductManagement;
        private ToolStripMenuItem tsBtnOrderManagement;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStrip toolStrip1;
        private ToolStripButton btnMemberManage;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton btnProductManagement;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton btnOrderManagement;
        private Panel pnContent;
    }
}