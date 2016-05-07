using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WDMS.EF;

namespace WDMS.WinForm
{
    public partial class FormQueryStyle : Form
    {
        public FormQueryStyle()
        {
            InitializeComponent();
            this.gridData.AllowUserToAddRows = false;
            this.gridData.BackgroundColor = Color.White;
            this.gridData.RowHeadersVisible = false;
            this.gridData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.lblMessage.Text = string.Empty;
            this.gridData.DataSource = null;
            string keyword = this.txtKeyword.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("关键词不能为空！");
            }
            else
            {
                using (var context = new WDMSEntities())
                {
                    var styleList = (from tmpStyle in context.Styles
                                     where tmpStyle.StyleNo.Contains(keyword)
                                     select new
                                     {
                                         tmpStyle.StyleId,
                                         tmpStyle.StyleNo,
                                         tmpStyle.Status,
                                         tmpStyle.CreateTime,
                                         tmpStyle.Description
                                     }).ToList();

                    if (styleList.Count > 0)
                    {
                        this.gridData.DataSource = styleList;
                        this.gridData.Rows[0].Selected = true;
                    }
                    else
                    {
                        this.lblMessage.Text = "无记录";
                    }
                }
            }
        }

        private void btnCreateInvenory_Click(object sender, EventArgs e)
        {
            if(this.gridData.RowCount>0)
            {
                
            }
        }

        private void btnModifyStyle_Click(object sender, EventArgs e)
        {
            if (this.gridData.RowCount > 0)
            {
                int selectedStyleId = int.Parse(this.gridData.SelectedRows[0].Cells["StyleId"].Value.ToString());
                FormNewStyle frm = new FormNewStyle(selectedStyleId);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }
    }
}
