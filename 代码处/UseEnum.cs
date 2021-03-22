//枚举类型的使用方法
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public enum Timefoday //枚举类型,Timefoday表示今天。
    {
        moning, afternoon, evening //用来表示早上，下午，傍晚类型
    }
    class UseEnum //类名
    {
        static void WriteGreeting(Timefoday timefoday) //Write Greeting是写问候语的意思
        {//前面有大写T的是枚举类型，后面小写t是它的对象
            switch (timefoday)//seitch输出对应的问候语
            {
                case Timefoday.moning:
                    Console.WriteLine("good moning！"); 
                    break;
                case Timefoday.afternoon:
                    Console.WriteLine("good afternoon！");
                    break;
                case Timefoday.evening:
                    Console.WriteLine("good evening");
                    break;
                default:
                    break;
            }

        }
        static void Main(string[] args)//主函数
        {
            WriteGreeting(Timefoday.afternoon);//调用WriteGreeting方法()包含枚举类型的自定义类型。
            WriteGreeting(Timefoday.moning);
            WriteGreeting(Timefoday.evening);
            Console.ReadLine();//从标准的输入流读取下一行字符
        }
    }
}
