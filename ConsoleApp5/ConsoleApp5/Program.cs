using System;
using System.Collections.Generic;

namespace ConsoleApp5
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
            Console.WriteLine("2.5.1.問題5-1のコンソール出力");
            int[] array = new int[10];
            try
            {
                Console.WriteLine("数値を入力してください");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i + 1 + "回目の入力");
                    array[i] = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("数値を入力しなさい");
            }
            foreach (int item in array) { Console.Write(item *2); };
            Console.WriteLine("");
        }
        static void question2()
        {
            Console.WriteLine("2.5.2.問題5-2のコンソール出力");
            int[] array = new int[10];
            var evens = new List<int>();
            var odds = new List<int>();
            int i = 0;
            try
            {
                Console.WriteLine("数値を入力してください");
                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine(i + 1 + "回目の入力");
                    array[i] = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("数値を入力しなさい");
            }
            for (i = 0; i < 10; i++) {
                if (array[i] %2 == 0 ) { evens.Add(array[i]); }
                else { odds.Add(array[i]); }
            }

            Console.Write("偶数:");
            foreach(int even in evens)
            {
                Console.Write("{0}",even);
            }
            Console.WriteLine();
            Console.Write("奇数:");
            foreach (int odd in odds)
            {
                Console.Write("{0}", odd);
            }
            
            Console.WriteLine("");
        }
        static void question3()
        {
        Console.WriteLine("2.5.3.問題5-3のコンソール出力");
            int[,] kuku = new int[10, 10];
            // 配列 kuku に値を代入する
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++){
                kuku[i,j] = i*j;
                Console.Write($":{i}×{j}={kuku[i, j]} ");
                }
            Console.WriteLine();
            }
            Console.WriteLine("");
        }
        static void question4()
        {
            Console.WriteLine("2.5.4.問題5-4のコンソール出力");
            int[] array = new int[10];
            try
            {
                Console.WriteLine("整数を入力してください");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i + 1 + "回目の入力");
                    array[i] = int.Parse(Console.ReadLine());
                }
                Array.Sort(array);
            }
            catch
            {
                Console.WriteLine("整数を入力しなさい");
            }
            Console.WriteLine("[{0}]", string.Join(", ", array));
            ;
            Console.WriteLine("");
        }
    }
}