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
    public partial class FormNewOrder : Form
    {
        public Customer customer = new Customer();
        private int _orderBatchId = 0;

        public FormNewOrder()
        {
            InitializeComponent();

            this.gridOrderList.AllowUserToAddRows = false;
            this.gridOrderList.BackgroundColor = Color.White;
            this.gridOrderList.RowHeadersVisible = false;
            this.gridOrderList.MultiSelect = false;
            this.gridOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gridOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            using (var context = new WDMSEntities())
            {
                var adminList = (from admin in context.Admin
                                 select admin).ToList();
                if (adminList != null && adminList.Count > 0)
                {
                    this.cmbOperator.DataSource = adminList;
                    this.cmbOperator.ValueMember = "AdminId";
                    this.cmbOperator.DisplayMember = "AdminName";

                    this.cmbAssistant.DataSource = adminList.GetRange(0, adminList.Count());
                    this.cmbAssistant.ValueMember = "AdminId";
                    this.cmbAssistant.DisplayMember = "AdminName";
                }
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            FormQueryCustomer frm = new FormQueryCustomer("QueryFromOrder");
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.lblOrderMessage.Text = string.Empty;
                customer = frm.SelectedCustomer;
                this.lblCustomerName.Text = customer.CustomerName.Trim();
                this.lblMobile.Text = customer.Mobile.Trim();
                this.lblWeddingDate.Text = customer.WeddingDate.Value.ToString();
                this.lblRemark.Text = customer.Remark.ToString();



                using (var context = new WDMSEntities())
                {
                    var order = context.Orders.FirstOrDefault<Orders>(tmp => tmp.CustomerId == customer.CustomerId);
                    if (order == null)
                    {
                        this.lblOrderMessage.Text = "该用户没有订单。";
                        order = new Orders();
                        order.CustomerId = customer.CustomerId;
                        order.CreateTime = DateTime.Now;
                        order.Operator = int.Parse(this.cmbOperator.SelectedValue.ToString());
                        order.Assistant = int.Parse(this.cmbAssistant.SelectedValue.ToString());
                        context.Orders.Add(order);
                        context.SaveChanges();

                    }
                    else
                    {
                        var orderDetail = (from od in context.OrderDetails
                                           where od.OrderBatchId == order.OrderBatchId
                                           select new
                                           {
                                               od.OrderDatailId,
                                               od.OrderType,
                                               od.Status,
                                               od.DeliveryWay,
                                               od.ExpressNo,
                                               od.InventoryId,
                                               od.Count,
                                               od.Inventory.Styles.StyleNo,
                                               od.CreateTime,
                                               od.UpdateTime,
                                               od.Remark
                                           }).ToList();

                        if (orderDetail != null && orderDetail.Count > 0)
                        {
                            this.gridOrderList.DataSource = orderDetail;
                        }
                        else
                        {
                            this.lblOrderMessage.Text = "订单列表为空。";
                        }
                    }

                    this._orderBatchId = order.OrderBatchId;
                }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            this.lblMessage.Text = string.Empty;
            if (this.customer==null || this.customer.CustomerId==0)
            {
                this.lblMessage.Text = "请先选择客户。";
                return;
            }
            FormNewOrderDetail frm = new FormNewOrderDetail(_orderBatchId);
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.gridOrderList.DataSource = null;
                using (var context = new WDMSEntities())
                {
                    var orderDetailList = (from od in context.OrderDetails
                                           where od.OrderBatchId == _orderBatchId
                                           select new
                                           {
                                               od.OrderDatailId,
                                               od.OrderType,
                                               od.Status,
                                               od.DeliveryWay,
                                               od.ExpressNo,
                                               od.InventoryId,
                                               od.Inventory.Styles.StyleNo,
                                               od.Count,
                                               od.CreateTime,
                                               od.UpdateTime,
                                               od.Remark
                                           }).ToList();
                    if (orderDetailList.Count > 0)
                    {
                        this.gridOrderList.DataSource = orderDetailList;
                    }
                }

            }
        }

        private void btnModifyOrderDetail_Click(object sender, EventArgs e)
        {
            if (this.gridOrderList.RowCount > 0)
            {
                int orderDetailId = int.Parse(this.gridOrderList.CurrentRow.Cells["OrderDatailId"].Value.ToString());
                FormNewOrderDetail frm = new FormNewOrderDetail(_orderBatchId, orderDetailId, "ModifyOrderDetail");
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.gridOrderList.DataSource = null;
                    BindOrderDetails();

                }
            }
        }

        private void BindOrderDetails()
        {
            using (var context = new WDMSEntities())
            {
                var orderDetailList = (from od in context.OrderDetails
                                       where od.OrderBatchId == _orderBatchId
                                       select new
                                       {
                                           od.OrderDatailId,
                                           od.OrderType,
                                           od.Status,
                                           od.DeliveryWay,
                                           od.ExpressNo,
                                           od.InventoryId,
                                           od.Inventory.Styles.StyleNo,
                                           od.Count,
                                           od.CreateTime,
                                           od.UpdateTime,
                                           od.Remark
                                       }).ToList();
                if (orderDetailList.Count > 0)
                {
                    this.gridOrderList.DataSource = orderDetailList;
                }
            }
        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定删除该项订单？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (this.gridOrderList.RowCount > 0)
                {
                    int orderDetailId = int.Parse(this.gridOrderList.CurrentRow.Cells["OrderDatailId"].Value.ToString());
                    using (var context = new WDMSEntities())
                    {
                        var orderDetail = context.OrderDetails.FirstOrDefault(od => od.OrderDatailId == orderDetailId);
                        context.OrderDetails.Remove(orderDetail);
                        context.SaveChanges();
                        this.lblMessage.Text = "已删除！";
                    }

                    this.gridOrderList.DataSource = null;
                    BindOrderDetails();
                }
            }
        }
    }
}
