using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Channels;
namespace VendingMachine;

public partial class Program
{
    static void Administrator(string salesPath, int sales, List<Item> list, List<CoinCase> coinCase)
    {
        int pass = int.Parse(Console.ReadLine());
        if (pass == 1129)
        {
            Console.WriteLine("管理者モードです。");
            Console.WriteLine("1:在庫補充,2:釣銭補充,3:売上確認,4:終了");

            int mode = 0;
            try{ mode = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine();Administrator( salesPath, sales, list, coinCase); }

            switch (mode)
            {
                case 1:
                    ProductReplenishment(list);
                    Console.WriteLine("再度管理者パスワードを入力してください。");
                    Administrator(salesPath, sales, list, coinCase); break;
                case 2:
                    ReplenishChange(coinCase);
                    Console.WriteLine("再度管理者パスワードを入力してください。");
                    Administrator(salesPath, sales, list, coinCase); break;
                case 3:
                    Console.WriteLine($"売上:{sales}円");
                    Console.WriteLine("再度管理者パスワードを入力してください。");
                    Administrator(salesPath, sales, list, coinCase); break;
                case 4: Console.WriteLine("一般モードに戻ります。"); Main(); break;
                default: Console.WriteLine("入力が不正です。"); break;
            }

            static void ProductReplenishment(List<Item> list)
            {
                Console.WriteLine("在庫補充です。補充したい商品のIDを入力してください。");
                foreach (var item in list)
                {
                    Console.WriteLine($"ID.{item.Id}:{item.Name}は{item.Count}本");
                }
                int input = int.Parse(Console.ReadLine());
                var selectItem = list.FirstOrDefault(i => i.Id == input);
                Console.WriteLine($"{selectItem.Name}を何本補充しますか?");
                selectItem.Count += int.Parse(Console.ReadLine());
            }

            static void ReplenishChange(List<CoinCase> coinCase)
            {
                Console.WriteLine("釣銭補充です。補充したい金種を入力してください。");
                foreach (var item in coinCase)
                {
                    Console.Write($"{item.pType}円:{item.pCount}枚,");
                }
                Console.WriteLine();
                int input = int.Parse(Console.ReadLine());
                var selectCoin = coinCase.FirstOrDefault(i => i.pType == input);
                Console.WriteLine($"{selectCoin.pType}円を何枚補充しますか?");
                selectCoin.pCount += int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

        }
        else { Main(); }
    }
}