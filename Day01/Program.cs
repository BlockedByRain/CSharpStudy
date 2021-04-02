using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 成绩等级
            //int s = 896;
            //string g = "";
            //if (s >= 100)
            //{
            //    g = "";
            //}
            //else if (s >= 90)
            //{
            //    g = "A";
            //}
            //else if (s >= 80)
            //{
            //    g = "B";
            //}
            //else if (s >= 70)
            //{
            //    g = "C";
            //}
            //else if (s >= 60)
            //{
            //    g = "D";
            //}
            //else if (s >= 0)
            //{
            //    g = "F";
            //}
            //else
            //{
            //    g = "";
            //}
            //Console.WriteLine("Your garde is {0}", g == "" ? "(N/A)" : g);
            //Console.ReadLine();
            #endregion
            #region 三个数最大值
            //int a = 3;
            //int b = 5;
            //int c = 7;
            //int max = 5;
            //if (b > max)
            //{
            //    max = b;
            //}
            //if (c > max)
            //{
            //    max = c;
            //}
            //Console.WriteLine("max={0}",max);
            #endregion
            #region 攻击
            //string shp;
            //string satk;
            //Console.WriteLine("请设定敌人血量:");
            //shp = Console.ReadLine();
            //Console.WriteLine("请设定玩家攻击力:");
            //satk = Console.ReadLine();
            //int hp = int.Parse(shp);
            //int atk = int.Parse(satk);

            //Console.WriteLine("请按回车键进行一次攻击");
            //Console.ReadLine();
            //hp -= atk;
            //Console.WriteLine("玩家对敌人造成了{0}点伤害，敌人当前血量为:{1}", atk , hp);


            //Console.WriteLine("请按回车键进行一次攻击");
            //Console.ReadLine();
            //hp -= atk;
            //Console.WriteLine("玩家对敌人造成了{0}点伤害，敌人当前血量为:{1}", atk , hp);


            //Console.WriteLine("请按回车键进行一次攻击");
            //Console.ReadLine();
            //hp -= atk*2;
            //Console.WriteLine("玩家对敌人造成了{0}点伤害，敌人当前血量为:{1}", atk*2,hp);
            //Console.ReadLine();
            #endregion
            #region NPC对话
            //MainMenu:
            //Console.Clear();
            //Console.WriteLine("1.开始做题");
            //Console.WriteLine("2.打开商店");
            //Console.WriteLine("3.走错了");
            //string choice = Console.ReadLine();
            //Console.Clear();
            //if(choice =="1")
            //{
            //    Console.WriteLine("1+1=");
            //    Console.WriteLine("1.1+1=0");
            //    Console.WriteLine("2.1+1=1");
            //    Console.WriteLine("3.1+1=2");
            //    Console.WriteLine("4.1+1=3");
            //    choice = Console.ReadLine();
            //    if(choice =="3")
            //    {
            //        Console.WriteLine("运气不错！");
            //    }
            //    else if(choice =="1"
            //        ||choice == "2"
            //        ||choice == "4")
            //    {
            //        Console.WriteLine("九折水瓶？");

            //    }



            //}
            //else if(choice =="2")
            //{
            //    Console.WriteLine("1.红药");
            //    Console.WriteLine("2.蓝药");
            //    Console.WriteLine("3.黄药");
            //    choice = Console.ReadLine();
            //    if (choice == "1")
            //    {
            //        Console.WriteLine("HP+10!");
            //    }
            //    else if (choice == "2")                   
            //    {
            //        Console.WriteLine("MP+10!");
            //    }
            //    else if (choice == "3")
            //    {
            //        Console.WriteLine("没有这个药水");
            //    }

            //}
            //else if(choice=="3")
            //{
            //    goto End;
            //}
            //else
            //{
            //    Console.WriteLine("Input Error");
            //    Console.ReadLine();
            //    return;
            //}
            //Console.WriteLine("返回上一层");
            //Console.ReadLine();
            //goto MainMenu;
            #endregion
            string gunName;
            int magazineCapacity;
            int currentMagazineCapacity;
            Console.WriteLine("请输入枪的名称：\n");
            gunName = Console.ReadLine();
            Console.WriteLine("请输入弹匣容量：\n");
            magazineCapacity =Convert .ToInt32( Console.ReadLine());
            Console.WriteLine("请输入当前弹匣子弹数：\n");
            currentMagazineCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("枪的名称为：{0}，弹匣状况为：{2}/{1}", gunName, magazineCapacity, currentMagazineCapacity);
            Console.ReadLine();


        }
    }
}
