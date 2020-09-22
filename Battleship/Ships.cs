using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class  Ships
    {
        // member variables
        public string name;
        public int width;
        // hits
        public bool isSunk; //why is it not having a value associated with it?

        //constructor
        public  Ships()
        {
            isSunk = true;

        }

        //member methods
        public bool CheckifSunk() //not sure if this should be an abstract class bc all ships have diff sizes
        {
            if (isSunk)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        


    }
}
