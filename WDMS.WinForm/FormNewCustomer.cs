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
    public partial class FormNewCustomer : Form
    {
        public FormNewCustomer()
        {
            InitializeComponent();

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            this.lblMessage.Text = string.Empty;
            Customer customer = new Customer();
            //set customer type id as 2 tempararily
            customer.CustomerTypeId = 2;
            customer.CustomerName = this.txtName.Text.Trim();
            customer.Gender = this.radioSexF.Checked ? 0 : 1;
            customer.Mobile = this.txtMobile.Text.Trim();
            customer.WeddingDate = this.dateTimePickerWeddingDate.Value;
            customer.Remark = this.txtRemark.Text.Trim();
            customer.CreateTime = DateTime.Now;
            using (var contxt = new WDMSEntities())
            {
                try
                {
                    Customer checkCustomer =contxt.Customer.FirstOrDefault(t => t.Mobile.Equals(customer.Mobile));
                    if (checkCustomer == null)
                    {
                        contxt.Customer.Add(customer);
                        contxt.SaveChanges();
                        this.lblMessage.Text = string.Format("新增用户：{0}成功！", customer.CustomerName);
                        this.txtName.Text = string.Empty;
                        this.radioSexF.Checked = true;
                        this.txtMobile.Text = string.Empty;
                        this.txtRemark.Text = string.Empty;
                        this.dateTimePickerWeddingDate.Value = DateTime.Today;
                    }
                    else
                    {
                        this.lblMessage.Text = string.Format("新增用户：{0}失败！该手机用户已经存在！", customer.CustomerName);
                    }
                }
                catch (Exception)
                {
                    this.lblMessage.Text = string.Format("新增用户：{0}失败！", customer.CustomerName);
                }
            }
            
        }

        private void btnCancelCreate_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
