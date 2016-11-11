using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegitClass
{
    class Person
    {
        public double legitness;
        public String name;

        public Person(String thename)
        {
            legitness = 1000;
            this.name = thename;
        }

        public String sayStuff()
        {
            if (legitness < 9000)
                return "Name's " + name + ". my legitness is " + legitness;
            else
                return "My legitness is over 9000!";
        }

        public void makeAmericaGreatAgain()
        {
            legitness /= 2;
        }

        public void voteForLouden()
        {
            legitness *= 4;
        }

    }
}
