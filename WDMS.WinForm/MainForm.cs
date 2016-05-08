using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WDMS.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        }
    }
}
