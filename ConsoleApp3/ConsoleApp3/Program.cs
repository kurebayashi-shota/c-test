using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            question1();
            question2();
            question3();
            question4();
            question5();
        }
        static void question1()
        {
            Console.WriteLine("2.4.1.問題3-1のコンソール出力");
            try
            {
                Console.WriteLine("数字1を入力してください");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("数字2を入力してください");
                int y = int.Parse(Console.ReadLine());
                if(x>y)Console.WriteLine("xはyより大きい");
            }
            catch
            {
                Console.WriteLine("数字を入力しなさい");
            }
            Console.WriteLine("");
        }
        static void question2()
        {
            Console.WriteLine("2.4.2.問題3-2のコンソール出力");
            try
            {
                Console.WriteLine("数字1を入力してください");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("数字2を入力してください");
                int y = int.Parse(Console.ReadLine());
                if (x == y) {Console.WriteLine("xとyは等しい"); }
                else if(y > x) { Console.WriteLine("xはyより小さい"); }
                else { Console.WriteLine("xはyより大きい"); }
            }
            catch
            {
                Console.WriteLine("数字を入力しなさい");
            }
            Console.WriteLine("");
        }
        static void question3()
        {
            Console.WriteLine("2.4.3.問題3-3のコンソール出力");
            try
            {
                Console.WriteLine("正数字を入力してください");
                int x = int.Parse(Console.ReadLine());
                if ((x%2)==0) { Console.WriteLine("偶数です。"); }
                else { Console.WriteLine("奇数です。"); }
            }
            catch
            {
                Console.WriteLine("正数字を入力しなさい");
            }
            Console.WriteLine("");
        }
        static void question4()
        {
            Console.WriteLine("2.4.4.問題3-4-ケース1のコンソール出力");
            try
            {
                Console.WriteLine("点数を入力してください");
                int x = int.Parse(Console.ReadLine());
                if (x >= 60) { Console.WriteLine("合格"); }
                else { Console.WriteLine("不合格"); }
            }
            catch
            {
                Console.WriteLine("数字を入力しなさい");
            }
            Console.WriteLine("");
            Console.WriteLine("2.4.4.問題3-4-ケース2のコンソール出力");
            try
            {
                Console.WriteLine("点数を入力してください");
                int x = int.Parse(Console.ReadLine());
                if (x >= 80) { Console.WriteLine("たいへんよくできました。"); }
                else if (x > 60) { Console.WriteLine("よくできました。"); }
                else { Console.WriteLine("ざんねんでした。"); }
            }
            catch
            {
                Console.WriteLine("数字を入力しなさい");
            }
            Console.WriteLine("2.4.4.問題3-4-ケース3のコンソール出力");
            try
            {
                Console.WriteLine("点数を入力してください");
                int x = int.Parse(Console.ReadLine());
                if (x >= 80) { Console.WriteLine("優"); }
                else if (x >= 70) { Console.WriteLine("良"); }
                else if (x >= 60) { Console.WriteLine("可"); }
                else { Console.WriteLine("不可"); }
            }
            catch
            {
                Console.WriteLine("数字を入力しなさい");
            }
            Console.WriteLine("");
        }
        static void question5()
        {
            Console.WriteLine("2.4.5.問題3-5のコンソール出力");
            Console.WriteLine("数字Xを入力してください");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("数字2を入力してください");
            int y = int.Parse(Console.ReadLine());
            if ( x == y )
                Console.WriteLine("xはyより小さく、かつ、xとyは共に偶数である。");

            if (x == y)
                Console.WriteLine("xとyは等しく、かつ、負の数である。");

            if ( x == y )
                Console.WriteLine("xはyより小さい、または、xは偶数である。");

            if ( x == y )
                Console.WriteLine("xは10以下または100以上で、かつ、yは10以上かつ100以下である。");

            if ( x == y )
                Console.WriteLine("xもyも負の数である、ではない。");
            Console.WriteLine("");
        }
    }
}