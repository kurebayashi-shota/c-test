using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Channels;
namespace VendingMachine;

public partial class Program
{
    static int Payment()
    {
        Console.WriteLine("お金を投入してください。10 / 50 / 100 / 500 / 1000 円のみ受付");

        try
        {
            int payment = int.Parse(Console.ReadLine());
            switch (payment)
            {
                case 10: return 10;
                case 50: return 50;
                case 100: return 100;
                case 500: return 500;
                case 1000: return 1000;
                default:
                    Console.WriteLine("不正な金種なので拒否します。再入力してください");
                    return Payment();
            }
        }
        catch
        {
            Console.WriteLine("数字以外が入力されました。再入力してください");
            return Payment();
        }
    }
}