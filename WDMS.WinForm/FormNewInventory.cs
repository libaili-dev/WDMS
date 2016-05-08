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
    public partial class FormNewInventory : Form
    {
        private string _styleNo = string.Empty;
        private int _styleId = 0;

        public FormNewInventory(string styleNo)
        {
            
            InitializeComponent();

            this.txtTotalCount.Text = "1";
            _styleNo = styleNo;
            this.lblStyleNo.Text = styleNo;
            using (var context = new WDMSEntities())
            {
                var style = context.Styles.FirstOrDefault<Styles>(tmp => tmp.StyleNo.Equals(styleNo));
                _styleId = style.StyleId;
            }
        }


        private void BindInventoryInfo()
        {
            
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            this.lblMessage.Text = string.Empty;
            string validateMsg = ValidateInputs();
            if (!string.IsNullOrEmpty(validateMsg))
            {
                this.lblMessage.Text = validateMsg;
            }
            else
            {
                Inventory inventory = new Inventory();
                inventory.Size = this.txtSize.Text.Trim();
                inventory.TotalCount = int.Parse( this.txtTotalCount.Text.Trim());
                inventory.RentPrice =decimal.Parse( this.txtRentPrice.Text.Trim());
                inventory.SellPrice = decimal.Parse(this.txtSellPrice.Text.Trim());
                inventory.Remark = this.txtRemark.Text.Trim();
                inventory.StyleId = _styleId;
                inventory.Status = "Normal";
                inventory.CreateTime = DateTime.Now;

                inventory.Operator = 1;

                using (var context = new WDMSEntities())
                {
                    context.Inventory.Add(inventory);
                    context.SaveChanges();

                    this.lblMessage.Text = "新增库存成功！";

                    this.txtSize.Text = string.Empty;
                    this.txtTotalCount.Text = "1";
                    this.txtSellPrice.Text = string.Empty;
                    this.txtRentPrice.Text = string.Empty;
                    this.txtRemark.Text = string.Empty;
                }
            }
        }

        private string ValidateInputs()
        {
            if (string.IsNullOrEmpty(this.txtSize.Text.Trim()))
            {
                return "尺码不能为空！";
            }
            if (string.IsNullOrEmpty(this.txtTotalCount.Text.Trim()))
            {
                return "数量不能为空！";
            }
            if (string.IsNullOrEmpty(this.txtRentPrice.Text.Trim()))
            {
                return "租赁价格不能为空！";
            }
            if (string.IsNullOrEmpty(this.txtSellPrice.Text.Trim()))
            {
                return "出售价格不能为空！";
            }
            return string.Empty;
        }
    }
}
