using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一段字串");
            string s = Console.ReadLine();
            char[] caArray = s.ToCharArray();         
            Array.Reverse(caArray);//將char array中的元素位置反轉

            Console.WriteLine("反轉後字串結果為：");
            string rew = new string(caArray); //將反轉完的char array轉回字串
            Console.WriteLine(rew);
            Console.ReadLine();
        }
    }
}
