using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeJudger
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Justin";
            int age = 11;
            bool isOld;


            if (age < 10)
                isOld = false;
            else
                isOld = true;

            if (!isOld)
                Console.WriteLine("Do you want some candy " + name + "?");
            else
                Console.WriteLine("Get out of my van!!");

            Console.ReadKey();




        }
    }
}
