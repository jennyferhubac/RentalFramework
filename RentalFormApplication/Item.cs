using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalFramework.dto;
using RentalFormApplication.Service;
using RentalFormApplication.entities;
using RentalFormApplication.dto;
using RentalFramework.entities;

namespace RentalFormApplication
{

    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
        }

        private void Item_Load(object sender, EventArgs e)
        {



            initializeViewColumns();
            
             
        }

        public void initializeViewColumns()
        {
            CarListView.Columns.Add("Item ID");
            CarListView.Columns.Add("Make");
            CarListView.Columns.Add("Model");
            CarListView.Columns.Add("Category");
            CarListView.Columns.Add("Price");

            BookListView.Columns.Add("Item ID");
            BookListView.Columns.Add("Title");
            BookListView.Columns.Add("Description");
            BookListView.Columns.Add("Category");
            BookListView.Columns.Add("NumBorrowDays");
        }

        private void btnLoadCar_Click(object sender, EventArgs e)
        {
            LoadCar();
        }

        private void btnLoadBook_Click(object sender, EventArgs e)
        {
            LoadBook();
        }


        public void LoadBook()
        {
            BookListView.Items.Clear();
            List<ItemDTO> bookList = ItemServiceImp.getInstance().getAllBookItems();
            
            foreach (BookDTO elem in bookList)
            {
                ListViewItem item = new ListViewItem(elem.getItemID());
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, elem.getTitle()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, elem.getDescription()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, elem.getCategory()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, elem.getNumBorrowDays().ToString()));
                BookListView.Items.Add(item);

            }

            BookListView.View = View.Details;
        }

        
        public void LoadCar()
        {
            CarListView.Items.Clear();
            List<ItemDTO> carList = ItemServiceImp.getInstance().getAllCarItems();
            
            foreach (CarDTO elem in carList)
            {
                ListViewItem item = new ListViewItem(elem.getItemID());
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, elem.getMake()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, elem.getModel()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, elem.getCategory()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, elem.getPrice().ToString()));
                CarListView.Items.Add(item);

            }

            CarListView.View = View.Details;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(100, 1000);
            ItemServiceImp.getInstance().addItem(new Car(randomNumber.ToString(), "Chevy", "Cavalier", "Economy", 1000));
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(100, 1000);
            ItemServiceImp.getInstance().addItem(new Book(randomNumber.ToString(),"Harry Poter","Sci-Fiction book", "Sci-Fi",10));

        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            AItem book = ItemServiceImp.getInstance().findItem(BookItemID.Text);
            ItemServiceImp.getInstance().removeItem(book);
        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            AItem car = ItemServiceImp.getInstance().findItem(CarItemID.Text);
            ItemServiceImp.getInstance().removeItem(car);
           
           
        }
    }
}

