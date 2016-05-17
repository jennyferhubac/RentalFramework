using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalFramework.entities;
using RentalFormApplication.entities;

namespace RentalFormApplication.database
{
    public class DBTables
    {
        public static List<AItem> ITEM_TABLE = new List<AItem>();


        public static void pOpulate_ITEM_TABLE()
        { 
           /* ITEM_TABLE.Add(new Car("123","Chevy","Cavalier","Economy",100));
            ITEM_TABLE.Add(new Car("456", "Chevy", "Cavalier", "Economy", 100));
            ITEM_TABLE.Add(new Car("980", "Chevy", "Nice", "Economy", 100));
            ITEM_TABLE.Add(new Car("980", "Chevy", "Fine", "Economy", 100));

            ITEM_TABLE.Add(new Book("3456", "Harry Potter", "Fictional Book", "Sci-Fi", 8));
            ITEM_TABLE.Add(new Book("3458", "Visions", "Horror Book", "Horror", 8));*/
        }
        private DBTables() { }

    }
}
