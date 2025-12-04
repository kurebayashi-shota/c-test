using System;
using System.Text;
namespace WordBook;

class Program
{
    //上書きor追記選択
    static void Main()
    {
        bool end = true;
        int mode = 1;
        Console.WriteLine("8.2.問題2(単語帳アプリ)");
        while (end)
        {
            Console.WriteLine("モードを選択してください");
            Console.WriteLine("1:登録 2:一覧表示 3:検索 4:終了");
            try { mode = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Enterキーを押した?めんどくさいので登録モードに入ります。"); }
            
            switch (mode)
            {
                case 1: Regist(); break;
                case 2: List(); break;
                case 3: Find(); break;
                case 4: end = false; break;
                default: Console.WriteLine("入力が不正です。"); break;
            }
            Console.WriteLine();
        }
    }
    static void Regist()
    {
        Console.WriteLine("登録");
        List <string> words = new List <string>();
        Console.WriteLine("登録する単語数を入力して下さい。");
        int count = int.Parse(Console.ReadLine());
        for(int i = 0; i < count; i++)
        {
            Console.WriteLine($"{i+1}個目を単語->意味の順番で入力して下さい。");
            words.Add($"{Console.ReadLine()},{Console.ReadLine()}");
        }
        Console.WriteLine($"登録された単語");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
        File.WriteAllLines(@"c:\c#test\words.csv", words, Encoding.UTF8);
    }
    static void List()
    {
        Console.WriteLine("一覧表示");
        Console.WriteLine("登録された単語です。");
        StreamReader sr = new StreamReader(@"c:\c#test\words.csv");
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            string[] values = line.Split(',');

            List<string> lists = new List<string>();
            lists.AddRange(values);

            foreach (string list in lists)
            {
                System.Console.Write("{0} ", list);
            }
            System.Console.WriteLine();
        }
    }
    static void Find()
    {
        Console.WriteLine("検索");
        Dictionary<string, string> words = new Dictionary<string, string>();
        StreamReader sr = new StreamReader(@"c:\c#test\words.csv");
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            string[] values = line.Split(',');
            words.Add(values[0], values[1]);
        }
        Console.WriteLine("検索したい単語を入力してください。");
        string input = Console.ReadLine();
        if (words.ContainsKey(input))
        {
            Console.WriteLine(words[input]);
        }
        else
        {
            Console.WriteLine("存在しません");
        }
    }
}