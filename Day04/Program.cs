using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入参数：");
            //int num = int.Parse(Console.ReadLine());
            //num=GetValue(num);
            //Console.WriteLine(num);


        }

        //编写一个函数，计算当参数为8时的结果为多少？——递归实现
        //1-2+3-4+5……
        private static int GetValue(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            if (num % 2 == 0)
            {
                return GetValue(num - 1) - num;
            }
            else
                return GetValue(num - 1) + num;           
        }
    }
}
