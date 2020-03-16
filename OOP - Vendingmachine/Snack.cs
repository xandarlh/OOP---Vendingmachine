using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Vendingmachine
{
    public class Snack
    {               
        private string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Snack(string name, int price)
        {
            this.Name = name;         
            this.Price = price;
        }
        
        

       

        
    }
}
