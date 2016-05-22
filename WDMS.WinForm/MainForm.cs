using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WDMS.EF;

namespace WDMS.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.gridToDelivery.AllowUserToAddRows = false;
            this.gridToDelivery.BackgroundColor = Color.White;
            this.gridToDelivery.RowHeadersVisible = false;
            this.gridToDelivery.MultiSelect = false;
            this.gridToDelivery.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gridToDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            InitGridToDelivery();
        }

        private void newCustomerSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewCustomer fmNewCustomer = new FormNewCustomer();
            fmNewCustomer.StartPosition = FormStartPosition.CenterParent;
            fmNewCustomer.ShowDialog();
        }

        private void queryCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQueryCustomer frm = new FormQueryCustomer();
            frm.StartPosition = FormStartPosition.CenterParent; 
            frm.ShowDialog();
        }

        private void queryStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQueryStyle frm = new FormQueryStyle();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void newStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewStyle frm = new FormNewStyle();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void adminConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQueryAdmin frm = new FormQueryAdmin();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void newInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQueryInventory frm = new FormQueryInventory();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void queryInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQueryInventory frm = new FormQueryInventory();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewOrder frm = new FormNewOrder();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void ParamConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitGridToDelivery();
        }

        private void InitGridToDelivery()
        {
            int scheduleDays = 7;
            using (var context = new WDMSEntities())
            {
                var orderList = (from order in context.Orders
                                 where DbFunctions.DiffDays(DateTime.Today, order.Customer.WeddingDate) < scheduleDays
                                 select new
                                 {
                                     order.OrderBatchId,
                                     order.Status,
                                     order.Customer.CustomerName,
                                     order.Customer.Mobile,
                                     order.Customer.WeddingDate,
                                     order.Operator,
                                     order.Assistant

                                 }).ToList();
                this.gridToDelivery.DataSource = orderList;
            }
        }
    }
}
