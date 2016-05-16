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
                                           select od).ToList<OrderDetails>();
                        
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
            FormNewOrderDetail frm = new FormNewOrderDetail(_orderBatchId);
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
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
    }
}
