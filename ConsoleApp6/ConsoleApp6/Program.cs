using System;

namespace ConsoleApp6
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
            Console.WriteLine("2.6.1.問題6-1のコンソール出力");
            static int Square(int input){return input*input;};
            try
            {
                Console.WriteLine("数値を入力して下さい。");
                int input = int.Parse(Console.ReadLine());
                int result = Square(input);
                Console.WriteLine($"入力した数値の2乗は{result}です。");
            }
            catch
            {
                Console.WriteLine("数値を入力しなさい");
            }
            Console.WriteLine("");
        }
        static void question2()
        {
            Console.WriteLine("2.6.2.問題6-2のコンソール出力");
            static int Average(int input1 , int input2) { return (input1 + input2)/2; };
            try
            {
                Console.WriteLine("数値1を入力して下さい。");
                int input1 = int.Parse(Console.ReadLine());
                Console.WriteLine("数値2を入力して下さい。");
                int input2 = int.Parse(Console.ReadLine());
                int result = Average(input1, input2);
                Console.WriteLine($"入力した数値の平均は{result}です。");
            }
            catch
            {
                Console.WriteLine("数値を入力しなさい");
            }
            Console.WriteLine("");
        }
        static void question3()
        {
            Console.WriteLine("2.6.3.問題6-3のコンソール出力");
            static int LargerNum(int input1, int input2)
            {
                if(input1> input2)
                {
                    return input1;
                }else
                {
                    return input2;
                }
            };
            try
            {
                Console.WriteLine("数値1を入力して下さい。");
                int input1 = int.Parse(Console.ReadLine());
                Console.WriteLine("数値2を入力して下さい。");
                int input2 = int.Parse(Console.ReadLine());
                if (input1 == input2)
                {
                    Console.WriteLine("入力した数値が同じ値の時の指定処理がありません。");
                } else{

                    int result = LargerNum(input1, input2);
                    Console.WriteLine($"入力した大きい数値は{result}です。");
                }
            }
            catch
            {
                Console.WriteLine("数値を入力しなさい");
            }
            Console.WriteLine("");
        }
        static void question4()
        {
            Console.WriteLine("2.6.4.問題6-4のコンソール出力");
            static int Average(int[] array)
            {
                int average = 0;
                int sum = 0;
                for(int i=0; i < array.Length; i++) {
                    sum = sum + array[i];
                    Console.WriteLine(sum+":"+(array.Length));
                    average = sum / array.Length;
                }
                return average;
            };
            static int Max(int[] array)
            {
                Array.Sort(array);
                int max = array[array.Length-1];
                return max;
            };
            static int Min(int[] array)
            {
                Array.Sort(array);
                int min = array[0];
                return min;
            };
            int[] array = new int[5];
            Console.WriteLine("数値を入力して下さい。");
            try
            {
                for(int i=1; i<6; i++) { 
                    Console.WriteLine($"{i}回目:");
                    array[i-1] = int.Parse(Console.ReadLine());
                }
                int max = Max(array);
                int min = Min(array);
                int average = Average(array);
                Console.WriteLine($"入力された最大値は{max}です。");
                Console.WriteLine($"入力された最小値は{min}です。");
                Console.WriteLine($"入力された平均値は{average}です。");
            }
            catch
            {
                Console.WriteLine("数値を入力しなさい");
            }
            Console.WriteLine("");
        }
    }
}