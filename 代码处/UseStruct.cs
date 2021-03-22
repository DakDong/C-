//结构类型的使用方法
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    struct IPAdress//定义一个结构类型IPAress,IPAdress 意思为 ip地址
    {
        public byte b1, b2, b3, b4;//定义简单的字节型数据
    }
    class UseStruct
    {
        static void Main(string[] args)
        {
            IPAdress myip;//给结构类型取了个别名，方便书写。
            myip.b1 = 10;//给结构类型IPAdress中的b1赋值
            myip.b2 = 60;//给结构类型IPAdress中的b2赋值
            myip.b3 = 18;//给结构类型IPAdress中的b3赋值
            myip.b4 = 8;//给结构类型IPAdress中的b4赋值
            Console.WriteLine("{0}.{1}.{2}.{3}", myip.b1, myip.b2, myip.b3, myip.b4);//{0}这种为C#的占位符，与后面的myip.b1对应输出
            //+可以表示加号也可以表示连接符
            Console.WriteLine(myip.b1 + myip.b2 + myip.b3 + myip.b4);//第二种输出方式，字节类型相加输出相加后的字节
            Console.WriteLine(myip.b1 +"."+myip.b2 +"."+myip.b3 +"."+myip.b4);//第三种输出方式，+号连接中间加上字符可以直接输出。
            Console.ReadLine();
        }
    }
}
