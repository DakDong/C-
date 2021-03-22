//输入输出的方法及类型强制转换
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    
    class UseParse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入考试成绩：");
            double score = double.Parse(Console.ReadLine());//将字符串表示形式转换成等效双精度浮点数。Parse为转换
            if (score >= 90)
                Console.WriteLine("优秀");
            else if (score >= 80)
                Console.WriteLine("良好");
            else if (score >= 70)
                Console.WriteLine("中等");
            else if (score >= 60)
                Console.WriteLine("及格");
            else
                Console.WriteLine("不及格");
            Console.ReadLine();
        }
    }
}
