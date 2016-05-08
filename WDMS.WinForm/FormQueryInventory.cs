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
    public partial class FormQueryInventory : Form
    {
        private string _styleNo = string.Empty;
        public FormQueryInventory()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            this.gridInventory.AllowUserToAddRows = false;
            this.gridInventory.BackgroundColor = Color.White;
            this.gridInventory.RowHeadersVisible = false;
            this.gridInventory.MultiSelect = false;
            this.gridInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gridInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.btnCreateNewInventory.Visible = false;
        }

        public FormQueryInventory(string styleNo)
        {
            InitializeComponent();
            InitControls();
            this.txtStyleNo.Text= styleNo;
            btnQueryInventory_Click(null, null);
        }

        private void btnQueryInventory_Click(object sender, EventArgs e)
        {
            this.btnCreateNewInventory.Visible = false;
            this.lblMessage.Text = string.Empty;
            string styleNo = this.txtStyleNo.Text.Trim();
            if (string.IsNullOrEmpty(styleNo))
            {
                MessageBox.Show("查询库存时款式编号不能为空！");
            }
            else
            {
                using (var context = new WDMSEntities())
                {
                    var style = context.Styles.FirstOrDefault<Styles>(tmp => tmp.StyleNo.Equals(styleNo));
                    if (style == null || style.StyleId==0)
                    {
                        this.lblMessage.Text = "该款式不存在，请先创建款式！";
                        return;
                    }
                    else
                    {
                        _styleNo = style.StyleNo;
                        this.btnCreateNewInventory.Visible = true;
                    }
                }

                using (var context = new WDMSEntities())
                {
                    //var invList = context.Inventory.Where(t => t.Styles.StyleNo.Equals(styleNo)).ToList();
                    var invList = (from tmpInv in context.Inventory
                                   where tmpInv.Styles.StyleNo.Equals(styleNo)
                                   select new
                                   {
                                       tmpInv.InventoryId,
                                       tmpInv.Size,
                                       tmpInv.TotalCount,
                                       tmpInv.RentPrice,
                                       tmpInv.SellPrice,
                                       tmpInv.CreateTime,
                                       tmpInv.UpdateTime,
                                       tmpInv.Remark
                                   }).ToList();
                    if (invList != null && invList.Count > 0)
                    {
                        this.gridInventory.DataSource = invList;
                        this.btnCreateNewInventory.Visible = true;
                    }
                    else
                    {
                        this.lblMessage.Text = "该款式暂无库存信息！";
                    }
                }
            }
        }

        private void btnCreateNewInventory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_styleNo))
            {
                FormNewInventory frm = new FormNewInventory(_styleNo);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
            else
            {
                this.lblMessage.Text = "款式编码不能为空！";
            }
        }


        public void BindInventoryList()
        {
            string styleNo = this.txtStyleNo.Text.Trim();
            if (!string.IsNullOrEmpty(styleNo))
            {
                using (var context = new WDMSEntities())
                {
                    var curStyleId = (from style in context.Styles
                                      where style.StyleNo.Equals(styleNo)
                                      select style.StyleId).ToString();
                    if (!string.IsNullOrEmpty(curStyleId))
                    {
                        var inventoryList = (from inv in context.Inventory
                                             where inv.StyleId.Equals(curStyleId)
                                             select new
                                             {
                                                 inv.InventoryId,
                                                 inv.Styles.StyleNo,
                                                 inv.Size,
                                                 inv.TotalCount,
                                                 inv.CreateTime,
                                                 inv.Remark
                                             }).ToList();
                        if (inventoryList.Count > 0)
                        {
                            this.gridInventory.DataSource = inventoryList;
                        }
                        else
                        {
                            this.lblMessage.Text = "该款式暂无库存信息！";
                        }
                    }

                }

            }
        }

        private void btnModifyInventory_Click(object sender, EventArgs e)
        {
            if(this.gridInventory.RowCount>0)
            {
                int inventoryId = int.Parse(this.gridInventory.SelectedRows[0].Cells["InventoryId"].Value.ToString());
                FormNewInventory frm = new FormNewInventory(_styleNo, inventoryId);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }
    }
}
