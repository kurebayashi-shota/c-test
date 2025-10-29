using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            question1();
            question2();
            question3();
            question4();
        }
        static void question1()
        {
            Console.WriteLine("2.2.1.問題2-1のコンソール出力");
            Console.WriteLine("文字を入力してください");
            string s = Console.ReadLine();
            Console.WriteLine(s);
            Console.WriteLine("");
        }
        static void question2()
        {
            Console.WriteLine("2.2.2.問題2-2のコンソール出力");
            Console.WriteLine("数字を入力してください");
            try
            {
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(x);
            }
            catch
            {
                Console.WriteLine("数字を入力しなさい");
            }
            Console.WriteLine("");
        }
        static void question3()
        {
            Console.WriteLine("2.2.3.問題2-3のコンソール出力");
            Console.WriteLine("数字1を入力してください");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("数字2を入力してください");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("数字1と数字2の平均は" + (y + z) / 2 + "です。");
            Console.WriteLine("");
        }
        static void question4()
        {
            Console.WriteLine("2.2.4.問題2-4のコンソール出力");
            Console.WriteLine("あなたの年齢を入力してください");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("あなたが生まれてからおおよそ" + age * 365 + "経っています");
            Console.WriteLine("");
        }
    }
}