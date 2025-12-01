using System;
using System.Linq;
namespace ConsoleApp12;
class Program
{
    static void Main()
    {
        question1();
        question2();
        question3();
        question4();
        question5();
        question6();
        question7();
        question8();
        question9();
        question10();
        question11();
        question12();
        question13();
        question14();
    }
    class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
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
    static void question1()
    {
        Console.WriteLine("6.1.1.問題1-1のコンソール出力");
        var lists = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"整数{i+1}を入力して下さい。");
            lists.Add (int.Parse(Console.ReadLine()));
        }
        foreach(int list in lists)
        {
            Console.Write(list);
        }
        Console.WriteLine();
    }
    static void question2()
    {
        Console.WriteLine("6.1.2.問題1-2のコンソール出力");
        var lists = new List<int>();
        int total = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"整数{i + 1}を入力して下さい。");
            lists.Add(int.Parse(Console.ReadLine()));
            total+= lists[i];
        }
        Console.WriteLine(total);
        Console.WriteLine();
    }
    static void question3()
    {
        Console.WriteLine("6.2.1.問題2-1のコンソール出力");
        var lists = new List<string>() { "りんご", "ばなな", "みかん" };
        foreach (string str in lists)
        {
            Console.Write(str);
        }
        Console.WriteLine();
        Console.WriteLine("果物を入力して下さい。");
        string input = Console.ReadLine();
        foreach (string item in lists)
        {
            if (input == item) { Console.WriteLine("含まれています。"); }
        }
        Console.WriteLine();
    }
    static void question4()
    {
        Console.WriteLine("6.3.1.問題3-1のコンソール出力");
        Dictionary<string, int> countrys = new Dictionary<string, int>();

        countrys.Add("Japan", 125);
        countrys.Add("USA", 331);
        countrys.Add("France", 67);
        foreach (var item in countrys)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
    static void question5()
    {
        Console.WriteLine("6.3.2.問題3-2のコンソール出力");
        Dictionary<string, int> countrys = new Dictionary<string, int>();

        countrys.Add("Japan", 125);
        countrys.Add("USA", 331);
        countrys.Add("France", 67);
        foreach (var item in countrys)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("国名を入力してください。");
        string input = Console.ReadLine();
        if (countrys.ContainsKey(input))
        {
            Console.WriteLine(countrys[input]);
        }
        else
        {
            Console.WriteLine("存在しません");
        }
        Console.WriteLine();
    }
    static void question6()
    {
        Console.WriteLine("6.4.1.問題4-1のコンソール出力");
        List<Student> studentsList = new List<Student>();
        studentsList.Add(new Student("榑林",100));
        studentsList.Add(new Student("臼井", 50));
        studentsList.Add(new Student("平野", 0));

        foreach (var student in studentsList)
        {
            Console.Write($"{student.Name}:{student.Score}点,");
        }

        Console.WriteLine();
    }
    static void question7()
    {
        Console.WriteLine("6.5.1.問題5-1のコンソール出力");
        List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9};

        IEnumerable<int> it = numbers.Where(item => item % 2 == 0);

        foreach (int item in it)
        {
            Console.Write($"{ item},");
        }
        Console.WriteLine();
    }
    static void question8()
    {
        Console.WriteLine("6.5.2.問題5-2のコンソール出力");
        List<string> fruits = new List<string>() { "apple", "banana", "cherry", "date" };

        var fruitsOrder =  fruits.OrderBy(f => f);
        foreach (var fruit in fruits)
        {
            Console.Write($"{fruit},");
        }

        Console.WriteLine();
    }
    static void question9()
    {
        Console.WriteLine("6.6.1.問題6-1のコンソール出力");
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
        numbers
            .Select(x => x * 2)
            .ToList()
            .ForEach(x => Console.Write("{0}, ", x));

        Console.WriteLine();
    }
    static void question10()
    {
        Console.WriteLine("6.7.1.問題7-1のコンソール出力");
        List<int> numbers = new List<int>() { 80, 92, 75, 60, 45 };
        double average = numbers.Average();
        Console.WriteLine(average);

        Console.WriteLine();
    }
    static void question11()
    {
        Console.WriteLine("6.7.2.問題7-2のコンソール出力");
        List<int> numbers = new List<int>() { 80, 92, 75, 60, 45 };
        var result = numbers.Where((x) => x > 70);
        Console.WriteLine(result.Count());

        Console.WriteLine();
    }
    static void question12()
    {
        Console.WriteLine("6.8.1.問題8-1のコンソール出力");
        List<Student> studentsList = new List<Student>();
        studentsList.Add(new Student("A", 100));
        studentsList.Add(new Student("AB", 50));
        studentsList.Add(new Student("BC", 0));
        studentsList.Add(new Student("CD", 80));
        studentsList.Add(new Student("ABC", 70));

        var results = studentsList.Where((x) => x.Name.StartsWith("A") && x.Score >= 70);
        foreach (var item in results)
        {
            Console.Write($"{item.Name},");
        }
        Console.WriteLine();
    }
    static void question13()
    {
        Console.WriteLine("6.9.1.問題9-1のコンソール出力");
        List<Student> studentsList = new List<Student>()
        {
            new Student("Alice", 80),
            new Student("Bob", 75),
            new Student("Charlie", 80),
            new Student("Dave", 60)
        };
        //LINQ を使って 点数ごとにグループ化 し、グループごとに名前を表示する。
        var groupResults = studentsList.GroupBy(x => x.Score);
        foreach (var group in groupResults)
        {
            Console.WriteLine(group.Key);
            foreach (var item in group)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
        }
    }
    static void question14()
    {
        Console.WriteLine("6.10.1.問題10-1のコンソール出力");
        List<Product> productList = new List<Product>()
        {
            new Product("ギター", 1000, "楽器"),
            new Product("ベース", 1500, "楽器"),
            new Product("シールド", 300, "周辺機器"),
            new Product("オカリナ", 500, "楽器"),
            new Product("アンプ", 5000, "周辺機器"),
        };

        var selectResults = productList.Where(x => x.Price >= 1000);
        var groupResults = selectResults.GroupBy(x => x.Category);
        foreach (var group in groupResults)
        {
            int count = group.Count();
            var oderResult = group.OrderByDescending(x=>x.Price);
            Console.WriteLine(group.Key);
            Console.WriteLine($"商品数:{count}");
            foreach (var item in oderResult)
            {
                Console.WriteLine($"{item.Name}:{item.Price}");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}