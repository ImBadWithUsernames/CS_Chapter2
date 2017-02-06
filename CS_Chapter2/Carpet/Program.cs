using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 15;
            int width = 25;
            int area = length * width;
            int cost = area * 2;
            Console.WriteLine("The cost of the carpet per square foot is {0}, and the floor is about {1} square feet.", $2, area);
        }
    }
}
