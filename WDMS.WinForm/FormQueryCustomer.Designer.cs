namespace WDMS.WinForm
{
    partial class FormQueryCustomer
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
            this.lblInputCustomerInfo = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.gridCustomerS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInputCustomerInfo
            // 
            this.lblInputCustomerInfo.AutoSize = true;
            this.lblInputCustomerInfo.Location = new System.Drawing.Point(26, 13);
            this.lblInputCustomerInfo.Name = "lblInputCustomerInfo";
            this.lblInputCustomerInfo.Size = new System.Drawing.Size(125, 12);
            this.lblInputCustomerInfo.TabIndex = 0;
            this.lblInputCustomerInfo.Text = "客户姓名或联系方式：";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(157, 10);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(298, 21);
            this.txtKeyword.TabIndex = 1;
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyword_KeyPress);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(517, 7);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查找(&S)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // gridCustomerS
            // 
            this.gridCustomerS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCustomerS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomerS.Location = new System.Drawing.Point(12, 54);
            this.gridCustomerS.Name = "gridCustomerS";
            this.gridCustomerS.RowTemplate.Height = 23;
            this.gridCustomerS.Size = new System.Drawing.Size(731, 471);
            this.gridCustomerS.TabIndex = 3;
            // 
            // FormQueryCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 537);
            this.Controls.Add(this.gridCustomerS);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.lblInputCustomerInfo);
            this.Name = "FormQueryCustomer";
            this.Text = "客户信息查询";
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputCustomerInfo;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView gridCustomerS;
    }
}