using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Vendingmachine
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            

            VendingMachine vending = new VendingMachine();
            SnackMenu menu = new SnackMenu();

            menu.SnackMenuGUI();
            vending.Choosesnack = int.Parse(Console.ReadLine());
            vending.SelectSnack();
            vending.GiveMoney();

            Console.ReadLine();
            


            



        }
    }
}
