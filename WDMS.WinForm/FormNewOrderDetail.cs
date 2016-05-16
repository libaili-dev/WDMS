using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WDMS.EF;

namespace WDMS.WinForm
{
    public partial class FormNewOrderDetail : Form
    {
        private int  _orderBatchId = 0;
        public int OrderDetailId = 0;
       
        public FormNewOrderDetail(int orderBatchId)
        {
            InitializeComponent();
            _orderBatchId = orderBatchId;

            InitControls();
        }

        private void InitControls()
        {
            this.lblOrderBatchId.Text = _orderBatchId.ToString();
            List<string> lstOrderType = ConfigurationManager.AppSettings["OrderType"].Split(',').ToList();
            this.comboBoxOrderType.DataSource = lstOrderType;

            List<string> lstOrderStatus = ConfigurationManager.AppSettings["OrderStatus"].Split(',').ToList();
            this.comboBoxOrderStatus.DataSource = lstOrderStatus;

            List<string> lstDeliveryType = ConfigurationManager.AppSettings["OrderDeliveryType"].Split(',').ToList();
            this.comboBoxDeliveryWay.DataSource = lstDeliveryType;
        }

        private void btnModifyInventory_Click(object sender, EventArgs e)
        {
            FormQueryInventory frm = new FormQueryInventory(true);
            frm.StartPosition = FormStartPosition.CenterParent;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                Inventory inv = frm.SelectedInventory;
                this.lblInventoryId.Text = inv.InventoryId.ToString();
                this.lblStyleNo.Text = inv.Styles.StyleNo;
                this.lblSize.Text = inv.Size;
            }
            frm.Dispose();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int inventoryId = 0;
            if (!int.TryParse(this.lblInventoryId.Text.Trim(), out inventoryId))
            {
                this.lblMessage.Text = "请重新选择库存内的款式！";
                return;
            }

            OrderDetails orderDetail = new OrderDetails();
            orderDetail.OrderBatchId = _orderBatchId;
            orderDetail.InventoryId = int.Parse(this.lblInventoryId.Text.Trim());
            orderDetail.OrderType = this.comboBoxOrderType.SelectedValue.ToString();
            orderDetail.Status = this.comboBoxOrderStatus.SelectedValue.ToString();
            orderDetail.DeliveryWay = this.comboBoxDeliveryWay.SelectedValue.ToString();
            orderDetail.ExpressNo = this.txtExpressNo.Text.Trim();
            orderDetail.CreateTime = DateTime.Now;
            
            orderDetail.Remark = this.txtRemrk.Text.Trim();

            using (var context = new WDMSEntities())
            {
                context.OrderDetails.Add(orderDetail);
                context.SaveChanges();
                this.lblMessage.Text = "订单创建成功";
                this.DialogResult = DialogResult.OK;
            }

           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();
        }
    }
}
