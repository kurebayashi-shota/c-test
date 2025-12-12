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
            question4();
            question5();
            question6();
            question7();
            question7();
        }
        static void CheckAge(int age)
        {
            int minimumRequiredAge = 0;
            int maximumRequiredAge = 120;
            if (age < minimumRequiredAge || age> maximumRequiredAge)
            { 
                throw new ArgumentOutOfRangeException(nameof(age), $"All guests must be at least {minimumRequiredAge} years old and no older than {maximumRequiredAge}.");
            }
            Console.WriteLine($"年齢は{age}歳です");
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
                Console.WriteLine(1 / 0);
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
            try
            {
                Console.WriteLine("年齢を入力して下さい");
                int age = int.Parse(Console.ReadLine());
                CheckAge(age);
            }
            catch
            {
                Console.WriteLine("入力が不正です。");
            }
            Console.WriteLine();
        }
        static void question5()
        {
            Console.WriteLine("4.5.1.問題5-1のコンソール出力");
            try
            {
                Console.WriteLine("分子を入力して下さい");
                int molecule = int.Parse(Console.ReadLine());
                Console.WriteLine("分母を入力して下さい");
                int denominator = int.Parse(Console.ReadLine());
                try
                {
                    int answer = molecule / denominator;
                }
                catch (DivideByZeroException) //DivideByZeroException例外をキャッチする
                {
                    Console.WriteLine("ゼロは入力できません");
                }
                Console.WriteLine("正常終了");
            }
            catch (FormatException) //FormatException例外をキャッチする
            {
                Console.WriteLine("数値を入力してください");
            }
            catch (Exception)
            {
                Console.WriteLine("予期しないエラーが発生しました");
            }
            Console.WriteLine();
        }
        static void question6()
        {
            Console.WriteLine("4.6.1.問題6-1のコンソール出力");
            int total = 0;
            for (int i = 1; i <= 10; i++)
            {
                total += i;
            }

            Console.WriteLine("合計は " + total);
            Console.WriteLine();
        }
        static void question7()
        {
            Console.WriteLine("4.7.1.問題7-1のコンソール出力");
            int answer = 0;
            try
            {
                int num2 = 0;
                Console.WriteLine("数値1を入力して下さい");
                int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("数値2を入力して下さい");
                    num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("演算子 (+, -, *, /)を入力して下さい");
                string calculation = Console.ReadLine();
                switch (calculation)
                {
                    case "+": answer = num1 + num2; break;
                    case "-": answer = num1 - num2; break;
                    case "*": answer = num1 * num2; break;
                    case "/":
                        try{answer = num1 / num2;}
                        catch (DivideByZeroException){Console.WriteLine("ゼロは入力できません");}break;
                    default: Console.WriteLine("想定外の演算子入力"); break; 
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("数値を入力してください");
            }
            catch (Exception)
            {
                Console.WriteLine("予期しないエラーが発生しました");
            }
            Console.WriteLine($"答えは{answer}です。");
            Console.WriteLine();
        }
    }
}
