using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> user = new Dictionary<int, string>()
            {
                {1, ""},
                {2, ""},
                {3, ""},
                {4, ""},
                {5, ""}
            };

            for (int i = 0; i < user.Count; i++)
            {   
                Console.WriteLine("Key : {0} Value: {1}",
                    user.Keys.ElementAt(i),
                    user[user.Keys.ElementAt(i)]);
            }
        }
    }
}
