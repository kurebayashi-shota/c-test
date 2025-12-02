using System;
namespace Calculator;

class Program
{
    //ループを実装
    //前回の答えを引き継ぐ
    static void Main()
    {
        int num1 = 0;
        int num2 = 0;
        int answer = 0;
        string calculation;
        bool error = false;
        Console.WriteLine("8.1.問題1(電卓アプリ)");

        try
        {
            Console.WriteLine("数字1を入力して下さい");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("演算子を入力して下さい");
            Console.WriteLine("例_足し算:+,引き算:-,掛け算:*,割り算:/");
            calculation = Console.ReadLine();

            try
            {
                Console.WriteLine("数字2を入力して下さい");
                num2 = int.Parse(Console.ReadLine());

                switch (calculation)
                {
                    case "+": answer = num1 + num2; break;
                    case "-": answer = num1 - num2; break;
                    case "*": answer = num1 * num2; break;
                    case "/": answer = num1 / num2; break;
                    default:
                        Console.WriteLine("演算子が +, -, *, / 以外です。");
                        error = true; break;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0除算を行いました。");
                error = true;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("数字以外を入力しました。");
            error = true;
        }

        if (error)
        {
            Console.WriteLine("上記の理由で入力が不正です。");
        }
        else
        {
            Console.WriteLine($"答えは{answer}です。");
        }
    }
}