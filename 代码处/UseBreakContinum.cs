//break：continue：语句运用。
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    
    class UseBreakContinum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("进行break语句实验");
            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
                if (i < 8)
                    break;//break是结束整个循环。
                Console.WriteLine("继续");
            }
            Console.WriteLine("进行continum语句实验");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
                if (i < 8)
                    continue;//continum是结束本次循环。
                Console.WriteLine("继续");
            }
            Console.ReadLine();
        }
    }
}
