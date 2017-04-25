using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buy_candy
{
    class Program
    {
        static void Main(string[] args)
        {
            //candy演算法
            int n = 3;
            int x = 11;
            int y = 0;
            int temp = 0;

            while (x > 0)
            {
                y++;
                x--;
                temp++;

                if (temp == n)
                {
                    x--;
                    temp = 1;
                }
            }
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
