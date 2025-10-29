using System;

namespace ConsoleApp4
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
            question6();
        }
        static void question1()
        {
            Console.WriteLine("2.3.1.問題4-1のコンソール出力");
            for( int i=0; i<10; i++ ) { 
            Console.WriteLine("SPAM");
            }
            Console.WriteLine("");
        }
        static void question2()
        {
            Console.WriteLine("2.3.2.問題4-2のコンソール出力");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("3×"+i+"="+3*i);
            }
            Console.WriteLine("");
        }
        static void question3()
        {
            Console.WriteLine("2.3.3.問題4-3のコンソール出力");
            int total = 0;
            int i =0;
            try
            {
                Console.WriteLine("整数を入力してください");
                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine(i+1 + "回目の入力");
                    int input = int.Parse(Console.ReadLine());
                    total = total + input;
                }
            }
            catch
            {
                Console.WriteLine("整数を入力しなさい");
            }
            Console.WriteLine("入力値の平均は"+total/i + "です。");
            Console.WriteLine("");
        }
        static void question4()
        {
            Console.WriteLine("2.4.4.問題3-4-ケース1のコンソール出力");
            int giants = 0;
            int tigers = 0;
            try
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.Write(i + "回表、巨人の得点は？");
                    giants = giants + int.Parse(Console.ReadLine());
                    Console.Write(i + "回裏、阪神の得点は？");
                    tigers = tigers + int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("数字を入力しなさい");
            }
            Console.WriteLine("巨人：" + giants + "点, 阪神：" + tigers);
            if (giants == tigers)
            {
                Console.WriteLine("同点です。");
            }
            else if (giants < tigers)
            {
                Console.WriteLine("阪神の勝ち");
            }
            else
            {
                Console.WriteLine("巨人の勝ち");
            }
        }
        static void question5()
        {
            Console.WriteLine("2.3.5.問題4-5のコンソール出力");
            Console.WriteLine("1:ストライクまたは2:ボールを入力してください");
            int pitching;
            int strike = 0;
            int ball = 0;
            try
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(i + "ストライク=1 or ボール=2 ？");
                    pitching = int.Parse(Console.ReadLine());
                    switch (pitching)
                    {
                        case 1: strike = strike+1; break;
                        case 2: ball = ball+1; break;
                        default: Console.WriteLine("選択にありません"); break;
                    }
                    if (strike > 2 || ball > 3) break;
                }
            }
            catch
            {
                Console.WriteLine("数字を入力しなさい");
            }
            Console.WriteLine(ball + "ボール," + strike + "ストライク");
            Console.WriteLine("");
        }
        static void question6()
        {
            Console.WriteLine("2.3.6.問題4-6のコンソール出力");
            Console.WriteLine("1:ストライクまたは2:ボールを入力してください");
            int pitching;
            int strike = 0;
            int ball = 0;
            int foul = 0;
            try
            {
                for (int i = 1; true ; i++)
                {
                    Console.WriteLine(i + "ストライク=1 or ボール=2 or ファウル=3 ？");
                    pitching = int.Parse(Console.ReadLine());
                    switch (pitching)
                    {
                        case 1: strike = strike+1; break;
                        case 2: ball = ball+1; break;
                        case 3: if(strike<2) strike++; break;
                        default: Console.WriteLine("選択にありません"); break;
                    }
                    if (strike > 2 || ball > 3) break;
                }
            }
            catch
            {
                Console.WriteLine("数字を入力しなさい");
            }
            Console.WriteLine(ball + "ボール," + strike + "ストライク");
            Console.WriteLine("");
        }
    }
}