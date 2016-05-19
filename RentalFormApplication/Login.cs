using RentalFormApplication.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalFramework.entities;
using RentalFormApplication.entities;

namespace RentalFormApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            MDIRental.UserName = txtUserName.Text;
            Form frm = (Form)this.MdiParent;
            StatusStrip statusStrip = (StatusStrip)frm.Controls["statusStrip"];
            statusStrip.Items["userName"].Text=$"Logged in as: {txtUserName.Text}";

            UserService userService = new UserService();
            AUser user = new User
            {
                UserName = txtUserName.Text.Trim(),
                Password = txtPassword.Text
            };

            User loginInfo = userService.Login(user) as User;

            if (loginInfo != null)
            {
                MDIRental.UserId = loginInfo.UserId;
                MDIRental.UserName = loginInfo.UserName;
                this.Close();
            }
            lblErrorMsg.Visible = true;
        }

        private AUser User()
        {
            throw new NotImplementedException();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            lblErrorMsg.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblErrorMsg.Visible = false;
        }
    }
}
