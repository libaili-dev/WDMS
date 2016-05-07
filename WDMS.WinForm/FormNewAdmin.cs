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
    public partial class FormNewAdmin : Form
    {
        public FormNewAdmin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            string validateMsg = ValidateInputs();
            if (!string.IsNullOrEmpty(validateMsg))
            {
                this.lblMessage.Text = validateMsg;
                return;
            }
            this.lblMessage.Text = string.Empty;
            int adminRoleId = this.comboBoxAdminRole.SelectedIndex + 1;
            Admin admin = new Admin();
            admin.AdminName = this.txtAdminName.Text.Trim();
            admin.AdminRoldId = adminRoleId;
            admin.Password = this.txtPassword.Text.Trim();

            using (var context = new WDMSEntities())
            {
                try
                {
                    Admin checkAdmin = context.Admin.FirstOrDefault(t => t.AdminName.Equals(admin.AdminName));
                    if (checkAdmin == null)
                    {
                        context.Admin.Add(admin);
                        context.SaveChanges();
                        this.lblMessage.Text = string.Format("添加管理员：{0}成功！", admin.AdminName);
                    }
                    else
                    {
                        this.lblMessage.Text = string.Format("添加管理员：{0}失败！该管理员已经存在！", admin.AdminName);
                    }
                }
                catch (Exception)
                {
                    this.lblMessage.Text = string.Format("添加管理员：{0}失败！", admin.AdminName);
                }


            }
        }


        private string ValidateInputs()
        {
            if (string.IsNullOrEmpty(this.txtAdminName.Text.Trim()))
            {
                return "管理员姓名不能为空！";
            }

            if (string.IsNullOrEmpty(this.txtPassword.Text.Trim()) ||
                string.IsNullOrEmpty(this.txtPasswordConfirm.Text.Trim()))
            {
                return "密码或确认密码不能为空！";
            }

            if (!this.txtPassword.Text.Trim().Equals(this.txtPasswordConfirm.Text.Trim()))
            {
                return "两次密码输入不匹配，请重新输入！";
            }

            return string.Empty;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
