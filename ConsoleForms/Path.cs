using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForms
{
    class Path 
    {
        string[] strList = new string[999];
        string[] path = new string[999];
        int aisleNum;
        public Path(string[] list)
        {
            strList = list;
            Console.Write("The List Order: ");
            for (int i = 0; i < strList.Count(); i++)
            {
                Console.Write(strList[i] + " ,");
            }
            Console.WriteLine();
            for (int i = 0; i < strList.Count(); i++)
            {
                Console.WriteLine(strList[i]);
            }
        }
        int Aisle(string str)
        {
            switch (str)
            {
                case "Eggs":
                case "Milk":
                case "Cheese":
                    aisleNum = 1;
                    break;
                case "Tomato":
                case "Banana":
                case "Apples":
                    aisleNum = 2;
                    break;
            }
            return 0;
        }
        
    }
}
