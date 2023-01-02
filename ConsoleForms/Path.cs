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
                   
            }
        }

        
    }
}
