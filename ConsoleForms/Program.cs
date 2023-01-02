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
            Console.WriteLine("Debug Log for Mark Adams' NEA - Refined Picking App");
            //Creating Items
            Console.WriteLine("Creating Items");
            //Dairy
            item cheese = new item(1, "Cheese");
            item milk = new item(1, "Milk");
            item eggs = new item(1, "Eggs");

            //Fruit and Veg
            item tomatoes = new item(2, "Tomatoes");
            item apples = new item(2, "Apples");
            item bananas = new item(2, "Bananas");

            //Herbs, Spices and Tins
            item garlic = new item(3, "Garlic");
            item chilliPowder = new item(3, "Chilli Powder");
            item choppedTomatoes = new item(3, "Chopped Tomatoes");
            item bakedBeans = new item(3, "Baked Beans");

            //Frozen
            item frozenPizza = new item(4, "Frozen Pizza");
            item iceCream = new item(4, "Ice Cream");

            //Pet
            item dogFood = new item(5, "Dog Food");
            item dogToys = new item(5, "Dog Toys");
            item catFood = new item(5, "Cat Food");

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
            Path path = new Path(strList);
            Console.WriteLine("Creating user interface");
            //Creating User Interface
            UserInterface UI = new UserInterface();
            UI.ShowDialog();
            Console.WriteLine("Showing UI");
            
        }
    }
}
