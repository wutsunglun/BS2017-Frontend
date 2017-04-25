using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax
{
    class Program
    {
        static void Main(string[] args)
        {
            double taxrate;
            string taxpay;
            var t = 5 / 100;

            Console.WriteLine("請輸入年收入");
            string taxstring = Console.ReadLine();
            var taxdouble = double.Parse(taxstring);

            Console.WriteLine("應繳納稅率為");
            if (taxdouble == 0)
            {
                taxrate = 0;
                Console.WriteLine((taxrate * 100).ToString() + "%");
            }
            else if (taxdouble > 0 && taxdouble < 540000)
            {
                taxrate = 0.05;
                Console.WriteLine((taxrate * 100).ToString() + "%");
            }
            else if (taxdouble > 540001 && taxdouble < 1210000)
            {
                taxrate = 0.12;
                Console.WriteLine((taxrate * 100).ToString() + "%");
            }
            else if (taxdouble > 1210001 && taxdouble < 2420000)
            {
                taxrate = 0.2;
                Console.WriteLine((taxrate * 100).ToString() + "%");
            }
            else if (taxdouble > 24200001 && taxdouble < 4530000)
            {
                taxrate = 0.3;
                Console.WriteLine((taxrate * 100).ToString() + "%");
            }
            else if (taxdouble > 4530001 && taxdouble < 10310000)
            {
                taxrate = 0.4;
                Console.WriteLine((taxrate * 100).ToString() + "%");
            }
            else
            {
                taxrate = 0.5;
                Console.WriteLine((taxrate * 100).ToString() + "%");
            }

            Console.WriteLine("應繳納稅額為");
            taxpay = Math.Ceiling(taxdouble * taxrate).ToString();

            Console.WriteLine(taxpay);
            Console.ReadLine();
        }
    }
}