using System;
namespace BookLending;

class Program
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public bool Lend { get; set; }
        public Book(string name, string author)
        {
            Name = name;
            Author = author;
            Lend = false;
        }
    }
    static void Main()
    {
        Console.WriteLine("8.4.問題4(図書館貸出アプリ)");
        bool end = true;
        int mode = 1;
        List<Book> bookList = new List<Book>();
        while (end)
        {
            Console.WriteLine("行う操作を選択してください");
            Console.WriteLine("1:登録 2:一覧表示 3:貸出 4:返却 5:終了");
            try { mode = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Enterキーを押した?めんどくさいので登録モードに入ります。"); }

            switch (mode)
            {
                case 1: Regist(bookList); break;
                case 2: List(bookList); break;
                case 3: Lend(bookList); break;
                case 4: Return(bookList); break;
                case 5: end = false; break;
                default: Console.WriteLine("入力が不正です。"); break;
            }
            Console.WriteLine();
        }
    }
    static void Regist(List<Book> bookList)
    {
        Console.WriteLine("登録");
        Console.WriteLine("登録する本の数を入力して下さい。");
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{i + 1}冊目のタイトル->著者の順番で入力して下さい。");
            bookList.Add(new Book($"{Console.ReadLine()}", $"{Console.ReadLine()}"));
        }
    }
    static void List(List<Book> bookList)
    {
        Console.WriteLine("一覧表示");
        Console.WriteLine("登録された図書一覧です。");
        foreach (var item in bookList)
        {
            Console.WriteLine($"{item.Name}:{item.Author}:{LoanStatus(item)}");
        }
        Console.WriteLine();
    }
    static void Lend(List<Book> bookList)
    {
        Console.WriteLine("貸出");
        Console.WriteLine("貸出する図書名を入力してください。");
        string input = Console.ReadLine();
        foreach (var item in bookList)
        {
            if (item.Name == input)
            {
                item.Lend = true;
                Console.WriteLine($"{item.Name}を貸出しました。");
            }
        }
        Console.WriteLine();
    }
    static void Return(List<Book> bookList)
    {
        Console.WriteLine("返却");
        Console.WriteLine("返却する図書名を入力してください。");
        string input = Console.ReadLine();
        foreach(var item in bookList)
        {
            if (item.Name == input)
            {
                item.Lend = false;
                Console.WriteLine($"{item.Name}を返却しました。");
            }
        }
        Console.WriteLine();
    }
    static string LoanStatus(Book bookList)
    {
        if (bookList.Lend){ return "貸出中"; }
        else { return "利用可能"; }
    }
}