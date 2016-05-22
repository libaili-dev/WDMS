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
        private int _inventoryId = 0;

        public FormNewInventory(string styleNo)
        {

            InitializeComponent();
            this.btnAddInventory.Visible = true;
            this.btnUpdateInventory.Visible = false;
            this.txtTotalCount.Text = "1";
            _styleNo = styleNo;
            this.lblStyleNo.Text = styleNo;
            using (var context = new WDMSEntities())
            {
                var style = context.Styles.FirstOrDefault<Styles>(tmp => tmp.StyleNo.Equals(styleNo));
                _styleId = style.StyleId;
            }
        }

        /// <summary>
        /// Update Inventory
        /// </summary>
        /// <param name="styleNo"></param>
        /// <param name="inventoryId"></param>
        public FormNewInventory(string styleNo, int inventoryId)
        {
            InitializeComponent();

            this.btnAddInventory.Visible = false;
            this.btnUpdateInventory.Visible = true;

            this.txtTotalCount.Text = "1";
            _styleNo = styleNo;
            _inventoryId = inventoryId;

            this.lblStyleNo.Text = styleNo;
            

            using (var context = new WDMSEntities())
            {
                var inventory = context.Inventory.Find(inventoryId);
                if (inventory != null)
                {
                    this.txtSize.Text = inventory.Size;
                    this.txtTotalCount.Text = inventory.TotalCount.ToString();
                    this.txtSellPrice.Text = inventory.SellPrice.ToString();
                    this.txtRentPrice.Text = inventory.RentPrice.ToString();
                    this.txtRemark.Text = inventory.Remark.ToString();
                }
            }
        }

        public void SetUpdateOperation()
        {
            this.btnAddInventory.Visible = false;
            this.btnUpdateInventory.Visible = true;
            using (var context = new WDMSEntities())
            {
                // var tmpInv = context.Inventory.
            }

        }

        private void BindInventoryInfo()
        {

        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            this.lblMessage.Text = string.Empty;
            string validateMsg = ValidateInputs();
            if (!string.IsNullOrEmpty(validateMsg))
            {
                this.lblMessage.Text = validateMsg;
            }
            else
            {
                Inventory inv = GetInventoryFromGUI();

                using (var context = new WDMSEntities())
                {
                    var dbInv = context.Inventory.Find(_inventoryId);
                    dbInv.Size = inv.Size;
                    dbInv.TotalCount = inv.TotalCount;
                    dbInv.SellPrice = inv.SellPrice;
                    dbInv.RentPrice = inv.RentPrice;
                    dbInv.Remark = inv.Remark;
                    dbInv.UpdateTime = DateTime.Now;

                    context.SaveChanges();
                    this.lblMessage.Text = "库存信息更新成功！";
                }
            }

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
                Inventory inventory = GetInventoryFromGUI();

                inventory.CreateTime = DateTime.Now;


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
                this.DialogResult = DialogResult.OK;
            }
        }

        private Inventory GetInventoryFromGUI()
        {
            Inventory inventory = new Inventory();
            inventory.Size = this.txtSize.Text.Trim();
            inventory.TotalCount = int.Parse(this.txtTotalCount.Text.Trim());
            inventory.RentPrice = decimal.Parse(this.txtRentPrice.Text.Trim());
            inventory.SellPrice = decimal.Parse(this.txtSellPrice.Text.Trim());
            inventory.Remark = this.txtRemark.Text.Trim();
            inventory.StyleId = _styleId;
            inventory.Status = "Normal";
            inventory.Operator = 1;
            return inventory;
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
