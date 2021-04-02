using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    class Program
    {
        static void arr2d()
        {
            //交错数组：每个元素都为一维数组，分布通常想象为“不规则的表格”
            //创建具有四个元素的交错数组
            int[][] array02;//null
            array02 = new int[4][];
            //创建一维数组 赋值给 交错数组的第一个元素
            array02[0] = new int[3];
            array02[1] = new int[5];
            array02[2] = new int[4];
            array02[3] = new int[1];
            array02[0][0] = 1;
            array02[1][2] = 2;
            array02[1][4] = 3;
            array02[2][1] = 4;
            array02[2][3] = 5;
            foreach (int[] array in array02)
            {
                foreach (int item in array)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }
            for (int r = 0; r < array02.Length; r++)
            {
                for (int c = 0; c < array02[r].Length; c++)
                {
                    Console.Write(array02[r][c] + "\t");

                }
                Console.WriteLine();

            }
        }
        static void Main()
        {
            #region parmas的使用
            //int result01=Add (new int[]{1,34,43,54,78 });
            //int result02 = Add( 1, 34, 43, 54, 78 );
            //int result03 = Add();
            //Console.WriteLine(result01);
            //Console.WriteLine(result02);
            //Console.WriteLine(result03);
            #endregion 
            /*值类型 int bool char
             *引用类型  string Array object
             * 1.因为方法执行在栈中，所以在方法中声明的变量都在栈中
             * 2.因为值类型直接存储数据，所以数据存储在栈中
             * 3.因为引用类型存储数据的引用，所以数据在堆中，栈中存储数据的引用
             */
            //a在栈中    1在栈中
            int a = 1;
            int b = a;
            a = 2;
            Console.WriteLine(b);//? 1
            //arr在栈中存储数据对象的引用（内存地址）    1在堆中
            int[] arr = new int[] { 1 };
            int[] arr2 = arr;
            /*arr[0] = 2;*/ //修改的是堆中的数据  2
            arr = new int[] { 2 }; //修改的是栈中存储的引用   1
            Console.WriteLine(arr2[0]);//? 

            string s1 = "男";
            string s2 = s1;
            s1 = "女";
            Console.WriteLine(s2);//? 女

            //o1在栈中  数据1 在堆中
            object o1 = 1;
            object o2 = o1;//o2得到的是 数据1的地址
            o1 = 2;//修改的是栈中o1的引用
            Console.WriteLine(o2);//?   1

            int a1 = 1;
            int[] arr1 = new int[] { 1 };
            Fun1(a1, arr1);//实参将 数据1 和 数组引用  赋值给形参
            Console.WriteLine(a1);//?    1
            Console.WriteLine(arr1[0]);//?   2
        }

        //整数相加的方法
        //当类型确定 个数不确定的情况
        //params 参数数组 
        //对于方法内部而言：就是个普通数组
        //对于方法外部（调用者）而言
        //1可以传递数组 2可以传递一组数据类型相同的变量集合
        //3可以不传递参数
        //作用：简化调用者调用方法的代码

        private static void Fun1(int a,int[]arr)
        {
            a = 2;
            arr[0] = 2;
        }
        private static int Add(params int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
}
