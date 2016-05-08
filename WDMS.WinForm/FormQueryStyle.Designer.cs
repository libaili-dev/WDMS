namespace WDMS.WinForm
{
    partial class FormQueryStyle
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
            this.lblKeyword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnModifyStyle = new System.Windows.Forms.Button();
            this.btnCreateInvenory = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(12, 14);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(91, 13);
            this.lblKeyword.TabIndex = 0;
            this.lblKeyword.Text = "请输入关键词：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridData);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 438);
            this.panel1.TabIndex = 1;
            // 
            // gridData
            // 
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Location = new System.Drawing.Point(6, 3);
            this.gridData.Name = "gridData";
            this.gridData.RowTemplate.Height = 23;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridData.Size = new System.Drawing.Size(709, 431);
            this.gridData.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtKeyword);
            this.panel2.Controls.Add(this.lblKeyword);
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 49);
            this.panel2.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(555, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查找(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(107, 11);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(317, 20);
            this.txtKeyword.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnModifyStyle);
            this.panel3.Controls.Add(this.btnCreateInvenory);
            this.panel3.Controls.Add(this.lblMessage);
            this.panel3.Location = new System.Drawing.Point(12, 512);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(718, 33);
            this.panel3.TabIndex = 3;
            // 
            // btnModifyStyle
            // 
            this.btnModifyStyle.Location = new System.Drawing.Point(548, 5);
            this.btnModifyStyle.Name = "btnModifyStyle";
            this.btnModifyStyle.Size = new System.Drawing.Size(75, 23);
            this.btnModifyStyle.TabIndex = 2;
            this.btnModifyStyle.Text = "款式修改";
            this.btnModifyStyle.UseVisualStyleBackColor = true;
            this.btnModifyStyle.Click += new System.EventHandler(this.btnModifyStyle_Click);
            // 
            // btnCreateInvenory
            // 
            this.btnCreateInvenory.Location = new System.Drawing.Point(629, 3);
            this.btnCreateInvenory.Name = "btnCreateInvenory";
            this.btnCreateInvenory.Size = new System.Drawing.Size(75, 25);
            this.btnCreateInvenory.TabIndex = 1;
            this.btnCreateInvenory.Text = "新增库存";
            this.btnCreateInvenory.UseVisualStyleBackColor = true;
            this.btnCreateInvenory.Click += new System.EventHandler(this.btnCreateInvenory_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblMessage.Location = new System.Drawing.Point(4, 4);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 0;
            // 
            // FormQueryStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 558);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormQueryStyle";
            this.Text = "款式查询";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Button btnCreateInvenory;
        private System.Windows.Forms.Button btnModifyStyle;
    }
}