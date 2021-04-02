using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
    //打印年历
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入所要查询的年份：");
            int year = int.Parse(Console.ReadLine());
            PrintYearCalendar(year);
            //Console.WriteLine("请输入所要查询的分钟数：");
            //int minute = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入所要查询的小时数：");
            //int hour = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入所要查询的天数：");
            //int day = int.Parse(Console.ReadLine());
            //int second = GetSecond(minute, hour, day);
            //Console.WriteLine(second);
            Console.ReadKey();
        }

        private static int GetDaysByMonth(int year ,int month)
        {
            if (month < 1 || month > 12)
            {
                return 0;
            }            
                switch (month)
                {
                    case 2:
                        return IsLeapYear(year) ? 29 : 28;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        return 30;
                    default:
                        return 31;
                }
               
           
        }


        private static bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                return true;
            else
                return false;
        }

        private  static  void PrintMonthCalendar(int year,int month)
        {
            Console.WriteLine("{0}年{1}月", year, month);
            Console.WriteLine("日\t一\t二\t三\t四\t五\t六");
            int week = GetWeekByDay(year, month, 1);
            for(int i=0;i<week;i++)
            {
                Console.Write("\t");
            }
            int days = GetDaysByMonth(year, month);
            for(int i=1;i<=days;i++)
            {
                Console.Write(i + "\t");
               if( GetWeekByDay(year, month,i)==6)
                {
                    Console.WriteLine();
                }
            }

        }

        /// <summary>
        /// 根据年月日，计算星期数的方法
        /// </summary>
        /// <param name="year">年份</param>
        /// <param name="month">月份</param>
        /// <param name="day">天数</param>
        /// <returns>星期数</returns>
        private static int GetWeekByDay(int year,int month,int day)
        {
            DateTime dt = new DateTime(year, month, day);
            return (int)dt.DayOfWeek;
        }

        private static void PrintYearCalendar(int year)
        {
            for (int i = 1; i <= 12; i++)
            {
                PrintMonthCalendar(year, i);
                Console.WriteLine();
            }          
        }

        private static int GetSecond(int minute)
        {
            return minute * 60;
        }
        private static int GetSecond(int minute,int hour)
        {          
            return  GetSecond(minute += 60 * hour);             
        }
        private static int GetSecond(int minute, int hour,int day)
        {
            
            return GetSecond(minute, hour += 24 * day);
        }

    }





}
