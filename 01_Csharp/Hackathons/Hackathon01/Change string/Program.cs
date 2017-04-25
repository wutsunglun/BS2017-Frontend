using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_string
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var s = i.ToString();
                s = s.Replace("3", "A").Replace("6", "B").Replace("9", "C").Replace("0", "D");
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
