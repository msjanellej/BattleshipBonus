using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Game
    {
        // member variables
        public Players playerOne;
        public Players playerTwo;

        //constructor
        public Game()
        {
            playerOne = new Players();
            playerTwo = new Players();
        }
        //member methods
        public void RunGame()
        {
            GiveRules();
            playerOne.PlaceShips();
            Console.Clear();
            playerTwo.PlaceShips();
            Console.Clear();
            PlayRound();
        }
        public void GiveRules()
        {
            Console.WriteLine("Welcome to Battleship!");
            Console.WriteLine();
            Console.WriteLine("Below are the rules:");
            Console.WriteLine();
            Console.WriteLine("First, Choose where your ships will be located on the gameboard");
            Console.WriteLine();
            Console.WriteLine("On each players turn, players will attack a single position");
            Console.WriteLine("on their opponent's gameboard");
            Console.WriteLine();
            Console.WriteLine("If the attack hits an opponents it will show up as a 'hit'");
            Console.WriteLine("If it does not hit it will show up as a 'miss'");
            Console.WriteLine("The gameboard will show a record of 'hits' & 'misses'");
            Console.WriteLine();
            Console.WriteLine("A battleship will be sunk if it has been hit on all squares it occupies");
            Console.WriteLine();
            Console.WriteLine("The First player to sink all of their opponents ships will be the winner");
            Console.WriteLine();
            Console.WriteLine("Hit the enter key when you are ready to begin & Good Luck");
            Console.ReadLine();

        }
        public void PlayRound()
        {
            while (IsGameContinuing())
            {

            }

        }

        public bool IsGameContinuing()
        {
            if (playerOne.score ==4 || playerTwo.score == 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //public void CheckifSunk() Not sure where to place this. 
        //{
        //    if (ship.isSunk)
        //    {
        //        playerOne.score++;
        //    }
        //}
        public void DisplayWinner()
        {
            if (playerOne.score == 4)
            {
                Console.WriteLine("Player One Wins!!!");
            }
            else if (playerTwo.score == 4)
            {
                Console.WriteLine("Player Two Wins!!!");
            }
        }



        // will need to call method to place ships
        // need a play round method
        // will need to show each player their game board with ship placement
        // will need to show the opponents gameboard with ships hidden (unless theyve been hit) - call method
        // will need a select coordinates/ attack to choose where player wants to attack - call method
        // will need a Check for hits method to check to see if there is a hit
        // need a is game continuing method

    }
}
