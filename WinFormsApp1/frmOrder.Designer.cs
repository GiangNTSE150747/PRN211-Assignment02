﻿namespace WinFormsApp1
{
    partial class frmOrder
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbFreight = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.lbHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(424, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 29);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(230, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 29);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoad.Location = new System.Drawing.Point(36, 302);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(146, 29);
            this.btnLoad.TabIndex = 37;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFreight
            // 
            this.txtFreight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFreight.Location = new System.Drawing.Point(544, 257);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.ReadOnly = true;
            this.txtFreight.Size = new System.Drawing.Size(226, 27);
            this.txtFreight.TabIndex = 35;
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtShippedDate.Location = new System.Drawing.Point(544, 216);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.ReadOnly = true;
            this.txtShippedDate.Size = new System.Drawing.Size(226, 27);
            this.txtShippedDate.TabIndex = 34;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRequiredDate.Location = new System.Drawing.Point(544, 175);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.ReadOnly = true;
            this.txtRequiredDate.Size = new System.Drawing.Size(226, 27);
            this.txtRequiredDate.TabIndex = 33;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMemberId.Location = new System.Drawing.Point(138, 214);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.ReadOnly = true;
            this.txtMemberId.Size = new System.Drawing.Size(226, 27);
            this.txtMemberId.TabIndex = 32;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderId.Location = new System.Drawing.Point(138, 175);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(226, 27);
            this.txtOrderId.TabIndex = 31;
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(425, 219);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(100, 20);
            this.lbShippedDate.TabIndex = 30;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // lbMemberId
            // 
            this.lbMemberId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Location = new System.Drawing.Point(31, 221);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(84, 20);
            this.lbMemberId.TabIndex = 29;
            this.lbMemberId.Text = "Member ID";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(31, 260);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(83, 20);
            this.lbOrderDate.TabIndex = 28;
            this.lbOrderDate.Text = "Order Date";
            // 
            // lbFreight
            // 
            this.lbFreight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(425, 260);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(55, 20);
            this.lbFreight.TabIndex = 27;
            this.lbFreight.Text = "Freight";
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(425, 178);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(105, 20);
            this.lbRequiredDate.TabIndex = 26;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // lbOrderId
            // 
            this.lbOrderId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(31, 182);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(66, 20);
            this.lbOrderId.TabIndex = 25;
            this.lbOrderId.Text = "Order ID";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(-1, 354);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 29;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(799, 132);
            this.dgvOrderList.TabIndex = 24;
            this.dgvOrderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellDoubleClick);
            // 
            // lbHeader
            // 
            this.lbHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHeader.Location = new System.Drawing.Point(200, 21);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(423, 50);
            this.lbHeader.TabIndex = 23;
            this.lbHeader.Text = "ORDER MANAGEMENT";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(32, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 2);
            this.panel1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Statistic:";
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReport.Location = new System.Drawing.Point(675, 92);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(94, 29);
            this.btnReport.TabIndex = 42;
            this.btnReport.Text = "View report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox2.Location = new System.Drawing.Point(409, 93);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(226, 27);
            this.maskedTextBox2.TabIndex = 43;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox1.Location = new System.Drawing.Point(142, 93);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(226, 27);
            this.maskedTextBox1.TabIndex = 43;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderDate.Location = new System.Drawing.Point(138, 257);
            this.txtOrderDate.Mask = "00/00/0000 90:00";
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(226, 27);
            this.txtOrderDate.TabIndex = 44;
            this.txtOrderDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Location = new System.Drawing.Point(618, 302);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 29);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 487);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.lbMemberId);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.lbOrderId);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.lbHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnDelete;
        private Button btnAdd;
        private Button btnLoad;
        private TextBox txtFreight;
        private TextBox txtShippedDate;
        private TextBox txtRequiredDate;
        private TextBox txtMemberId;
        private TextBox txtOrderId;
        private Label lbShippedDate;
        private Label lbMemberId;
        private Label lbOrderDate;
        private Label lbFreight;
        private Label lbRequiredDate;
        private Label lbOrderId;
        private DataGridView dgvOrderList;
        private Label lbHeader;
        private Panel panel1;
        private Label label1;
        private Button btnReport;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox txtOrderDate;
        private Button btnClose;
    }
}