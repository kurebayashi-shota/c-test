using System;
using System.IO;
namespace VendingMachine;

class Program
{
    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public Item(int id, string name, int price, int count)
        {
            Id = id; Name = name;
            Name = name;
            Price = price;
            Count = count;
        }
    }
    static void Main()
    {
        string path = "data/logs";
        string salesData = "SalesData.csv";
        string itemData = "ItemData.csv";
        string salesPath = Path.Combine(path, salesData);
        string itemPath = Path.Combine(path, itemData);
        bool end = true;
        int total = 0;

        Console.WriteLine("8.5.問題5(自販機アプリ)");

        int sales = LoadSales(path, salesPath);
        List<Item> list = LoadItems(path, itemPath);

        foreach (var item in list)
        {
            Console.WriteLine($"番号:{item.Id}・名前:{item.Name}・価格:{item.Price}円・在庫:{item.Count}本");
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
            Console.WriteLine($"売上:{sales}円");//消す?
            Console.WriteLine("1:お金を入れる 2:購入する 3:返金 4:終了");
            int mode = selectMode();

            switch (mode)
            {
                case 0: Administrator(); break;
                case 1: total += Payment(); break;
                case 2: total -= Buy(total, list); break;
                case 3: Refund(total); total = 0; break;
                case 4: end = false; WriteData(path, salesPath, itemPath, sales); break;
                default: Console.WriteLine("入力が不正です。"); break;
            }
            Console.WriteLine();
        }
    }
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
    static int Buy(int total, List<Item> list)
    {
        Dictionary<int, int> itemDic = new Dictionary<int, int>();
        Console.WriteLine("購入する商品のIDを入力してください");
        Console.WriteLine("購入を止める場合は[99]を入力してください");
        int price = 0;
        foreach (Item item in list)
        {
            Console.Write($"ID{item.Id}:{item.Name}");
            itemDic.Add(item.Id, item.Price);
        }
        Console.WriteLine();
        int input = int.Parse(Console.ReadLine());
        if (input == 99) { Console.WriteLine("購入を止めました。"); return total; }
        if (itemDic.ContainsKey(input))
        {
            price = itemDic[input];
        }
        else
        {
            Console.WriteLine("その商品はありません");
        }
        if (price < total)
        {
            return price;
        }
        else { Console.WriteLine("投入金額が不足しています。"); return Buy(price, list); }
        //購入条件：在庫が 1 以上、投入金額が価格以上、釣銭が不足していないこと。
        //購入成功時：在庫を減らし、売上を加算し、必要に応じておつりを払い出す。
    }
    static void Refund(int total)
    {
        Console.WriteLine("投入金を払い戻します。");
        Console.WriteLine($"{total}円返却しました。");
    }
    static void Administrator()
    {
        int pass = int.Parse(Console.ReadLine());
        if (pass == 1129)
        {
            Console.WriteLine("管理者モードです。");
            //管理者モードを用意し、在庫補充・釣銭補充・売上確認をできるようにする。
        }
        else {Main();}
    }
    static int LoadSales(string path, string salesPath)
    {
        using (StreamReader sr = new StreamReader(salesPath))
        {
            return int.Parse(sr.ReadLine());
        }
    }
    static List<Item> LoadItems(string path, string itemPath)
    {
        var list = new List<Item>();
        using (StreamReader sr = new StreamReader(itemPath))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] values = line.Split(',');
                list.Add(new Item(int.Parse(values[0]), values[1], int.Parse(values[2]), int.Parse(values[3])));
            }
        }
        return list;
    }
    static void WriteData(string path, string salesPath, string itemPath, int sales)
    {
        try
        {
            if (!Directory.Exists(path))
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("ディレクトリ作成に失敗しました。", e.ToString());
        }
        try
        {
            if (!File.Exists(salesPath))
            {
                using (FileStream fs = File.Create($"{salesPath}"));
                using (FileStream fs = File.Create($"{itemPath}")) ;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("ファイル作成に失敗しました。", e.ToString());
        }
        //try
        //{
            using (StreamWriter sw = new StreamWriter(salesPath, append: true))
            {
                sw.WriteLine(sales);
            }
            using (StreamWriter sw = new StreamWriter(itemPath, append:true))
            {
                //sw.WriteLine($"{date}");
            }
            Console.WriteLine("書き込みが完了しました");
        //}
        //catch
        //{
        //    Console.WriteLine("書き込みに失敗しました");
        //}

    }
}