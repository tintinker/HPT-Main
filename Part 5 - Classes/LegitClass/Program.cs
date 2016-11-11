using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegitClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jim = new Person("Jim");

            jim.voteForLouden();
            jim.voteForLouden();

            jim.voteForLouden();


            String jimswords = jim.sayStuff();

            Console.WriteLine(jimswords);

            Console.ReadKey();
        }
    }
}
