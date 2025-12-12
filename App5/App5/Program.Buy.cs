using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Channels;
namespace VendingMachine;

public partial class Program
{
    static int Buy(int total, List<Item> list, List<CoinCase> coinCase)
    {
        Dictionary<int, int> priceDic = new Dictionary<int, int>();
        Dictionary<int, int> countDic = new Dictionary<int, int>();
        int change1000 = 0;
        int change500 = 0;
        int change100 = 0;
        int change50 = 0;
        int change10 = 0;
        int temp = total;
        string shortageMessage = "釣銭が不足しています。";

        Console.WriteLine("購入する商品のIDを入力してください");
        Console.WriteLine("購入を止める場合は[99]を入力してください");
        int price = 0;
        foreach (Item item in list)
        {
            Console.Write($"ID{item.Id}:{item.Name}");
            priceDic.Add(item.Id, item.Price);
            countDic.Add(item.Id, item.Count);
        }
        Console.WriteLine();
        int input =0;
        try
        {
            input = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine("エラー。処理を戻します。");
            Buy(total,list,coinCase);
        }

        if (input == 99) { Console.WriteLine("購入を止めました。"); return Buy(price, list, coinCase); }

        if (priceDic.ContainsKey(input) && countDic[input]>0)
        {
            price = priceDic[input];
            total -= price;
            if (total >=1000)
            {
                change1000 = total / 1000;
                total -= (change1000 * 1000);
                var coin1000 = coinCase.FirstOrDefault(i => i.pType == 1000);
                if (coin1000.pCount >= change1000) { coin1000.pCount -= change1000; }
                else
                {
                    Console.WriteLine(shortageMessage);
                    total = temp;
                    return Buy(total,list,coinCase);
                }
            }
            if (total >= 500)
            {
                change500 = total / 500;
                total -= (change500 * 500);
                var coin500 = coinCase.FirstOrDefault(i => i.pType == 500);
                if (coin500.pCount >= change500) { coin500.pCount -= change500; }
                else
                {
                    Console.WriteLine(shortageMessage);
                    total = temp;
                    return Buy(total, list, coinCase);
                }
            }
            if (total >= 100)
            {
                change100 = total / 100;
                total -= (change100 * 100);
                var coin100 = coinCase.FirstOrDefault(i => i.pType == 100);
                if (coin100.pCount >= change100) { coin100.pCount -= change100; }
                else
                {
                    Console.WriteLine(shortageMessage);
                    total = temp;
                    return Buy(total, list, coinCase);
                }
            }
            if (total >= 50)
            {
                change50 = total / 50;
                total -= (change50 * 50);
                var coin50 = coinCase.FirstOrDefault(i => i.pType == 50);
                if (coin50.pCount >= change50) { coin50.pCount -= change50; }
                else
                {
                    Console.WriteLine(shortageMessage);
                    total = temp;
                    return Buy(total, list, coinCase);
                }
            }
            if (total >= 10){
                change10 = total / 10;
                total -= (change10 * 10);
                var coin10 = coinCase.FirstOrDefault(i => i.pType == 10);
                if (coin10.pCount >= change10) { coin10.pCount -= change10; }
                else
                {
                    Console.WriteLine(shortageMessage);
                    total = temp;
                    return Buy(total, list, coinCase);
                }
            }
            price = priceDic[input];
            var buyItem = list.FirstOrDefault(i => i.Id == input);
            buyItem.Count -= 1;
            if(total >= 1000)
            Console.WriteLine($"{priceDic[input]}を購入しました。");
            total = temp;
            if (buyItem.Price <= total)
            {
                return buyItem.Price;
            }
            else { Console.WriteLine("投入金額が不足しています。"); return Buy(price, list, coinCase); }
        }
        else {Console.WriteLine("その商品はありません");}
        return Buy(price, list, coinCase); ;
        //購入成功時：売上を加算し、必要に応じておつりを払い出す。
    }
}