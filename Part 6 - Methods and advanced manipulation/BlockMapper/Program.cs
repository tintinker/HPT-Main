using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockMapper
{
    class Program
    {
        static char[] blockNames = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
 

        static void Main(string[] args)
        {

            Console.Write("First Block Today: "); 
            int firstBlockToday = Int32.Parse(Console.ReadLine());
            Console.Write("Current Day of Week: ");
            int currentDayOfWeek = Int32.Parse(Console.ReadLine());
            Console.Write("Days Till: ");
            int daysBetween = Int32.Parse(Console.ReadLine());

            int firstBlockThatDay = mathMethod(firstBlockToday, currentDayOfWeek, daysBetween);

            Console.WriteLine(firstBlockThatDay);

            Console.WriteLine(blockNames[firstBlockThatDay]);

            firstBlockThatDay = loopMethod(firstBlockToday, currentDayOfWeek, daysBetween);

            Console.WriteLine(blockNames[firstBlockThatDay]);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();



        }

        static int loopMethod(int firstBlockToday, int currentDayOfWeek, int daysTill)
        {
            int totalBlocks = firstBlockToday;

            for(int i = 0; i < daysTill; i++ )
            {
                if ((currentDayOfWeek + i) % 7 == 0)
                    totalBlocks += 0;
                else if ((currentDayOfWeek + i) % 7 == 6)
                    totalBlocks += 0;
                else
                    totalBlocks += 4;
            }

            int blockThatDay = totalBlocks % 7;

            return blockThatDay;
        }

        static int mathMethod(int firstBlockToday, int currentDayOfWeek, int daysTill)
        {
           


            int weeksBetween = daysTill / 7;
            int daysLeftOver = daysTill % 7;
            int totalDays = 5 * weeksBetween + daysLeftOver;

            if (currentDayOfWeek + daysLeftOver == 0)
                totalDays -= 1;

            if (currentDayOfWeek + daysLeftOver >= 6) //changed to equality
                totalDays -= 2;


            int blocksBetween = 4 * totalDays;
            int totalBlocks = firstBlockToday + blocksBetween;
            int firstBlockThatDay = totalBlocks % 7; //changed to 7 from 4

            //     Console.WriteLine(firstBlockThatDay);

            return firstBlockThatDay;
        }
    }
}