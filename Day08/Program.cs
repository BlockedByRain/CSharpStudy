using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    class Program
    {
        static void test(string[] args)
        {
            //创建5 * 3的数组
            //int[,] arr = new int[5, 3];
            //array.Length==15
            int[,] arr = StudentInfo();
            Console.WriteLine("学生成绩如下：");
            Print2dArray(arr);
        }
        private static void Print2dArray(int[,]array)
        {
            //array.GetLength(0) 行数 5
            //array.GetLength(0) 列数 3
            for (int r = 0; r < array.GetLength(0); r++)
            {
                for (int c = 0; c < array.GetLength(1); c++)
                {
                    Console.Write(array[r,c]+"\t");
                }
                Console.WriteLine();
            }
        }

        private static int[,] StudentInfo()
        {
            Console.WriteLine("请输入学生总数：");
            int NumStudent = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入科目总数：");
            int NumSubject = int.Parse(Console.ReadLine());
            int[,] arr = new int[NumStudent , NumSubject];
            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    Console.WriteLine("请输入第{0}个学生的第{1}门成绩：",r+1,c+1);
                    arr[r, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("输入完毕！");
            return arr;
        }
    }
}
