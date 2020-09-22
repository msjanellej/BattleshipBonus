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
        public Gameboard gameboard;
        public Gameboard opponentsBoard;
        public int score;
        public List<Ships> fleet;
        public Ships destroyer;
        public Ships submarine;
        public Ships battleship;
        public Ships aircraftCarrier;

        //constructor
        public Players()
        {
            opponentsBoard = new Gameboard();
            gameboard = new Gameboard();
            score = 0;
            destroyer = new Destroyer();
            submarine = new Submarine();
            battleship = new Battleship();
            aircraftCarrier = new AircraftCarrier();
            fleet = new List<Ships>() { destroyer, submarine, battleship, aircraftCarrier };
        }

        //member methods
        // output players game board to console
        // place ships
        // choose coordinates.
        //Check for hits? 
        
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
