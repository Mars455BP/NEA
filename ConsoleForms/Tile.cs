using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForms
{
    class Tile
    {
        public int x;
        public int y;
        public int cost;
        public int distance;
        public int costdistance;
        public Tile parentTile;

        public Tile(int lx, int ly, int lcost, int ldistance, Tile parent)
        {
            x = lx;
            y = ly;
            cost = lcost;
            distance = ldistance;
            parentTile = parent;
            costdistance = cost + distance;
        }
        


    }
}
