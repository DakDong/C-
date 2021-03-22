//foreach的使用方法
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    
    class UseForeach
    {
        static void Main(string[] args)
        {
            int evenNum = 0, oddNum = 0;//evenNum是偶数，oddNum是奇数。
            int[] arr = new int[] { 12, 3, 14, 2, 25, 35, 65, 34, 25, 66 };//定义一个数组
            foreach (int k in arr)// foreach用来问k是否在arr数组（集合也可）里面，
            {
                if (k % 2 == 0)
                {
                    evenNum++;//记录偶数个数
                }
                else
                {
                    oddNum++;//记录奇数个数
                }
            }
            Console.WriteLine("偶数的个数是{0}，奇数的个数是{1}",evenNum, oddNum);//输出偶数和奇数个数
            Console.ReadLine();
        }
    }
}
