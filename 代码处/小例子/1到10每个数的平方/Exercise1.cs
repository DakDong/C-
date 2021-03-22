//1到10每个数的平方
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    
    class Exercise1
    {
        static void Main(string[] args)
        {
            int s;
            for (int i = 1; i <= 10; i++)//for语句的三个表达式均可省略，但是中间的两个分号不可省略。
            //第一个表达式可以放到for上面，第三个表达式可以放到for语句里面
            //第二个表达式省略，则循环进入无限循环，可结合使用if break语句退出循环。
            {
                s = i * i;
                //Console.WriteLine(i + "的平方是" + s);
                Console.Write("{0}\t",s);// \t是转移字符，右移八个字符。
            }
            Console.ReadLine();
        }
    }
}
