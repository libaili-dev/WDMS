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
        public Inventory SelectedInventory { get; set; }

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
            this.btnDeleteInventory.Visible = false;
        }

        public FormQueryInventory(string styleNo)
        {
            InitializeComponent();
            this.txtStyleNo.Text = styleNo;
            this.txtStyleNo.Enabled = false;
            InitControls();
            btnQueryInventory_Click(null, null);
        }

        public FormQueryInventory(bool isHideOperationControls)
        {
            InitializeComponent();
            InitControls();
            if(isHideOperationControls)
            {
                this.btnCreateNewInventory.Visible = false;
                this.btnModifyInventory.Visible = false;
                this.btnDeleteInventory.Visible = false;
            }
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
                    if (style == null || style.StyleId == 0)
                    {
                        this.lblMessage.Text = "该款式不存在，请先创建款式！";
                        this.btnCreateNewInventory.Visible = false;
                        this.btnModifyInventory.Visible = false;
                        this.btnDeleteInventory.Visible = false;
                        return;
                    }
                    else
                    {
                        _styleNo = style.StyleNo;
                        this.btnCreateNewInventory.Visible = true;
                        BindInventoryList(styleNo);
                    }
                }

            }
        }

        private void BindInventoryList(string styleNo)
        {
            this.gridInventory.DataSource = null;
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
                    this.btnDeleteInventory.Visible = true;
                    this.btnModifyInventory.Visible = true;
                }
                else
                {
                    this.lblMessage.Text = "该款式暂无库存信息！";
                }
            }
        }

        private void btnCreateNewInventory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_styleNo))
            {
                FormNewInventory frm = new FormNewInventory(_styleNo);
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindInventoryList(_styleNo);
                }
            }
            else
            {
                this.lblMessage.Text = "款式编码不能为空！";
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

        private void gridInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.gridInventory.RowCount > 0)
            {
                int inventoryId = int.Parse(this.gridInventory.SelectedRows[0].Cells["InventoryId"].Value.ToString());
                using (var context = new WDMSEntities())
                {
                    var inventory = (from inv in context.Inventory
                                     where inv.InventoryId == inventoryId
                                     select inv).ToList().First();

                    this.SelectedInventory = inventory;
                    this.SelectedInventory.Styles = inventory.Styles;
                    this.DialogResult = DialogResult.OK;
                }
            }
            this.Close();
        }

        private void btnDeleteInventory_Click(object sender, EventArgs e)
        {
            if (this.gridInventory.RowCount > 0)
            {
                int inventoryId = int.Parse(this.gridInventory.CurrentRow.Cells["InventoryId"].Value.ToString());
                using (var context = new WDMSEntities())
                {
                    var inv = context.Inventory.Find(inventoryId);
                    context.Inventory.Remove(inv);
                    context.SaveChanges();
                    this.lblMessage.Text = "已删除!";
                }
                BindInventoryList(this.txtStyleNo.Text.Trim());
            }
        }
    }
}
