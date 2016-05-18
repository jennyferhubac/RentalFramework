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
            List<Role> roles = new List<Role>();
            roles.Add(new Role { RoleId = 1, Name = "Admin" });
            roles.Add(new Role { RoleId = 2, Name = "User" });
            AUser user = new User
            {
                UserId=1,
                UserName = txtUserName.Text.Trim(),
                Password = txtPassword.Text,
                Roles = new Role { RoleId = 1, Name = "Admin" }
            };

            AUser loginInfo = userService.Login(user);

            if (loginInfo != null)
            {
                MDIRental.UserId = loginInfo.UserId;
                this.Close();
            }
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
    }
}
