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
        public FormNewStyle()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateStyle_Click(object sender, EventArgs e)
        {
            this.lblMessage.Text = string.Empty;
            Styles style = new Styles();
            style.StyleNo = this.txtStyleNo.Text.Trim();
            style.Status = "";
            style.Description = this.txtDescription.Text.Trim();
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
                    }
                    else
                    {
                        this.lblMessage.Text = string.Format("新增款式：{0}失败！该编码号款式已经存在！", style.StyleNo);
                    }
                }
                catch (Exception)
                {
                    this.lblMessage.Text = string.Format("新增款式：{0}失败！", style.StyleNo);
                }


            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
