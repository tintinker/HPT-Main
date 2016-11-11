using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double correctionsPercent = 1d / 3d;

            int percent = 87;

            double total = (double)(100-percent) * correctionsPercent + (double)percent;

            Console.WriteLine(total);

            Console.ReadKey();

        }
    }
}
