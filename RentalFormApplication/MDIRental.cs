using RentalFormApplication.database;
using RentalFormApplication.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalFormApplication
{
    public partial class MDIRental : Form
    {
        public static string UserName { get; set; }
        public static int UserId { get; set; }

        private int childFormNumber = 0;

        public MDIRental()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Item());
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userName.Text = $"Logged in as:";
            CloseAllForms();
            ShowForm(new Login());
        }

        private void CloseAllForms()
        {
            foreach (Form childForm in MdiChildren)
            {
                if (childForm.GetType() != new Login().GetType())
                    childForm.Close();
            }
        }
        private void ShowForm(Form FormToBeOpened)
        {
            foreach (Form form in MdiChildren)
            {
                if (form.GetType() == FormToBeOpened.GetType() 
                    || form.GetType() == new Login().GetType())
                {
                    form.Activate();
                    form.Show();
                    return;
                }
            }

            FormToBeOpened.MdiParent = this;
            FormToBeOpened.StartPosition = FormStartPosition.Manual;
            FormToBeOpened.Location = new Point(Width / 2 - FormToBeOpened.Width / 2
                , Height / 2 - (FormToBeOpened.Height+150) / 2);
            FormToBeOpened.Show();
        }

        private void MDIRental_Load(object sender, EventArgs e)
        {
            DBTables.USER_TABLE.Add(new User { UserName = "admin", Password = "123", Roles = new Role { Name = "admin", RoleId = 1 } });
            ShowForm(new Login());
        }

        private void checkoutItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new RentalFormApp());
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(AddUser.OnlyInstance);
        }
    }
}
