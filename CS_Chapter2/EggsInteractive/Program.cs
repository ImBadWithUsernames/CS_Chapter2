using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many eggs were laid by chicken 1? : ");
            int chicken1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many eggs were laid by chicken 2? : ");
            int chicken2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many eggs were laid by chicken 3? : ");
            int chicken3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many eggs were laid by chicken 4? : ");
            int chicken4 = Convert.ToInt32(Console.ReadLine());
            int total = chicken1 + chicken2 + chicken3 + chicken4;
            int dozen = total / 12;
            int leftover = total - dozen * 12;
            Console.WriteLine("Overall, the chickens laid {0} dozen and {1} eggs.", dozen, leftover);

        }
    }
}
