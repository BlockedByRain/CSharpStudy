using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            //float[] ScoreArray = CreateScoreArray();
            //float max = GetMax(ScoreArray);
            //Console.WriteLine("最高分为：" + max);

            int day;
            Console.WriteLine( day = GetTotalDay(2016, 9, 7));
        }

        static float[]CreateScoreArray()
        {
            Console.WriteLine("请输入学生个数：");
            int count = int.Parse(Console.ReadLine());
            float[]ScoreArray=new float [count];
            for (int i = 0; i < ScoreArray .Length ; )
            {
                Console.WriteLine("请输入第{0}个学生的成绩：", i + 1);
                float score = float.Parse(Console.ReadLine());
                if (score >= 0 && score <= 100)
                {
                    ScoreArray[i++] = score;
                }
                else
                    Console.WriteLine("成绩输入有误！请重新输入！");
            }
            return ScoreArray;
        }
       private static float GetMax(float[] array)
        {
            float max = array[0];
            for (int i = 1; i < array.Length ; i++)
            {
                if(max<array [i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        private static bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                return true;
            else
                return false;
        }

        private  static  int GetTotalDay(int year,int month,int day)
        {
            int days=0;
            int[] DayOfMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if(IsLeapYear (year))
            {
                DayOfMonth[1] = 29;
            }            
            for (int i = 0; i < month-1; i++)
            {
                days += DayOfMonth[i];
            }
            days += day;
            return days;
        }

    }
}
