namespace WDMS.WinForm
{
    partial class FormNewStyle
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStyleNo = new System.Windows.Forms.TextBox();
            this.lblStyleNo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEditStyle = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateStyle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.comboBoxStyleStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxStyleStatus);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.txtStyleNo);
            this.panel1.Controls.Add(this.lblStyleNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(122, 150);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(326, 154);
            this.txtDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(16, 150);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "款式描述：";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(14, 96);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "状态：";
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.Location = new System.Drawing.Point(122, 30);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Size = new System.Drawing.Size(166, 20);
            this.txtStyleNo.TabIndex = 1;
            // 
            // lblStyleNo
            // 
            this.lblStyleNo.AutoSize = true;
            this.lblStyleNo.Location = new System.Drawing.Point(14, 30);
            this.lblStyleNo.Name = "lblStyleNo";
            this.lblStyleNo.Size = new System.Drawing.Size(67, 13);
            this.lblStyleNo.TabIndex = 0;
            this.lblStyleNo.Text = "款式编码：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 36);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnEditStyle);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.btnCreateStyle);
            this.panel4.Location = new System.Drawing.Point(377, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 36);
            this.panel4.TabIndex = 1;
            // 
            // btnEditStyle
            // 
            this.btnEditStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditStyle.Location = new System.Drawing.Point(28, 6);
            this.btnEditStyle.Name = "btnEditStyle";
            this.btnEditStyle.Size = new System.Drawing.Size(69, 23);
            this.btnEditStyle.TabIndex = 2;
            this.btnEditStyle.Text = "更新";
            this.btnEditStyle.UseVisualStyleBackColor = true;
            this.btnEditStyle.Click += new System.EventHandler(this.btnEditStyle_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(179, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateStyle
            // 
            this.btnCreateStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateStyle.Location = new System.Drawing.Point(103, 5);
            this.btnCreateStyle.Name = "btnCreateStyle";
            this.btnCreateStyle.Size = new System.Drawing.Size(70, 25);
            this.btnCreateStyle.TabIndex = 0;
            this.btnCreateStyle.Text = "确定";
            this.btnCreateStyle.UseVisualStyleBackColor = true;
            this.btnCreateStyle.Click += new System.EventHandler(this.btnCreateStyle_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblMessage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 36);
            this.panel3.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblMessage.Location = new System.Drawing.Point(12, 17);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 0;
            // 
            // comboBoxStyleStatus
            // 
            this.comboBoxStyleStatus.FormattingEnabled = true;
            this.comboBoxStyleStatus.Location = new System.Drawing.Point(122, 96);
            this.comboBoxStyleStatus.Name = "comboBoxStyleStatus";
            this.comboBoxStyleStatus.Size = new System.Drawing.Size(166, 21);
            this.comboBoxStyleStatus.TabIndex = 5;
            // 
            // FormNewStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormNewStyle";
            this.Text = "新建款式";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateStyle;
        private System.Windows.Forms.Label lblStyleNo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStyleNo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnEditStyle;
        private System.Windows.Forms.ComboBox comboBoxStyleStatus;
    }
}