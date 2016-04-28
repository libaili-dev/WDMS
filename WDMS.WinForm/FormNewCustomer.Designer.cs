namespace WDMS.WinForm
{
    partial class FormNewCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnCancelCreate = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblWeddingDate = new System.Windows.Forms.Label();
            this.dateTimePickerWeddingDate = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioSexF = new System.Windows.Forms.RadioButton();
            this.radioSexM = new System.Windows.Forms.RadioButton();
            this.panelSex = new System.Windows.Forms.Panel();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.comboBoxCustomerType = new System.Windows.Forms.ComboBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtRemark);
            this.panel1.Controls.Add(this.lblRemark);
            this.panel1.Controls.Add(this.comboBoxCustomerType);
            this.panel1.Controls.Add(this.lblCustomerType);
            this.panel1.Controls.Add(this.panelSex);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.dateTimePickerWeddingDate);
            this.panel1.Controls.Add(this.lblWeddingDate);
            this.panel1.Controls.Add(this.lblMobile);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 568);
            this.panel1.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCustomer.Location = new System.Drawing.Point(40, 3);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 30);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "确定(&S)";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnCancelCreate
            // 
            this.btnCancelCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelCreate.Location = new System.Drawing.Point(134, 3);
            this.btnCancelCreate.Name = "btnCancelCreate";
            this.btnCancelCreate.Size = new System.Drawing.Size(75, 30);
            this.btnCancelCreate.TabIndex = 2;
            this.btnCancelCreate.Text = "取消(&C)";
            this.btnCancelCreate.UseVisualStyleBackColor = true;
            this.btnCancelCreate.Click += new System.EventHandler(this.btnCancelCreate_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(36, 30);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(41, 12);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "姓名：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(36, 133);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "性别：";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(36, 191);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(65, 12);
            this.lblMobile.TabIndex = 2;
            this.lblMobile.Text = "联系方式：";
            // 
            // lblWeddingDate
            // 
            this.lblWeddingDate.AutoSize = true;
            this.lblWeddingDate.Location = new System.Drawing.Point(36, 250);
            this.lblWeddingDate.Name = "lblWeddingDate";
            this.lblWeddingDate.Size = new System.Drawing.Size(41, 12);
            this.lblWeddingDate.TabIndex = 3;
            this.lblWeddingDate.Text = "婚期：";
            // 
            // dateTimePickerWeddingDate
            // 
            this.dateTimePickerWeddingDate.Location = new System.Drawing.Point(143, 250);
            this.dateTimePickerWeddingDate.Name = "dateTimePickerWeddingDate";
            this.dateTimePickerWeddingDate.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerWeddingDate.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 21);
            this.txtName.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMessage);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 36);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddCustomer);
            this.panel3.Controls.Add(this.btnCancelCreate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(556, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 36);
            this.panel3.TabIndex = 3;
            // 
            // radioSexF
            // 
            this.radioSexF.AutoSize = true;
            this.radioSexF.Checked = true;
            this.radioSexF.Location = new System.Drawing.Point(21, 12);
            this.radioSexF.Name = "radioSexF";
            this.radioSexF.Size = new System.Drawing.Size(35, 16);
            this.radioSexF.TabIndex = 9;
            this.radioSexF.TabStop = true;
            this.radioSexF.Text = "女";
            this.radioSexF.UseVisualStyleBackColor = true;
            // 
            // radioSexM
            // 
            this.radioSexM.AutoSize = true;
            this.radioSexM.Location = new System.Drawing.Point(62, 12);
            this.radioSexM.Name = "radioSexM";
            this.radioSexM.Size = new System.Drawing.Size(35, 16);
            this.radioSexM.TabIndex = 9;
            this.radioSexM.Text = "男";
            this.radioSexM.UseVisualStyleBackColor = true;
            // 
            // panelSex
            // 
            this.panelSex.Controls.Add(this.radioSexF);
            this.panelSex.Controls.Add(this.radioSexM);
            this.panelSex.Location = new System.Drawing.Point(145, 123);
            this.panelSex.Name = "panelSex";
            this.panelSex.Size = new System.Drawing.Size(110, 39);
            this.panelSex.TabIndex = 10;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(145, 188);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(198, 21);
            this.txtMobile.TabIndex = 8;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Location = new System.Drawing.Point(38, 80);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(53, 12);
            this.lblCustomerType.TabIndex = 11;
            this.lblCustomerType.Text = "客户类型";
            // 
            // comboBoxCustomerType
            // 
            this.comboBoxCustomerType.FormattingEnabled = true;
            this.comboBoxCustomerType.Items.AddRange(new object[] {
            "普通客户",
            "推荐客户",
            "关系客户"});
            this.comboBoxCustomerType.Location = new System.Drawing.Point(143, 72);
            this.comboBoxCustomerType.Name = "comboBoxCustomerType";
            this.comboBoxCustomerType.Size = new System.Drawing.Size(130, 20);
            this.comboBoxCustomerType.TabIndex = 12;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(38, 321);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(41, 12);
            this.lblRemark.TabIndex = 13;
            this.lblRemark.Text = "备注：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(145, 321);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(343, 158);
            this.txtRemark.TabIndex = 14;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblMessage.Location = new System.Drawing.Point(13, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 12);
            this.lblMessage.TabIndex = 4;
            // 
            // FormNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormNewCustomer";
            this.Text = "新增客户";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelSex.ResumeLayout(false);
            this.panelSex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnCancelCreate;
        private System.Windows.Forms.Label lblWeddingDate;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dateTimePickerWeddingDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioSexM;
        private System.Windows.Forms.RadioButton radioSexF;
        private System.Windows.Forms.Panel panelSex;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.ComboBox comboBoxCustomerType;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblMessage;
    }
}