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
        string fileName = "VendingData.csv";
        string data = Path.Combine(path, fileName);
        bool end = true;
        int mode = 1;
        int total = 0;
        Console.WriteLine("8.5.問題5(自販機アプリ)");
        LoadData(path, data);
        static void selectMode(int mode)
        {
            try { mode = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Enterキーを押した?もう一度入力して下さい。");
                selectMode(mode);
            }
        }
        while (end)
        {
            Console.WriteLine("行う操作を選択してください");
            Console.WriteLine("1:お金を入れる 2:購入する 3:返金 4:終了");
            selectMode(mode);

            switch (mode)
            {
                case 0: Administrator(); break;
                case 1: Payment(total); break;
                case 2: Buy(total); break;
                case 3: Refund(total); break;
                case 4: end = false; WriteData(path,data); break;
                default: Console.WriteLine("入力が不正です。"); break;
            }
            Console.WriteLine();
        }
    }
    static void Payment(int total)
    {
        Console.WriteLine("お金を投入してください。10 / 50 / 100 / 500 / 1000 円のみ受付");
        int payment = 0;

        try{payment = int.Parse(Console.ReadLine());}
        catch{ Console.WriteLine("数字以外が入力されました。"); }

        switch (payment)
        {
            case 10: total += 10; break;
            case 50: total += 50; break;
            case 100: total += 100; break;
            case 500: total += 500; break;
            case 1000: total += 1000; break;
                default : Console.WriteLine("不正な金種なので拒否します"); break;
        }
    }
    static void Buy(int total)
    {
        Console.WriteLine("");
        //購入する（商品番号を指定）
        //購入条件：在庫が 1 以上、投入金額が価格以上、釣銭が不足していないこと。
        //購入成功時：在庫を減らし、売上を加算し、必要に応じておつりを払い出す。
    }
    static void Refund(int total)
    {
        Console.WriteLine("");
        //返金（投入金を払い戻す）
        //返金時：投入金額をそのまま返す。
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
    static void LoadData(string path, string data)
    {
        List<Item> lists = new List<Item>();
        StreamReader sr = new StreamReader(path);
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            string[] values = line.Split(',');
            int sales = int.Parse(values[0]);
            //↓引数確認
            //lists.Add(new Item(values[0], int.Parse(values[1])));

        }
        //起動時に商品一覧（番号・名前・価格・在庫）を表示する。
    }
    static void WriteData(string path, string data)
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
            if (!File.Exists(data))
            {
                using (FileStream fs = File.Create($"{data}")) ;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("ファイル作成に失敗しました。", e.ToString());
        }
        try
        {
            using (StreamWriter sw = new StreamWriter(data, append: true))
            {
                DateTime dt = DateTime.Now;
                string date = dt.ToString("yyyy - MM - dd");
                sw.WriteLine($"{date}");
            }
            Console.WriteLine("書き込みが完了しました");
        }
        catch
        {
            Console.WriteLine("書き込みに失敗しました");
        }

    }
}