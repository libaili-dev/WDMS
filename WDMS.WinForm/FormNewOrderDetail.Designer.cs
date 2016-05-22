namespace WDMS.WinForm
{
    partial class FormNewOrderDetail
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
            this.lblOrderBatchIdDesc = new System.Windows.Forms.Label();
            this.lblOrderBatchId = new System.Windows.Forms.Label();
            this.lblOrderTypeDesc = new System.Windows.Forms.Label();
            this.comboBoxOrderType = new System.Windows.Forms.ComboBox();
            this.lblStyleNoDesc = new System.Windows.Forms.Label();
            this.lblRemarkDesc = new System.Windows.Forms.Label();
            this.txtRemrk = new System.Windows.Forms.TextBox();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.comboBoxOrderStatus = new System.Windows.Forms.ComboBox();
            this.lblDeliveryWayStatus = new System.Windows.Forms.Label();
            this.comboBoxDeliveryWay = new System.Windows.Forms.ComboBox();
            this.lblStyleNo = new System.Windows.Forms.Label();
            this.lblInventoryIdDesc = new System.Windows.Forms.Label();
            this.lblInventoryId = new System.Windows.Forms.Label();
            this.lblSizeDesc = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblExpressNoDesc = new System.Windows.Forms.Label();
            this.txtExpressNo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnInventroyReselect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdateOrderDetail = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderBatchIdDesc
            // 
            this.lblOrderBatchIdDesc.AutoSize = true;
            this.lblOrderBatchIdDesc.Location = new System.Drawing.Point(12, 16);
            this.lblOrderBatchIdDesc.Name = "lblOrderBatchIdDesc";
            this.lblOrderBatchIdDesc.Size = new System.Drawing.Size(67, 13);
            this.lblOrderBatchIdDesc.TabIndex = 0;
            this.lblOrderBatchIdDesc.Text = "订单批号：";
            // 
            // lblOrderBatchId
            // 
            this.lblOrderBatchId.AutoSize = true;
            this.lblOrderBatchId.Location = new System.Drawing.Point(86, 16);
            this.lblOrderBatchId.Name = "lblOrderBatchId";
            this.lblOrderBatchId.Size = new System.Drawing.Size(31, 13);
            this.lblOrderBatchId.TabIndex = 1;
            this.lblOrderBatchId.Text = "未知";
            // 
            // lblOrderTypeDesc
            // 
            this.lblOrderTypeDesc.AutoSize = true;
            this.lblOrderTypeDesc.Location = new System.Drawing.Point(12, 150);
            this.lblOrderTypeDesc.Name = "lblOrderTypeDesc";
            this.lblOrderTypeDesc.Size = new System.Drawing.Size(67, 13);
            this.lblOrderTypeDesc.TabIndex = 2;
            this.lblOrderTypeDesc.Text = "订单类型：";
            // 
            // comboBoxOrderType
            // 
            this.comboBoxOrderType.FormattingEnabled = true;
            this.comboBoxOrderType.Location = new System.Drawing.Point(82, 147);
            this.comboBoxOrderType.Name = "comboBoxOrderType";
            this.comboBoxOrderType.Size = new System.Drawing.Size(108, 21);
            this.comboBoxOrderType.TabIndex = 3;
            // 
            // lblStyleNoDesc
            // 
            this.lblStyleNoDesc.AutoSize = true;
            this.lblStyleNoDesc.Location = new System.Drawing.Point(86, 78);
            this.lblStyleNoDesc.Name = "lblStyleNoDesc";
            this.lblStyleNoDesc.Size = new System.Drawing.Size(67, 13);
            this.lblStyleNoDesc.TabIndex = 4;
            this.lblStyleNoDesc.Text = "款式编号：";
            // 
            // lblRemarkDesc
            // 
            this.lblRemarkDesc.AutoSize = true;
            this.lblRemarkDesc.Location = new System.Drawing.Point(12, 280);
            this.lblRemarkDesc.Name = "lblRemarkDesc";
            this.lblRemarkDesc.Size = new System.Drawing.Size(43, 13);
            this.lblRemarkDesc.TabIndex = 5;
            this.lblRemarkDesc.Text = "备注：";
            // 
            // txtRemrk
            // 
            this.txtRemrk.Location = new System.Drawing.Point(82, 280);
            this.txtRemrk.Multiline = true;
            this.txtRemrk.Name = "txtRemrk";
            this.txtRemrk.Size = new System.Drawing.Size(410, 90);
            this.txtRemrk.TabIndex = 6;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(12, 191);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(67, 13);
            this.lblOrderStatus.TabIndex = 7;
            this.lblOrderStatus.Text = "订单状态：";
            // 
            // comboBoxOrderStatus
            // 
            this.comboBoxOrderStatus.FormattingEnabled = true;
            this.comboBoxOrderStatus.Location = new System.Drawing.Point(82, 188);
            this.comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            this.comboBoxOrderStatus.Size = new System.Drawing.Size(109, 21);
            this.comboBoxOrderStatus.TabIndex = 8;
            // 
            // lblDeliveryWayStatus
            // 
            this.lblDeliveryWayStatus.AutoSize = true;
            this.lblDeliveryWayStatus.Location = new System.Drawing.Point(12, 236);
            this.lblDeliveryWayStatus.Name = "lblDeliveryWayStatus";
            this.lblDeliveryWayStatus.Size = new System.Drawing.Size(67, 13);
            this.lblDeliveryWayStatus.TabIndex = 9;
            this.lblDeliveryWayStatus.Text = "发件方式：";
            // 
            // comboBoxDeliveryWay
            // 
            this.comboBoxDeliveryWay.FormattingEnabled = true;
            this.comboBoxDeliveryWay.Location = new System.Drawing.Point(82, 233);
            this.comboBoxDeliveryWay.Name = "comboBoxDeliveryWay";
            this.comboBoxDeliveryWay.Size = new System.Drawing.Size(109, 21);
            this.comboBoxDeliveryWay.TabIndex = 10;
            // 
            // lblStyleNo
            // 
            this.lblStyleNo.AutoSize = true;
            this.lblStyleNo.Location = new System.Drawing.Point(160, 78);
            this.lblStyleNo.Name = "lblStyleNo";
            this.lblStyleNo.Size = new System.Drawing.Size(31, 13);
            this.lblStyleNo.TabIndex = 11;
            this.lblStyleNo.Text = "未知";
            // 
            // lblInventoryIdDesc
            // 
            this.lblInventoryIdDesc.AutoSize = true;
            this.lblInventoryIdDesc.Location = new System.Drawing.Point(86, 47);
            this.lblInventoryIdDesc.Name = "lblInventoryIdDesc";
            this.lblInventoryIdDesc.Size = new System.Drawing.Size(67, 13);
            this.lblInventoryIdDesc.TabIndex = 12;
            this.lblInventoryIdDesc.Text = "库存编号：";
            // 
            // lblInventoryId
            // 
            this.lblInventoryId.AutoSize = true;
            this.lblInventoryId.Location = new System.Drawing.Point(159, 47);
            this.lblInventoryId.Name = "lblInventoryId";
            this.lblInventoryId.Size = new System.Drawing.Size(31, 13);
            this.lblInventoryId.TabIndex = 13;
            this.lblInventoryId.Text = "未知";
            // 
            // lblSizeDesc
            // 
            this.lblSizeDesc.AutoSize = true;
            this.lblSizeDesc.Location = new System.Drawing.Point(86, 108);
            this.lblSizeDesc.Name = "lblSizeDesc";
            this.lblSizeDesc.Size = new System.Drawing.Size(67, 13);
            this.lblSizeDesc.TabIndex = 14;
            this.lblSizeDesc.Text = "尺码大小：";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(160, 108);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(31, 13);
            this.lblSize.TabIndex = 15;
            this.lblSize.Text = "未知";
            // 
            // lblExpressNoDesc
            // 
            this.lblExpressNoDesc.AutoSize = true;
            this.lblExpressNoDesc.Location = new System.Drawing.Point(229, 236);
            this.lblExpressNoDesc.Name = "lblExpressNoDesc";
            this.lblExpressNoDesc.Size = new System.Drawing.Size(67, 13);
            this.lblExpressNoDesc.TabIndex = 16;
            this.lblExpressNoDesc.Text = "快递编号：";
            // 
            // txtExpressNo
            // 
            this.txtExpressNo.Location = new System.Drawing.Point(302, 233);
            this.txtExpressNo.Name = "txtExpressNo";
            this.txtExpressNo.Size = new System.Drawing.Size(190, 20);
            this.txtExpressNo.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCount);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.btnInventroyReselect);
            this.panel1.Controls.Add(this.lblInventoryIdDesc);
            this.panel1.Controls.Add(this.txtRemrk);
            this.panel1.Controls.Add(this.txtExpressNo);
            this.panel1.Controls.Add(this.lblRemarkDesc);
            this.panel1.Controls.Add(this.lblOrderBatchIdDesc);
            this.panel1.Controls.Add(this.lblExpressNoDesc);
            this.panel1.Controls.Add(this.lblOrderBatchId);
            this.panel1.Controls.Add(this.comboBoxDeliveryWay);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.lblDeliveryWayStatus);
            this.panel1.Controls.Add(this.lblOrderTypeDesc);
            this.panel1.Controls.Add(this.lblSizeDesc);
            this.panel1.Controls.Add(this.comboBoxOrderType);
            this.panel1.Controls.Add(this.lblInventoryId);
            this.panel1.Controls.Add(this.lblStyleNoDesc);
            this.panel1.Controls.Add(this.lblOrderStatus);
            this.panel1.Controls.Add(this.lblStyleNo);
            this.panel1.Controls.Add(this.comboBoxOrderStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 405);
            this.panel1.TabIndex = 18;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(302, 147);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 20;
            this.txtCount.Text = "1";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(229, 150);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(43, 13);
            this.lblCount.TabIndex = 19;
            this.lblCount.Text = "数量：";
            // 
            // btnInventroyReselect
            // 
            this.btnInventroyReselect.Location = new System.Drawing.Point(232, 42);
            this.btnInventroyReselect.Name = "btnInventroyReselect";
            this.btnInventroyReselect.Size = new System.Drawing.Size(75, 23);
            this.btnInventroyReselect.TabIndex = 18;
            this.btnInventroyReselect.Text = "款式重选";
            this.btnInventroyReselect.UseVisualStyleBackColor = true;
            this.btnInventroyReselect.Click += new System.EventHandler(this.btnInventroyReselect_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMessage);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 38);
            this.panel2.TabIndex = 19;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblMessage.Location = new System.Drawing.Point(3, 13);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUpdateOrderDetail);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(271, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 38);
            this.panel3.TabIndex = 0;
            // 
            // btnUpdateOrderDetail
            // 
            this.btnUpdateOrderDetail.Location = new System.Drawing.Point(84, 8);
            this.btnUpdateOrderDetail.Name = "btnUpdateOrderDetail";
            this.btnUpdateOrderDetail.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateOrderDetail.TabIndex = 2;
            this.btnUpdateOrderDetail.Text = "修改(&M)";
            this.btnUpdateOrderDetail.UseVisualStyleBackColor = true;
            this.btnUpdateOrderDetail.Click += new System.EventHandler(this.btnUpdateOrderDetail_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(165, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(3, 8);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定(&S)";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FormNewOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormNewOrderDetail";
            this.Text = "订单详情";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOrderBatchIdDesc;
        private System.Windows.Forms.Label lblOrderBatchId;
        private System.Windows.Forms.Label lblOrderTypeDesc;
        private System.Windows.Forms.ComboBox comboBoxOrderType;
        private System.Windows.Forms.Label lblStyleNoDesc;
        private System.Windows.Forms.Label lblRemarkDesc;
        private System.Windows.Forms.TextBox txtRemrk;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.ComboBox comboBoxOrderStatus;
        private System.Windows.Forms.Label lblDeliveryWayStatus;
        private System.Windows.Forms.ComboBox comboBoxDeliveryWay;
        private System.Windows.Forms.Label lblStyleNo;
        private System.Windows.Forms.Label lblInventoryIdDesc;
        private System.Windows.Forms.Label lblInventoryId;
        private System.Windows.Forms.Label lblSizeDesc;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblExpressNoDesc;
        private System.Windows.Forms.TextBox txtExpressNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInventroyReselect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnUpdateOrderDetail;
    }
}