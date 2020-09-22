using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Gameboard
    {
        // member variables
        //declare array
        public List<Ships> fleet;
        public Ships destroyer;
        public Ships submarine;
        public Ships battleship;
        public Ships aircraftCarrier;
        //constructor
        public Gameboard()
        {
            destroyer = new Destroyer();
            submarine = new Submarine();
            battleship = new Battleship();
            aircraftCarrier = new AircraftCarrier();
            fleet = new List<Ships>() { destroyer, submarine, battleship, aircraftCarrier };

            // instantiate array here. 
            // should array hold the coordinates until it has been used.
        }

        //member methods
        // method to choose location of ships should be here
        // method to choose where to attack should be here.
        
    }
}
