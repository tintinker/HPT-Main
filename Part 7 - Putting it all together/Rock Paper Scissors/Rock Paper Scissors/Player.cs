using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Player
    {
        public int wins;
        public int loses;

        public String name;

        public bool isComputer;

        public Player(String name, bool isComputer)
        {
            this.name = name;
            this.isComputer = isComputer;
        }


        public char getNextMove()
        {
            if (isComputer)
                return getNextMoveComputer();
            else
                return getNextMovePlayer();
        }

        private char getNextMovePlayer()
        {
            Console.WriteLine("Move for " + name + ":"); //display prompt
            ConsoleKeyInfo input = Console.ReadKey(true); //get data 
            char move = input.KeyChar; //convert to char

            if (move == Game.ROCK || move == Game.PAPER || move == Game.SCISSORS)
                return move;
            else
            {
                Console.Write("Invalid answer. r for rock, p for paper, or s for scissors.");
                Console.WriteLine();
                return getNextMovePlayer();
            }

        }

        private char getNextMoveComputer()
        {
            int i = new Random().Next(0, 3);

            if (i == 0)
                return Game.ROCK;
            else if (i == 1)
                return Game.PAPER;
            else
                return Game.SCISSORS;
        }

    }
}
