namespace WDMS.WinForm
{
    partial class FormNewInventory
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCreateNewInventory = new System.Windows.Forms.Button();
            this.lblStyleNo = new System.Windows.Forms.Label();
            this.txtStyleNo = new System.Windows.Forms.TextBox();
            this.btnQueryInventory = new System.Windows.Forms.Button();
            this.gridInventory = new System.Windows.Forms.DataGridView();
            this.lblSize = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtTotalCount = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQueryInventory);
            this.panel1.Controls.Add(this.txtStyleNo);
            this.panel1.Controls.Add(this.lblStyleNo);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 538);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gridInventory);
            this.panel2.Location = new System.Drawing.Point(3, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 161);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lblRemark);
            this.panel3.Controls.Add(this.txtRemark);
            this.panel3.Controls.Add(this.txtTotalCount);
            this.panel3.Controls.Add(this.lblCount);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.lblSize);
            this.panel3.Location = new System.Drawing.Point(3, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(902, 263);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCreateNewInventory);
            this.panel4.Controls.Add(this.lblMessage);
            this.panel4.Location = new System.Drawing.Point(3, 483);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(902, 52);
            this.panel4.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblMessage.Location = new System.Drawing.Point(9, 25);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 12);
            this.lblMessage.TabIndex = 0;
            // 
            // btnCreateNewInventory
            // 
            this.btnCreateNewInventory.Location = new System.Drawing.Point(743, 13);
            this.btnCreateNewInventory.Name = "btnCreateNewInventory";
            this.btnCreateNewInventory.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNewInventory.TabIndex = 1;
            this.btnCreateNewInventory.Text = "添加库存(&S)";
            this.btnCreateNewInventory.UseVisualStyleBackColor = true;
            this.btnCreateNewInventory.Click += new System.EventHandler(this.btnCreateNewInventory_Click);
            // 
            // lblStyleNo
            // 
            this.lblStyleNo.AutoSize = true;
            this.lblStyleNo.Location = new System.Drawing.Point(4, 18);
            this.lblStyleNo.Name = "lblStyleNo";
            this.lblStyleNo.Size = new System.Drawing.Size(65, 12);
            this.lblStyleNo.TabIndex = 3;
            this.lblStyleNo.Text = "款式编号：";
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.Location = new System.Drawing.Point(74, 15);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Size = new System.Drawing.Size(317, 21);
            this.txtStyleNo.TabIndex = 4;
            // 
            // btnQueryInventory
            // 
            this.btnQueryInventory.Location = new System.Drawing.Point(421, 13);
            this.btnQueryInventory.Name = "btnQueryInventory";
            this.btnQueryInventory.Size = new System.Drawing.Size(128, 23);
            this.btnQueryInventory.TabIndex = 5;
            this.btnQueryInventory.Text = "查询现有库存";
            this.btnQueryInventory.UseVisualStyleBackColor = true;
            this.btnQueryInventory.Click += new System.EventHandler(this.btnQueryInventory_Click);
            // 
            // gridInventory
            // 
            this.gridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInventory.Location = new System.Drawing.Point(3, 3);
            this.gridInventory.Name = "gridInventory";
            this.gridInventory.RowTemplate.Height = 23;
            this.gridInventory.Size = new System.Drawing.Size(896, 150);
            this.gridInventory.TabIndex = 0;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(11, 14);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(65, 12);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "尺码大小：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(237, 14);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(41, 12);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "总数：";
            // 
            // txtTotalCount
            // 
            this.txtTotalCount.Location = new System.Drawing.Point(284, 9);
            this.txtTotalCount.Name = "txtTotalCount";
            this.txtTotalCount.Size = new System.Drawing.Size(100, 21);
            this.txtTotalCount.TabIndex = 3;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(82, 60);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(302, 154);
            this.txtRemark.TabIndex = 4;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(13, 60);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(41, 12);
            this.lblRemark.TabIndex = 5;
            this.lblRemark.Text = "备注：";
            // 
            // FormNewInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 538);
            this.Controls.Add(this.panel1);
            this.Name = "FormNewInventory";
            this.Text = "创建库存";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCreateNewInventory;
        private System.Windows.Forms.Label lblStyleNo;
        private System.Windows.Forms.TextBox txtStyleNo;
        private System.Windows.Forms.Button btnQueryInventory;
        private System.Windows.Forms.DataGridView gridInventory;
        private System.Windows.Forms.TextBox txtTotalCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
    }
}