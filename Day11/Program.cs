using System;

namespace Day11
{
    [Flags]
    enum PersonStyle
    {
        tall          = 1,
        rich          = 2,
        handsome      = 4,
        white         = 8,
        beauty        = 16
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrintPersonStyle(PersonStyle.rich | PersonStyle.tall);

            //数据类型转换
            PersonStyle style01 = (PersonStyle)2;

            int enumNumber = (int)(PersonStyle.beauty | PersonStyle.handsome);

            Console.WriteLine(enumNumber);
            PrintPersonStyle(style01);
            PersonStyle style02 = (PersonStyle)Enum.Parse(typeof(PersonStyle), "beauty");
            PrintPersonStyle(style02);
            string strEnum = PersonStyle.handsome.ToString();
            Console.WriteLine(strEnum);

        }

        private static void PrintPersonStyle(PersonStyle style)
        {
            //if (style==PersonStyle.tall)
            //    Console.WriteLine("大个子");
            //if (style == PersonStyle.rich)
            //    Console.WriteLine("土豪");
            //if (style == PersonStyle.handsome)
            //    Console.WriteLine("英俊");
            //if (style == PersonStyle.white)
            //    Console.WriteLine("洁白");
            //if (style == PersonStyle.beauty)
            //    Console.WriteLine("漂亮");


            if ((style & PersonStyle.tall) == PersonStyle.tall)
                Console.WriteLine("大个子");
            if ((style & PersonStyle.rich) == PersonStyle.rich)
                Console.WriteLine("土豪");
            if ((style & PersonStyle.handsome) == PersonStyle.handsome)
                Console.WriteLine("英俊");
            if ((style & PersonStyle.white) == PersonStyle.white)
                Console.WriteLine("洁白");
            if ((style & PersonStyle.beauty) != 0)
                Console.WriteLine("漂亮");
        }

        /*
         选择多个枚举值
         运算符 | 按位或：两个对应的二进制位中有一个为1 结果为1
         tall | rich ==》 0000000000 | 0000000001==》 0000000001
         条件：
         1.任意多个枚举值做 | 运算的结果 不能与其他枚举值相同（值以2的n次方递增）
         2.定义枚举时，使用 [Flags] 特性修饰

        判断标志枚举 是否包括指定枚举值
        运算符 & 按位与：两个对应的二进制位中都为1 结果为1
        0000000011 & 0000000001==》 0000000001
        */
    }
}
