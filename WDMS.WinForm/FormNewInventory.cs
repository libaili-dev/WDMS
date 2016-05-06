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
        public FormNewInventory()
        {
            InitializeComponent();

            this.gridInventory.AllowUserToAddRows = false;
            this.gridInventory.BackgroundColor = Color.White;
            this.gridInventory.RowHeadersVisible = false;
            this.gridInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnQueryInventory_Click(object sender, EventArgs e)
        {
                
        }

        private void btnCreateNewInventory_Click(object sender, EventArgs e)
        {

        }


        public void BindInventoryList()
        {
            string styleNo = this.txtStyleNo.Text.Trim();
            if(!string.IsNullOrEmpty(styleNo))
            {
                using (var context = new WDMSEntities())
                {
                   var styleIdList = (from style in context.Styles
                                  where style.StyleNo.Contains(styleNo)
                                  select style.StyleId).ToList();
                    if(styleIdList.Count>0)
                    {

                    }
                    //var inventoryList = from inv in context.Inventory  where inv.StyleId.Equals()

                }

            }
        }
    }
}
