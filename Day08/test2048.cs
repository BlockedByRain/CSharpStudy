using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    class test2048
    {
        //    /* 分析
        //    移动
        //    *获取行或列数据，形成一维数组
        //    *去零
        //    *合并数据 相邻相同则合并
        //    *去零
        //    *将一维数组还原至原数组
        //     */
        //    static void Main(string[] args)
        //    {
        //        Console.Title = "2048";

        //        int[,] map = new int[4, 4]
        //        {
        //            {2,2,4,8},
        //            {2,4,4,4},
        //            {0,8,4,0},
        //            {2,4,0,4}
        //        };
        //        Print2dArray(map);
        //        Console.WriteLine("下移");
        //        //MoveDown(map);
        //        Move(map, MoveDirection.Dowm);
        //        Print2dArray(map);
        //        Console.WriteLine("左移");
        //        //MoveLeft(map);
        //        Move(map, MoveDirection.Left);
        //        Print2dArray(map);
        //        Console.WriteLine("右移");
        //        //MoveRight(map);
        //        Move(map, MoveDirection.Right);
        //        Print2dArray(map);
        //        Console.WriteLine("上移");
        //        //MoveUp(map);
        //        Move(map, MoveDirection.Up);
        //        Print2dArray(map);
        //    }

        //    private static void RemoveZero(int[] array)//去零
        //    {
        //        int[] newArray = new int[array.Length];
        //        int index = 0;
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            if (array[i] != 0)
        //            {
        //                newArray[index++] = array[i];
        //            }
        //        }
        //        newArray.CopyTo(array,0);
        //    }

        //    private static void Merge(int[] array)//合并
        //    {
        //        RemoveZero(array);
        //        for (int i = 0; i < array.Length - 1; i++)
        //        {
        //            if (array[i] != 0 && array[i] == array[i + 1])
        //            {
        //                array[i] += array[i + 1];
        //                array[i + 1] = 0;
        //            }
        //        }
        //        RemoveZero(array);
        //    }

        //    private static void MoveUp(int[,] map)//上
        //    {
        //        int[] mergeArray = new int[map.GetLength(0)];
        //        //建立存储数组
        //        for (int c = 0; c < map.GetLength(1); c++)
        //        {
        //            for (int r = 0; r < map.GetLength(0); r++)//获取
        //            {
        //                mergeArray[r] = map[r, c];
        //            }
        //            Merge(mergeArray);
        //            //合并
        //            for (int r = 0; r < map.GetLength(0); r++)//返回
        //            {
        //                map[r, c] = mergeArray[r];
        //            }
        //        }
        //    }

        //    private static void MoveDown(int[,] map)//下
        //    {
        //        int[] mergeArray = new int[map.GetLength(0)];
        //        //建立存储数组
        //        for (int c = 0; c < map.GetLength(1); c++)
        //        {
        //            for (int r = map.GetLength(0) - 1; r >= 0; r--)//获取
        //            {
        //                mergeArray[3-r] = map[r, c];
        //            }
        //            Merge(mergeArray);
        //            //合并
        //            for (int r = map.GetLength(0) - 1; r >= 0; r--)//返回
        //            {
        //                map[r, c] = mergeArray[3-r];
        //            }
        //        }
        //    }
        //    private static void MoveLeft(int[,] map)//左
        //    {
        //        int[] mergeArray = new int[map.GetLength(1)];
        //        //00 01 02 03
        //        //10 11 12 13
        //        //20 21 22 23
        //        //30 31 32 33
        //        //建立存储数组
        //        for (int c = 0; c < map.GetLength(0); c++)
        //        {
        //            for (int r = 0; r < map.GetLength(1); r++)//获取
        //            {
        //                mergeArray[r] = map[c, r];
        //            }
        //            Merge(mergeArray);
        //            //合并
        //            for (int r = 0; r < map.GetLength(1); r++)//返回
        //            {
        //                map[c, r] = mergeArray[r];
        //            }
        //        }
        //    }
        //    private static void MoveRight(int[,] map)//右
        //    {
        //        int[] mergeArray = new int[map.GetLength(1)];
        //        //建立存储数组
        //        for (int c = 0; c < map.GetLength(0); c++)
        //        {
        //            for (int r = map.GetLength(1) - 1; r >= 0; r--)//获取
        //            {
        //                mergeArray[3 - r] = map[c, r];
        //            }
        //            Merge(mergeArray);
        //            //合并
        //            for (int r = map.GetLength(1) - 1; r >= 0; r--)//返回
        //            {
        //                map[c, r] = mergeArray[3 - r];
        //            }
        //        }
        //    }
        //    private static void Print2dArray(int[,] array)
        //    {
        //        for (int r = 0; r < array.GetLength(0); r++)
        //        {
        //            for (int c = 0; c < array.GetLength(1); c++)
        //            {
        //                Console.Write(array[r, c] + "\t");
        //            }
        //            Console.WriteLine();
        //        }
        //        Console.WriteLine();

        //    }
        //    private static void Move(int[,] map,MoveDirection direction)
        //    {
        //        switch(direction)
        //        {
        //            case MoveDirection.Up:
        //                MoveUp(map);
        //                break;
        //            case MoveDirection.Dowm:
        //                MoveDown(map);
        //                break;
        //            case MoveDirection.Left:
        //                MoveLeft(map);
        //                break;
        //            case MoveDirection.Right:
        //                MoveRight(map);
        //                break;
        //        }
        //    }
        //}
    }
}
