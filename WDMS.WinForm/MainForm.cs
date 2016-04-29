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
            fmNewCustomer.ShowDialog();
        }

        private void queryCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQueryCustomer frm = new FormQueryCustomer();
            frm.ShowDialog();
        }
    }
}
