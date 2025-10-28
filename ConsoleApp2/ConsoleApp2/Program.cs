using System;

namespace ConsoleApp1
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
            Console.WriteLine("2.1.1.問題1-1のコンソール出力");
            Console.WriteLine("Hello World");
            Console.WriteLine("");
        }
        static void question2()
        {
            Console.WriteLine("2.1.2.問題1-2のコンソール出力");
            int x = 11;
            Console.WriteLine(x);
            Console.WriteLine("");
        }
        static void question3()
        {
            Console.WriteLine("2.1.3.問題1-3のコンソール出力");
            int x = 13 + 17;
            Console.WriteLine(x);
            Console.WriteLine("");
        }
        static void question4()
        {
            Console.WriteLine("2.1.4.問題1-4のコンソール出力");
            Console.WriteLine(13 * 17);
            Console.WriteLine("");
        }
    }
}