using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Players
    {
        //member variables
        // game board
        Gameboard gameboard;
        
        //constructor
        public Players()
        {
            //Instantiate the list of ships
            // list of ships
            
            gameboard = new Gameboard();
        }

        //member methods
        // output players game board to console
        // place ships
        // choose coordinates.
        public void PlaceShips()
        {
            Console.WriteLine("Please choose where you would like to place your ships");

        }
        public void ChooseAttack()
        {
            Console.WriteLine("Please choose which coordinates you would like to attack");
        }
    }
}
