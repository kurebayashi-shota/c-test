using System;
using System.Text;
namespace ProductManagement;

class Program
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public Product(string name, int price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
    static void Main()
    {
        bool end = true;
        int mode = 1;
        Console.WriteLine("8.3.問題(商品管理アプリ)");
        List<Product> productList = new List<Product>();
        static void selectMode(int mode) {
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
            Console.WriteLine("1:登録 2:一覧表示(2,3両方) 3:高い順にソート 4:カテゴリー毎の表示 5:終了");
            selectMode(mode);

            switch (mode)
            {
                case 1: Regist(productList); break;
                case 2: List(productList); break;
                case 3: Sort(productList); break;
                case 4: Category(productList); break;
                case 5: end = false; break;
                default: Console.WriteLine("入力が不正です。"); break;
            }
            Console.WriteLine();
        }
    }
    static void Regist(List<Product> productList)
    {
        Console.WriteLine("登録");
        Console.WriteLine("登録する商品数を入力して下さい。");
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{i + 1}個目を商品名->値段->カテゴリーの順番で入力して下さい。");
            productList.Add(new Product($"{Console.ReadLine()}", int.Parse(Console.ReadLine()), $"{Console.ReadLine()}"));
        }
    }
    static void List(List<Product> productList)
    {
        Console.WriteLine("一覧表示");
        Console.WriteLine("登録された商品一覧です。");
        var groupResults = productList.GroupBy(x => x.Category);
        foreach (var group in groupResults)
        {
            int count = group.Count();
            var oderResult = group.OrderByDescending(x => x.Price);
            Console.WriteLine(group.Key);
            foreach (var item in oderResult)
            {
                Console.WriteLine($"{item.Name}:{item.Price}");
            }
            Console.WriteLine();
        }
    }
    static void Sort(List<Product> productList)
    {
        Console.WriteLine("ソート");
        var oderResult = productList.OrderByDescending(x => x.Price);
        foreach (var item in oderResult)
        {
            Console.WriteLine($"{item.Name}:{item.Price}");
        }
        Console.WriteLine();
    }
    static void Category(List<Product> productList)
    {
        Console.WriteLine("カテゴリー");
        var groupResults = productList.GroupBy(x => x.Category);
        foreach (var group in groupResults)
        {
            int count = group.Count();
            Console.WriteLine(group.Key);
            foreach (var item in group)
            {
                Console.WriteLine($"{item.Name}:{item.Price}");
            }
            Console.WriteLine();
        }

    }
}