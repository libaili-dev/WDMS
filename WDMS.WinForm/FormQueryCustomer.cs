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
    public partial class FormQueryCustomer : Form
    {
        public FormQueryCustomer()
        {
            InitializeComponent();

            this.gridCustomers.AllowUserToAddRows = false;
            this.gridCustomers.BackgroundColor = Color.White;
            this.gridCustomers.RowHeadersVisible = false;
            this.gridCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.gridCustomers.DataSource = null;
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
                    var matchingList = (from tmpCustomer in contxt.Customer
                                       where (tmpCustomer.CustomerName.Contains(keyword)
                                         || tmpCustomer.Mobile.Contains(keyword))                                         
                                       select new 
                                       {
                                           tmpCustomer.CustomerId,
                                           tmpCustomer.CustomerName,
                                           tmpCustomer.Gender,
                                           tmpCustomer.Mobile,
                                           tmpCustomer.WeddingDate,
                                           tmpCustomer.Remark
                                       }
                                       ).ToList();
                    if (matchingList.Count() > 0)
                    {
                        this.gridCustomers.DataSource = matchingList;
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
