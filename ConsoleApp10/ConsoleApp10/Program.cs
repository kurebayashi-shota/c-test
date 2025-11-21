using System;
using System.IO;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            question1();
            question2();
            question3();
        }
        public int CheckAge(int age)
        {
            return age;
        }
        static void question1()
        {
            Console.WriteLine("4.1.1.問題1-1のコンソール出力");
            Console.WriteLine("整数を入力してください");
            try
            {
                int num = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("整数を入力してください");
            }
            Console.WriteLine();
        }
        static void question2()
        {
            Console.WriteLine("4.2.1.問題2-1のコンソール出力");
            Console.WriteLine("ファイルを開きます。");
            try
            {
                FileStream fs = File.Open("path", FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("処理を終了します");
            }
            Console.WriteLine();
        }
        static void question3()
        {
            Console.WriteLine("4.3.1.問題3-1のコンソール出力");
            Console.WriteLine("0 除算を行います。");
            try
            {
                Console.WriteLine("1/0");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0 除算をしないでください");
            }
            Console.WriteLine("配列の範囲外アクセスを行います。");
            try
            {
                int[] nums = new int[1];
                nums[3] = 1;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("配列の大きさを確認して下さい。");
            }
            Console.WriteLine();
        }
        static void question4()
        {
            Console.WriteLine("4.4.1.問題4-1のコンソール出力");
            Console.WriteLine("0 除算を行います。");
            try
            {
                Console.WriteLine("1/0");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0 除算をしないでください");
            }
            Console.WriteLine("配列の範囲外アクセスを行います。");
            try
            {
                int[] nums = new int[1];
                nums[3] = 1;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("配列の大きさを確認して下さい。");
            }
            Console.WriteLine();
        }
    }
}
