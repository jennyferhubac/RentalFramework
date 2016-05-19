using RentalFormApplication.database;
using RentalFormApplication.entities;
using RentalFormApplication.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace RentalFormApplication
{
    public sealed partial class AddUser : Form
    {
        private static bool IsShown = false;
        private static readonly AddUser MyInstance = new AddUser();
        public static AddUser OnlyInstance
        {
            get { return MyInstance; }
        }
        public new void Show()
        {
            if (IsShown)
                base.Show();
            else
            {
                base.Show();
                IsShown = true;
            }
        }
        private AddUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text.Trim()))
            {
                txtUserName.Focus();
                return;
            }
            Random rd = new Random();
            int id = Convert.ToInt32(dgvRoles.SelectedRows[0].Cells[0].Value.ToString());
            string name = dgvRoles.SelectedRows[0].Cells[1].Value.ToString();
            User user = new User
            {
                UserId = rd.Next(1000),
                UserName = txtUserName.Text.Trim(),
                Password="123",
                Roles =new Role {RoleId=id, Name = name }
            };

            UserService userService = new UserService();
            userService.AddUser(user);
            List<User> users = DBTables.USER_TABLE.Select(u => u as User).ToList();
            dgvUsers.DataSource = users;

            txtUserName.Clear();
            txtUserName.Focus();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoleName.Text.Trim()))
            {
                txtRoleName.Focus();
                return;
            }
            Random rd = new Random();
            Role role = new Role
            {
                RoleId = rd.Next(1000),
                Name = txtRoleName.Text.Trim()                
            };

            RoleService userService = new RoleService();
            userService.AddRole(role);
            List<Role> roles = DBTables.ROLE_TABLE.Select(r => r as Role).ToList();
            dgvRoles.DataSource = roles;
            txtRoleName.Clear();
            txtRoleName.Focus();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            dgvUsers.AutoGenerateColumns = false;  
            dgvRoles.AutoGenerateColumns = false;

            List<User> users = DBTables.USER_TABLE.Select(u => u as User).ToList();
            dgvUsers.DataSource = users;

            List<Role> roles = DBTables.ROLE_TABLE.Select(r => r as Role).ToList();
            dgvRoles.DataSource = roles;
        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CellFormatting(sender, e);
        }

        private static void CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            DataGridViewColumn col = grid.Columns[e.ColumnIndex];
            if (row.DataBoundItem != null && col.DataPropertyName.Contains("."))
            {
                string[] props = col.DataPropertyName.Split('.');
                PropertyInfo propInfo = row.DataBoundItem.GetType().GetProperty(props[0]);
                object val = propInfo.GetValue(row.DataBoundItem, null);
                for (int i = 1; i < props.Length; i++)
                {
                    propInfo = val.GetType().GetProperty(props[i]);
                    val = propInfo.GetValue(val, null);
                }
                e.Value = val;
            }
        }

        private void AddUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            OnlyInstance.Hide();
        }
    }
}
