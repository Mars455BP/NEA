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

        static void Main(string[] args)
        {
            PickList PL = new PickList();
            itemstopick = PL.CountOfBoxes;
            UserInterface UI = new UserInterface();
            UI.ShowDialog();
            
        }
    }
}
