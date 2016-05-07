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
        private int _customerId = 0;
        public FormNewCustomer()
        {
            InitializeComponent();
            this.btnModifyCustomer.Visible = false;
            this.btnAddCustomer.Visible = true;
        }

        public FormNewCustomer(int customerId)
        {
            InitializeComponent();
            this.btnAddCustomer.Visible = false;
            this.btnModifyCustomer.Visible = true;
            using (var contxt = new WDMSEntities())
            {
                try
                {
                    Customer checkCustomer = contxt.Customer.FirstOrDefault(t => t.CustomerId ==customerId);
                    if (checkCustomer == null)
                    {
                        this.lblMessage.Text = "该用户不存在！";
                    }
                    else
                    {
                        this.txtName.Text= checkCustomer.CustomerName;
                        this.txtMobile.Text = checkCustomer.Mobile;
                        this.txtRemark.Text = checkCustomer.Remark;
                        this.comboBoxCustomerType.Text = checkCustomer.CustomerType.CustomerTypeName;
                        this.radioSexF.Checked = checkCustomer.Gender == 0 ? true : false;
                        this.dateTimePickerWeddingDate.Value = checkCustomer.WeddingDate ?? DateTime.Today;
                        this._customerId = checkCustomer.CustomerId;
                    }
                }
                catch
                {

                }
            }
        }

        private Customer GetCustomerModelFromGUI()
        {
            Customer customer = new Customer();
            //set customer type id as 2 tempararily
            customer.CustomerTypeId = 2;
            customer.CustomerName = this.txtName.Text.Trim();
            customer.Gender = this.radioSexF.Checked ? 0 : 1;
            customer.Mobile = this.txtMobile.Text.Trim();
            customer.WeddingDate = this.dateTimePickerWeddingDate.Value;
            customer.Remark = this.txtRemark.Text.Trim();
            customer.CreateTime = DateTime.Now;
            return customer;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string validateMsg = ValidateInputs();
            if (!string.IsNullOrEmpty(validateMsg))
            {
                this.lblMessage.Text = validateMsg;
                return;
            }
            this.lblMessage.Text = string.Empty;
            Customer customer = GetCustomerModelFromGUI();

            using (var contxt = new WDMSEntities())
            {
                try
                {
                    Customer checkCustomer = contxt.Customer.FirstOrDefault(t => t.Mobile.Equals(customer.Mobile));
                    if (checkCustomer == null)
                    {
                        contxt.Customer.Add(customer);
                        contxt.Entry<Customer>(customer).State = System.Data.Entity.EntityState.Added;
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


        private string ValidateInputs()
        {
            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                return "客户姓名不能为空！";
            }
            if (string.IsNullOrEmpty(this.txtMobile.Text.Trim()))
            {
                return "客户联系方式不能为空！";
            }
            if (this.dateTimePickerWeddingDate.Value < DateTime.Today)
            {
                return "婚期时间有误！";
            }
            return string.Empty;
        }

        private void btnCancelCreate_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnModifyCustomer_Click(object sender, EventArgs e)
        {
            this.lblMessage.Text = string.Empty;

            string validateMsg = ValidateInputs();
            if (!string.IsNullOrEmpty(validateMsg))
            {
                this.lblMessage.Text = validateMsg;
                return;
            }
            Customer customer = GetCustomerModelFromGUI();
            customer.CustomerId = this._customerId;
            using (var contxt = new WDMSEntities())
            {
               // var dbModel = contxt.Customer.Find(customer.CustomerId);

                //var dbModel = new Customer() { CustomerId = this._customerId };
                //dbModel.CustomerName = customer.CustomerName;
                //dbModel.CustomerType = customer.CustomerType;
                //dbModel.Gender = customer.Gender;
                //dbModel.Mobile = customer.Mobile;
                //dbModel.Remark = customer.Remark;
                //dbModel.WeddingDate = customer.WeddingDate;

                contxt.Customer.Attach(customer);
                contxt.Entry<Customer>(customer).State = System.Data.Entity.EntityState.Modified;
                contxt.SaveChanges();

                this.lblMessage.Text = string.Format("客户信息更新成功！");
            }
        }
    }
}
