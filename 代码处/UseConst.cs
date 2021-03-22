//结构类型的使用方法
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    
    class UseConst
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;//java中用final.C中用#define,
            //使用 const 关键字来声明某个常量字段或常量局部变量,这个常量不可被改变
            double r = 3;//变量
            double area = PI * r * r;
            Console.WriteLine("园的面积是：{0}", area);
            Console.WriteLine("园的面积是：" + area);
            Console.ReadLine();
        }
    }
}
