using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken1 = 29;
            int chicken2 = 20;
            int chicken3 = 10;
            int chicken4 = 38;
            int total = chicken1 + chicken2 + chicken3 + chicken4;
            int dozen = total / 12;
            int leftover = total - dozen * 12;
            Console.WriteLine("My chickens produced {0} dozen and {1} eggs.", dozen, leftover);
        }
    }
}
