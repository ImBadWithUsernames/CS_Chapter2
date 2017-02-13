using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 290;
            int hours = 290 / 60;
            int minutes = 290 - hours * 60;
            Console.WriteLine("I worked {0} hours and {1} minutes.", hours, minutes);
        }
    }
}
