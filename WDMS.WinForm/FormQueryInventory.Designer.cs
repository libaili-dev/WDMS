namespace WDMS.WinForm
{
    partial class FormQueryInventory
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
            this.btnQueryInventory = new System.Windows.Forms.Button();
            this.txtStyleNo = new System.Windows.Forms.TextBox();
            this.lblStyleNo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnModifyInventory = new System.Windows.Forms.Button();
            this.btnCreateNewInventory = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridInventory = new System.Windows.Forms.DataGridView();
            this.btnDeleteInventory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQueryInventory);
            this.panel1.Controls.Add(this.txtStyleNo);
            this.panel1.Controls.Add(this.lblStyleNo);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 346);
            this.panel1.TabIndex = 1;
            // 
            // btnQueryInventory
            // 
            this.btnQueryInventory.Location = new System.Drawing.Point(326, 13);
            this.btnQueryInventory.Name = "btnQueryInventory";
            this.btnQueryInventory.Size = new System.Drawing.Size(113, 25);
            this.btnQueryInventory.TabIndex = 5;
            this.btnQueryInventory.Text = "查询现有库存（&S)";
            this.btnQueryInventory.UseVisualStyleBackColor = true;
            this.btnQueryInventory.Click += new System.EventHandler(this.btnQueryInventory_Click);
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.Location = new System.Drawing.Point(74, 16);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Size = new System.Drawing.Size(226, 20);
            this.txtStyleNo.TabIndex = 4;
            // 
            // lblStyleNo
            // 
            this.lblStyleNo.AutoSize = true;
            this.lblStyleNo.Location = new System.Drawing.Point(4, 20);
            this.lblStyleNo.Name = "lblStyleNo";
            this.lblStyleNo.Size = new System.Drawing.Size(67, 13);
            this.lblStyleNo.TabIndex = 3;
            this.lblStyleNo.Text = "款式编号：";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.lblMessage);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 306);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(505, 40);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeleteInventory);
            this.panel3.Controls.Add(this.btnModifyInventory);
            this.panel3.Controls.Add(this.btnCreateNewInventory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(211, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 40);
            this.panel3.TabIndex = 6;
            // 
            // btnModifyInventory
            // 
            this.btnModifyInventory.Location = new System.Drawing.Point(117, 8);
            this.btnModifyInventory.Name = "btnModifyInventory";
            this.btnModifyInventory.Size = new System.Drawing.Size(81, 23);
            this.btnModifyInventory.TabIndex = 2;
            this.btnModifyInventory.Text = "修改库存(&M)";
            this.btnModifyInventory.UseVisualStyleBackColor = true;
            this.btnModifyInventory.Click += new System.EventHandler(this.btnModifyInventory_Click);
            // 
            // btnCreateNewInventory
            // 
            this.btnCreateNewInventory.Location = new System.Drawing.Point(34, 6);
            this.btnCreateNewInventory.Name = "btnCreateNewInventory";
            this.btnCreateNewInventory.Size = new System.Drawing.Size(77, 25);
            this.btnCreateNewInventory.TabIndex = 1;
            this.btnCreateNewInventory.Text = "添加库存(&A)";
            this.btnCreateNewInventory.UseVisualStyleBackColor = true;
            this.btnCreateNewInventory.Click += new System.EventHandler(this.btnCreateNewInventory_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblMessage.Location = new System.Drawing.Point(12, 15);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gridInventory);
            this.panel2.Location = new System.Drawing.Point(3, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 240);
            this.panel2.TabIndex = 0;
            // 
            // gridInventory
            // 
            this.gridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridInventory.Location = new System.Drawing.Point(0, 0);
            this.gridInventory.Name = "gridInventory";
            this.gridInventory.RowTemplate.Height = 23;
            this.gridInventory.Size = new System.Drawing.Size(499, 240);
            this.gridInventory.TabIndex = 0;
            this.gridInventory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridInventory_CellDoubleClick);
            // 
            // btnDeleteInventory
            // 
            this.btnDeleteInventory.Location = new System.Drawing.Point(204, 7);
            this.btnDeleteInventory.Name = "btnDeleteInventory";
            this.btnDeleteInventory.Size = new System.Drawing.Size(78, 23);
            this.btnDeleteInventory.TabIndex = 3;
            this.btnDeleteInventory.Text = "删除库存(&D)";
            this.btnDeleteInventory.UseVisualStyleBackColor = true;
            this.btnDeleteInventory.Click += new System.EventHandler(this.btnDeleteInventory_Click);
            // 
            // FormQueryInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 346);
            this.Controls.Add(this.panel1);
            this.Name = "FormQueryInventory";
            this.Text = "库存";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCreateNewInventory;
        private System.Windows.Forms.Label lblStyleNo;
        private System.Windows.Forms.TextBox txtStyleNo;
        private System.Windows.Forms.Button btnQueryInventory;
        private System.Windows.Forms.DataGridView gridInventory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnModifyInventory;
        private System.Windows.Forms.Button btnDeleteInventory;
    }
}