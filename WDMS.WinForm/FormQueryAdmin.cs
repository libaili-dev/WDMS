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
    public partial class FormQueryAdmin : Form
    {
        public FormQueryAdmin()
        {
            InitializeComponent();

            this.gridAdmin.AllowUserToAddRows = false;
            this.gridAdmin.BackgroundColor = Color.White;
            this.gridAdmin.RowHeadersVisible = false;
            this.gridAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gridAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.gridAdmin.DataSource = null;
            this.lblMessage.Text = string.Empty;
            string keyword = this.txtKeyword.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("关键词不能为空！");
            }
            else
            {
                //
                using (var contxt = new WDMSEntities())
                {
                    //var tmp = contxt.Customer.Where<Customer>(tname=> tname.CustomerName.Contains(keyword)).Union<Customer>((tmobile => tmobile.)
                    var matchingList = (from tmpAdmin in contxt.Admin
                                       where tmpAdmin.AdminName.Contains(keyword)
                                                                                 
                                       select new 
                                       {
                                           tmpAdmin.AdminId,
                                           tmpAdmin.AdminName,
                                           tmpAdmin.AdminRole.RoleName,
                                       }
                                       ).ToList();
                    if (matchingList.Count() > 0)
                    {
                        this.gridAdmin.DataSource = matchingList;
                    }
                    else
                    {
                        this.lblMessage.Text = "无记录";
                    }
                }

            }
        }

        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnQuery_Click(sender, e);
            }
        }
    }
}
