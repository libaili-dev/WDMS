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
    public partial class FormNewStyle : Form
    {
        private int _styleId = 0;
        public FormNewStyle()
        {
            InitializeComponent();
            this.btnEditStyle.Visible = false;
            this.btnCreateStyle.Visible = true;
        }

        public FormNewStyle(int styleId)
        {
            InitializeComponent();
            this.btnEditStyle.Visible = true;
            this.btnCreateStyle.Visible = false;
            List<ComboxItem> lstComboxItem = new List<ComboxItem>();
            ComboxItem cItemAvailable = new ComboxItem("Available", "Available");
            ComboxItem cItemUnavailabel = new ComboxItem("Unavailable", "Unavailable");
            lstComboxItem.Add(cItemAvailable);
            lstComboxItem.Add(cItemUnavailabel);
            this.comboBoxStyleStatus.DataSource = lstComboxItem;
            this.comboBoxStyleStatus.DisplayMember = "Name";
            this.comboBoxStyleStatus.ValueMember = "Value";
            using (var context = new WDMSEntities())
            {
                var model = context.Styles.Find(styleId);
                if(model!=null)
                {
                    this.txtStyleNo.Text = model.StyleNo;
                    this.txtDescription.Text = model.Description;
                    this.comboBoxStyleStatus.SelectedValue = model.Status.Trim();
                    _styleId = model.StyleId;
                }
            }
            this.comboBoxStyleStatus.Refresh();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnCreateStyle_Click(object sender, EventArgs e)
        {
            this.lblMessage.Text = string.Empty;
            Styles style = GetStyleFromGUI();
            style.CreateTime = DateTime.Now;

            using (var context = new WDMSEntities())
            {
                try
                {
                    Styles checkStyle = context.Styles.FirstOrDefault(t => t.StyleNo.Equals(style.StyleNo));
                    if (checkStyle == null)
                    {
                        context.Styles.Add(style);

                        context.SaveChanges();
                        this.lblMessage.Text = string.Format("新增款式：{0}成功！", style.StyleNo);
                        this.txtStyleNo.Text = string.Empty;
                        this.txtDescription.Text = string.Empty;
                    }
                    else
                    {
                        this.lblMessage.Text = string.Format("新增款式：{0}失败！该编码号款式已经存在！", style.StyleNo);
                    }
                }
                catch
                {
                    this.lblMessage.Text = string.Format("新增款式：{0}失败！", style.StyleNo);
                }


            }
        }

        private Styles GetStyleFromGUI()
        {
            Styles style = new Styles();
            style.StyleNo = this.txtStyleNo.Text.Trim();
            style.Status = this.comboBoxStyleStatus.SelectedValue.ToString();
            style.Description = this.txtDescription.Text.Trim();
            return style;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnEditStyle_Click(object sender, EventArgs e)
        {
            Styles style = GetStyleFromGUI();
            using (var context = new WDMSEntities())
            {
                var dbStyle = context.Styles.Find(_styleId);
                dbStyle.StyleNo = style.StyleNo;
                dbStyle.Status = style.Status;
                dbStyle.Description = style.Description;
                dbStyle.Images = style.Images;

               // context.Styles.Attach(dbStyle);
                //context.Entry<Styles>(dbStyle).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();

                this.lblMessage.Text = "款式信息更新成功！";
            }
        }
    }
}
