using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("金额:{0:c}", 10);//货币
            Console.WriteLine("{0}", 5);
            Console.WriteLine("{0:d}", 5);
            Console.WriteLine("{0:d2}", 5);
            Console.WriteLine("{0:p}", 5);
            Console.WriteLine("{0:p1}", 5);
            Console.WriteLine("{0:p2}", 5);

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //int n1 = 5, n2 = 2;
            //int r2 = n1 % n2;
            //Console.WriteLine(r2);
            Console.WriteLine("请输入四位整数");
            string strNumber = Console.ReadLine();
            int number = Convert.ToInt32(strNumber);
            int sum=0;
            for(int i=0;i<4 ;i++)
            {
                sum += number % 10;
                number = number / 10;
            }
            Console.WriteLine(sum);
          

        }
    }
}
    