using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 25;
            int width = 42;
            int areaY = length * width / 9;
            int cost = areaY * 18;
            Console.WriteLine("The cost of carpeting per square yard is $18, and the floor is about {0} square yards, so the price should be about {1}.", areaY, cost);
        }
    }
}
