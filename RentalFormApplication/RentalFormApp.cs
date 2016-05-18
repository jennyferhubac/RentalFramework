using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RentalFormApplication.commands;
using RentalFormApplication.Service;
using RentalFormApplication.entities;
using RentalFormApplication.dto;
using RentalFramework.entities;

namespace RentalFormApplication
{
    public partial class RentalFormApp : Form
    {
        TransactionServiceImpl tranServImpl = TransactionServiceImpl.getService();
        public RentalFormApp()
        {
            InitializeComponent();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            Request r = new Request(textBox1.Text);
            TransactionDTO tdto = new TransactionDTO("123", DateTime.Now, 0.0, 0.0, "CHECKOUT", r);
            CreateTransactionCommand transCommand = new CreateTransactionCommand(tranServImpl, tdto);

            transCommand.exeute();

            IEnumerable<ATransaction> lst = tranServImpl.getAllTransactions();
            foreach(ATransaction l in lst)
            {
                txtShowTrans.Text += l.ToString();
            }

        }

        private void RentalFormApp_Load(object sender, EventArgs e)
        {
            initializeViewColoumn();
        }

        private void initializeViewColoumn()
        {

        }
    }
}
