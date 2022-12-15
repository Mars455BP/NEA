using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForms
{
    class Program
    {
        

        public static int itemstopick;
        public static string[] strList = new string[999];

        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Welcome to NEA");
            Console.WriteLine("Debug Log for Mark Adams' NEA - Refined Picking App");
            //Creating Items
            Console.WriteLine("Creating Items");
            //Dairy
            item cheese = new item(77, 389, "Cheese");
            item milk = new item(127, 326, "Milk");
            item eggs = new item(77, 425, "Eggs");

            //Fruit and Veg
            item tomatoes = new item(102, 393, "Tomatoes");
            item apples = new item(136, 389, "Apples");
            item bananas = new item(185, 363, "Bananas");

            //Herbs, Spices and Tins
            item garlic = new item(244, 389, "Garlic");
            item chilliPowder = new item(244, 358, "Chilli Powder");
            item choppedTomatoes = new item(194, 325, "Chopped Tomatoes");
            item bakedBeans = new item(194, 273, "Baked Beans");

            //Frozen
            item frozenPizza = new item(252, 308, "Frozen Pizza");
            item iceCream = new item(301, 389, "Ice Cream");

            //Pet
            item dogFood = new item(359, 298, "Dog Food");
            item dogToys = new item(359, 364, "Dog Toys");
            item catFood = new item(310, 389, "Cat Food");

            //Array containing items to be searched for in this shop
            Console.WriteLine("Creating toPick");
            item[] toPick = new item[999];

            Console.WriteLine("Asking user for items...");
            //Asking user for items they want to pick
            selectItems selectList = new selectItems();
            selectList.ShowDialog();
            Console.WriteLine("Items found correctly!");
            strList = selectList.returnList();
            //Creating Pick List
            Console.WriteLine("Pick List being created");
            PickList PL = new PickList();
            itemstopick = selectList.returnList().Length;
            Console.WriteLine("Creating user interface");
            //Creating User Interface
            UserInterface UI = new UserInterface();
            UI.ShowDialog();
            Console.WriteLine("Showing UI");
        }
    }
}
