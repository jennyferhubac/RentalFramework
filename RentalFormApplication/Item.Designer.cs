namespace RentalFormApplication
{
partial class Item
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CarListView = new System.Windows.Forms.ListView();
            this.BookListView = new System.Windows.Forms.ListView();
            this.btnLoadCar = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnRemoveCar = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnLoadBook = new System.Windows.Forms.Button();
            this.CarItemID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BookItemID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CarListView
            // 
            this.CarListView.Location = new System.Drawing.Point(12, 12);
            this.CarListView.Name = "CarListView";
            this.CarListView.Size = new System.Drawing.Size(316, 187);
            this.CarListView.TabIndex = 1;
            this.CarListView.UseCompatibleStateImageBehavior = false;
            // 
            // BookListView
            // 
            this.BookListView.Location = new System.Drawing.Point(12, 205);
            this.BookListView.Name = "BookListView";
            this.BookListView.Size = new System.Drawing.Size(316, 187);
            this.BookListView.TabIndex = 2;
            this.BookListView.UseCompatibleStateImageBehavior = false;
            // 
            // btnLoadCar
            // 
            this.btnLoadCar.Location = new System.Drawing.Point(375, 140);
            this.btnLoadCar.Name = "btnLoadCar";
            this.btnLoadCar.Size = new System.Drawing.Size(193, 24);
            this.btnLoadCar.TabIndex = 3;
            this.btnLoadCar.Text = "Show Changes";
            this.btnLoadCar.UseVisualStyleBackColor = true;
            this.btnLoadCar.Click += new System.EventHandler(this.btnLoadCar_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(375, 44);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(193, 24);
            this.btnAddCar.TabIndex = 4;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Location = new System.Drawing.Point(476, 86);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(92, 24);
            this.btnRemoveCar.TabIndex = 5;
            this.btnRemoveCar.Text = "Remove Car";
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(476, 262);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(92, 24);
            this.btnRemoveBook.TabIndex = 8;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(375, 221);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(193, 24);
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnLoadBook
            // 
            this.btnLoadBook.Location = new System.Drawing.Point(375, 295);
            this.btnLoadBook.Name = "btnLoadBook";
            this.btnLoadBook.Size = new System.Drawing.Size(193, 24);
            this.btnLoadBook.TabIndex = 6;
            this.btnLoadBook.Text = "Show Changes";
            this.btnLoadBook.UseVisualStyleBackColor = true;
            this.btnLoadBook.Click += new System.EventHandler(this.btnLoadBook_Click);
            // 
            // CarItemID
            // 
            this.CarItemID.Location = new System.Drawing.Point(422, 90);
            this.CarItemID.Name = "CarItemID";
            this.CarItemID.Size = new System.Drawing.Size(48, 20);
            this.CarItemID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Item ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Item ID:";
            // 
            // BookItemID
            // 
            this.BookItemID.Location = new System.Drawing.Point(422, 262);
            this.BookItemID.Name = "BookItemID";
            this.BookItemID.Size = new System.Drawing.Size(48, 20);
            this.BookItemID.TabIndex = 11;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookItemID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarItemID);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnLoadBook);
            this.Controls.Add(this.btnRemoveCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnLoadCar);
            this.Controls.Add(this.BookListView);
            this.Controls.Add(this.CarListView);
            this.Name = "Item";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView CarListView;
        private System.Windows.Forms.ListView BookListView;
        private System.Windows.Forms.Button btnLoadCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnRemoveCar;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnLoadBook;
        private System.Windows.Forms.TextBox CarItemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BookItemID;

    }
}