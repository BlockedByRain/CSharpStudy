using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7] { 4, 35, 8, 8, 14, 94, 37 };
            SelectSort(arr);
            PrintArray(arr);
            bool i=IsRepeating(arr);
            Console.WriteLine(i);

        }

        private static void PrintStar()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int c = 0; c < i + 1; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        private static void Printjing()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int c = 0; c < i; c++)
                {
                    Console.Write(" ");
                }
                for (int c = 0; c < 4 - i; c++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        private static void BubbleSort(int[] array)//冒泡
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }


        }
        private static void SelectSort(int[] array)//选择
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[minIndex] > array[j])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }


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

        private static bool IsRepeating(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j= i+1;j<array.Length;j++)
                {
                    if (array[i]==array[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
