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
        private string _operationType = string.Empty;

        public FormNewOrderDetail(int orderBatchId)
        {
            InitializeComponent();
            _orderBatchId = orderBatchId;
            this.btnUpdateOrderDetail.Visible = false;
            InitControls();
        }

        /// <summary>
        /// Modify order details
        /// </summary>
        /// <param name="orderBatchId"></param>
        /// <param name="orderDetailId"></param>
        /// <param name="operationType"></param>
        public FormNewOrderDetail(int orderBatchId,int orderDetailId, string operationType)
        {
            InitializeComponent();
            this.btnConfirm.Visible = false;
            _orderBatchId = orderBatchId;
            _operationType = operationType;
            this.OrderDetailId = orderDetailId;

            InitControls();

            if (operationType.Equals("ModifyOrderDetail"))
            {
                
                using (var context = new WDMSEntities())
                {
                    var orderDetail = context.OrderDetails.FirstOrDefault<OrderDetails>(od => od.OrderDatailId == orderDetailId);
                    if(orderDetail !=null)
                    {
                        this.lblOrderBatchId.Text = orderDetail.OrderBatchId.ToString();
                        this.comboBoxOrderType.SelectedValue = orderDetail.OrderType.Trim();
                        this.txtCount.Text = orderDetail.Count.ToString();
                        this.comboBoxOrderStatus.SelectedValue = orderDetail.Status.Trim();
                        this.comboBoxDeliveryWay.SelectedValue = orderDetail.DeliveryWay.Trim();
                        this.txtExpressNo.Text = orderDetail.ExpressNo.Trim();
                        this.txtRemrk.Text = orderDetail.Remark.Trim();
                        this.lblInventoryId.Text = orderDetail.InventoryId.ToString();
                        this.lblStyleNo.Text = orderDetail.Inventory.Styles.StyleNo.Trim();
                        this.lblSize.Text = orderDetail.Inventory.Size.Trim();
                    }
                }
            }
        }

        private void InitControls()
        {
            this.lblOrderBatchId.Text = _orderBatchId.ToString();

            List<ComboxItem> lstOrderType = GetComboxItemList("OrderType");
            this.comboBoxOrderType.DataSource = lstOrderType;
            this.comboBoxOrderType.DisplayMember = "Name";
            this.comboBoxOrderType.ValueMember = "Value";
            this.comboBoxOrderType.Refresh();

            List<ComboxItem> lstOrderStatus = GetComboxItemList("OrderStatus"); 
            this.comboBoxOrderStatus.DataSource = lstOrderStatus;
            this.comboBoxOrderStatus.DisplayMember = "Name";
            this.comboBoxOrderStatus.ValueMember = "Value";
            this.comboBoxOrderStatus.Refresh();

            List<ComboxItem> lstDeliveryType = GetComboxItemList("OrderDeliveryType"); 
            this.comboBoxDeliveryWay.DataSource = lstDeliveryType;
            this.comboBoxDeliveryWay.DisplayMember = "Name";
            this.comboBoxDeliveryWay.ValueMember = "Value";
            this.comboBoxDeliveryWay.Refresh();
        }

        private static List<ComboxItem> GetComboxItemList(string configKey)
        {
            List<ComboxItem> lstComboxItem;
            string[] arrOrderType = ConfigurationManager.AppSettings[configKey].Split(',');
            lstComboxItem = new List<ComboxItem>();
            foreach (string ot in arrOrderType)
            {
                ComboxItem ci = new ComboxItem(ot, ot);
                lstComboxItem.Add(ci);
            }

            return lstComboxItem;
        }

        private void btnInventroyReselect_Click(object sender, EventArgs e)
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
            orderDetail.Count = int.Parse(this.txtCount.Text.Trim());
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

        private void btnUpdateOrderDetail_Click(object sender, EventArgs e)
        {
            using (var context = new WDMSEntities())
            {
                var orderDetail = context.OrderDetails.First(od => od.OrderDatailId == this.OrderDetailId);
                orderDetail.InventoryId = int.Parse(this.lblInventoryId.Text.Trim());
                orderDetail.OrderType = this.comboBoxOrderType.SelectedValue.ToString();
                orderDetail.Status = this.comboBoxOrderStatus.SelectedValue.ToString();
                orderDetail.DeliveryWay = this.comboBoxDeliveryWay.SelectedValue.ToString();
                orderDetail.Count = int.Parse(this.txtCount.Text.Trim());
                orderDetail.ExpressNo = this.txtExpressNo.Text.Trim();
                orderDetail.UpdateTime = DateTime.Now;
                orderDetail.Remark = this.txtRemrk.Text.Trim();

                context.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }

            this.Close();
        }
    }
}
