using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 数组工具测试
            //int[] arr1 = new int[] { 1, 4, 5, 6, 8, 7, 4, 1, };
            //int[] arr2 = new int[8] { 1, 4, 5, 6, 8, 7, 4, 1, };
            //int index =Array.IndexOf(arr1, 6);
            //Console.WriteLine(index);
            //PrintArray(arr2);
            //Array.Clear(arr2, 0, 8);
            //PrintArray(arr2);
            //Array.Copy(arr1, arr2, 8);
            //PrintArray(arr2);
            //Array.Sort(arr2);
            //PrintArray(arr2);
            //Array.Reverse(arr2);
            //PrintArray(arr2);
            #endregion
            #region 彩票
            //BuyLotteryTickets();
            //int[] LT = new int[7];
            //LT = GeneratingLotteryTickets();
            //Console.WriteLine("开奖结果为");
            //PrintLT(LT);
            #endregion
            int[] LT = new int[7];
            LT = BuyLotteryTickets();
            Test(LT);
        }

        private static void PrintArray(Array array)
        {
            foreach (int item in array)
            {
                Console.Write(item);
                Console.Write('\t');
            }
            Console.WriteLine();
        }
        private static void PrintLT(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write('\t');
            }
            Console.WriteLine();
        }
        private static bool isExistInArray(int num, Array array)
        {
            bool result = Array.IndexOf(array, num) >= 0;
            return result;
        }

        private static int[] GeneratingLotteryTickets()
        {
            int[] arr = new int[7];
            for (int i = 0; i < 6; i++)
            {
                int num = random.Next(1, 34);
                if (!isExistInArray(num, arr))
                {
                    arr[i] = num;
                }
            }
            int bule = random.Next(1, 17);
            arr[6] = bule;
            Array.Sort(arr, 0, 6);
            return arr;
        }

        public static int[] BuyLotteryTickets()
        {
            int[] arr = new int[7];
            for (int i = 1; i < 7;)
            {
                Console.WriteLine("请输入第{0}个红球的数字", i);
                int num = int.Parse(Console.ReadLine());
                if (num > 0 && num < 34 && isExistInArray(num, arr) != true)
                {
                    arr[i - 1] = num;
                    i++;
                }
                else
                    Console.WriteLine("输入有误！");
            }
            Console.WriteLine("请输入蓝球的数字");
            arr[6] = int.Parse(Console.ReadLine());
            Array.Sort(arr, 0, 6);
            Console.WriteLine("彩票号码为");
            PrintLT(arr);
            return arr;
        }

        private static Random random = new Random();
        private static bool LTcmp(int[] arr1, int[] arr2)
        {
            int i;
            for (i = 0; i < 7; i++)
                if (arr1[i] != arr2[i])
                {
                    return false;//出现不相等元素，返回false.
                }
            return true;//完全相等，返回true。
        }
        private static void Test(int[] LT)
        {
            int j;
            int[] num = new int[10];
            int[] test = new int[7];
            test = GeneratingLotteryTickets();
            for (int i = 0; i < 10; i++)
            {
                for (j = 0; !LTcmp(LT, test); j++)
                {
                    Array.Clear(test, 0, 7);
                    test = GeneratingLotteryTickets();
                }
                Console.WriteLine("第{0}次随机到号码全中的次数为" + j, i + 1);
                num[i] = j;
                Array.Clear(test, 0, 7);
            }
            PrintArray(num);
            float aver = Aver(num, 10);
            Console.WriteLine("10次试验平均值为" + aver);


        }
        private static float Aver(int[] a, int l)
        //计算整型数组a，前l个元素的平均值。
        {
            float r = 0;
            int i;
            for (i = 0; i < l; i++)
                r += a[i];//累加。
            r /= l;//平均值
            return r;//返回结果。
        }

        private static int TicketEquals(int[] myTicket, int[] RandomTicket)
        {
            int redCount = 0;
            int blueCount = myTicket[6] == RandomTicket[6] ? 1 : 0;
            for (int i = 0; i < 6; i++)
            {
                if (Array.IndexOf(RandomTicket, myTicket[0], 0, 6) >= 0)
                {
                    redCount++;
                }
            }
            int level=0;
            if (blueCount + redCount == 7)
                level = 1;
            else if (redCount == 6)
                level = 2;
            else if (blueCount + redCount == 6)
                level = 3;
            else if (blueCount + redCount == 5)
                level = 4;
            else if (blueCount + redCount == 4)
                level = 5;
            else if (blueCount == 1)
                level = 6;
            return level;
        }

    }
}
