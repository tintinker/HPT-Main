using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Game
    {
        public static readonly char ROCK = 'r';
        public static readonly char PAPER = 'p';
        public static readonly char SCISSORS = 's';

        public static readonly bool TWOPLAYERS = false;
        public static readonly bool COMPUTER = true;

        bool mode;
        Player one;
        Player two;

        public Game(bool mode)
        {
            if(mode == COMPUTER)
            {
                one = new Player("Player 1", false);
                two = new Player("Computer", true);
            }
            else
            {
                one = new Player("Player 1", false);
                two = new Player("Player 2", false);
            }
        }

        public String convertToSomethingReadable(char c)
        {
            if (c == Game.ROCK)
                return "ROCK";
            else if (c == Game.PAPER)
                return "PAPER";
            else
                return "SCISSORS";
        }

        public Player getWinner()
        {
            char o = one.getNextMove();
            char t = two.getNextMove();

            Console.WriteLine(one.name + ": " + convertToSomethingReadable(o)); //print what players said
            Console.WriteLine(two.name + ": " + convertToSomethingReadable(t));

            if (o == t) //tie
                return null;


            if (o == Game.ROCK && t == Game.SCISSORS) //all the ways player one could win
                return one;
            if (o == Game.SCISSORS && t == Game.PAPER) 
                return one;
            if (o == Game.PAPER && t == Game.ROCK)
                return one;
                            
            return two; //if player one hasn't one yet, player two did

        }

        public void go()
        {
            while(true)
            {
                Player p = getWinner();
                if (p == null)
                {
                    //do nothing
                }
                else if (p.Equals(one))
                {
                    one.wins++;
                    two.loses++;
                }
                else if(p.Equals(two))
                {
                    one.loses++;
                    two.wins++;
                }
      
                Console.WriteLine(one.name + " wins: " + one.wins + ", losses: " + one.loses);
                Console.WriteLine(two.name + " wins: " + two.wins + ", losses: " + two.loses);
                Console.WriteLine();

                if (one.loses > 2 * two.loses)
                    Console.WriteLine(one.name + " is getting shreked");

            }
        }



    }
}
