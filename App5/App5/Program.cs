using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Channels;
namespace VendingMachine;

public partial class Program
{
    static bool initialized = false;
    static int sales = 0;
    static List<Item> list;
    static List<CoinCase> coinCase;
    static void Main()
    {
        string path = "data/logs";
        string salesData = "SalesData.csv";
        string itemData = "ItemData.csv";
        string changeData = "change.csv";
        string salesPath = Path.Combine(path, salesData);
        string itemPath = Path.Combine(path, itemData);
        string changePath = Path.Combine(path, changeData);
        bool end = true;
        int total = 0;

        Console.WriteLine("8.5.問題5(自販機アプリ)");

        if (!initialized)
        {
            list = LoadItems(itemPath);
            coinCase = LoadChange(changePath);
            sales = LoadSales(salesPath);
            initialized = true;
        }
        static int selectMode()
        {
            try { return int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("数字以外が入力されました。再入力してください");
                return selectMode();
            }
        }
        while (end)
        {
            Console.WriteLine("行う操作を選択してください");
            if (total > 0) Console.WriteLine($"投入合計金額:{total}円");
            Console.WriteLine("1:お金を入れる 2:購入する 3:返金 4:終了");
            int mode = selectMode();

            switch (mode)
            {
                case 0: Administrator(salesPath, sales,list,coinCase); break;
                case 1: total += Payment(); break;
                case 2: int buyResult = Buy(total, list, coinCase);
                        total -= buyResult;
                        sales += buyResult; break;
                case 3: Refund(total); total = 0; break;
                case 4: WriteData(path, salesPath, itemPath, changePath, sales, list, coinCase); end = false; break;
                default: Console.WriteLine("入力が不正です。"); break;
            }
            Console.WriteLine();
        }
    }
    static void Refund(int total)
    {
        Console.WriteLine("投入金を払い戻します。");
        Console.WriteLine($"{total}円返却しました。");
    }    
}