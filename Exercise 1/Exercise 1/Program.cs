using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double > fruit = new Dictionary<string, double>()
            {
                {"Apple", 3.60},
                {"Banana", 4.80},
                {"Pear", 4.80},
                {"Plum", 6.90},
                {"Mango", 9.34},

            };

            Console.WriteLine(fruit["Apple"]);
            Console.WriteLine(fruit["Banana"]);
            Console.WriteLine(fruit["Pear"]);
            Console.WriteLine(fruit["Plum"]);
            Console.WriteLine(fruit["Mango"]);
        }
    }
}
