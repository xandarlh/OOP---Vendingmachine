using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Vendingmachine
{
    public class VendingMachine
    {
        private int choosesnack;       
        public int Choosesnack
        {
            get { return choosesnack; }
            set { choosesnack = value; }
        }

        List<Snack> snacks = new List<Snack>();
        Snack marsbar = new Snack("Marsbar", 10);
        Snack twix = new Snack("Twix", 10);
        Snack chips = new Snack("Chips", 15);
        Snack cookie = new Snack("Cookie", 5);
        Snack soda = new Snack("Soda", 24);

        //this methods selects a snack and returns the name of the snack
        public Snack SelectSnack()
        {          
            switch (Choosesnack)
            {
                case 1:
                    Console.WriteLine(marsbar.Name);
                    return marsbar;
                   
                case 2:
                    Console.WriteLine(twix.Name);
                    return twix;
                   
                case 3:
                    Console.WriteLine(chips.Name);
                    return chips;
                    
                case 4:
                    Console.WriteLine(cookie.Name);
                    return cookie;
                   
                case 5:
                    Console.WriteLine(soda.Name);
                    return soda;
                    
                default:
                    Console.WriteLine("You broke the machine!!");
                    return null;
            }
            
        }
        public Transaction GiveMoney()
        {
            if (choosesnack == 1)
            {
                    
            }
            return null;
        }

    }   
}
