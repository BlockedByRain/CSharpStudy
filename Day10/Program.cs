using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class Program
    {
        static void Main1(string[] args)
        {
            int a = 1;
            int b = 2;
            Swap(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Swop(a, b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            #region
            //int a = 10;
            //int b = 15;
            //int c;
            //int d;
            //CalculateRect(a, b, out c, out d);
            //Console.WriteLine(c);
            //Console.WriteLine();
            //int[] myArray = new int[500];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = i;
            //}
            //foreach (var item in myArray)
            //{
            //    Console.Write(item + " ");
            //}
            //del(myArray, 200);
            //Console.WriteLine();
            //foreach (var item in myArray)
            //{
            //    Console.Write(item + " ");
            //}
            //int[] newArray =new int[499];
            //Console.WriteLine();
            //myArray.CopyTo(newArray, 0);
            //foreach (var item in newArray)
            //{
            //    Console.Write(item + " ");

            //}
            #endregion
            int x = Console.Read();
            int y = Console.Read();
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        private static void CalculateRect(int length,int width,out int area,out int perimeter)
        {
            area = length * width;
            perimeter = 2 * (length + width);
        }
        private static void Swap(ref int one,ref int two)
        {
            int temp = one;
            one = two;
            two = temp;
        }
        private static void Swop( int one,  int two)
        {
            int temp = one;
            one = two;
            two = temp;
        }

        private static void del(int[]a,int index)
        {

            for (int i = index; i < a.Length-1; i++)
            {
                a[i] = a[i + 1];
            }
            a[a.Length-1] = 0;
        }

        static void duqu(string[] args)
        {
            Console.WriteLine("输入多个值，以空格分隔");
            string value = Console.ReadLine();
            string[] vals = value.Split(' ');
            Console.WriteLine("分开展示各值");
            for (int i = 0; i < vals.Length; i++)
            {
                Console.WriteLine(string.Format("{0}、{1}", i + 1, vals[i]));
            }
        }
    }
}
