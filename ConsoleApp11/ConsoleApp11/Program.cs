using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
namespace ConsoleApp11;

public partial class Program
{
    static void Main(string[] args)
    {
        string path = "data/logs";
        string fileName = "today.txt";
        string combine = Path.Combine(path, fileName);
        string usersPath = $"{path}/users.csv";
        string utf8Path = $"{path}/utf8.txt";
        string addressPath = $"{path}/address.csv";
        string appPath = $"{path}/app.log.csv";

        //question1();
        //question2();
        //question3();
        //question4();
        //question5();
        //question6(path, fileName, combine);
        //question7(path, fileName, combine);
        //question8(path);
        //question9(usersPath);
        //question10(usersPath);
        //question11(usersPath);
        question12();
        //question13(utf8Path);
        //question14(path,appPath);
        //question15(addressPath,path);
    }

    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string ShowProfile()
        {
            return Name+ Age.ToString();
        }
    }
    static void question1()
    {
        Console.WriteLine("5.1.1.問題1-1のコンソール出力");
        try
        {
            using (StreamWriter sw = new StreamWriter(@"c:\c#test\output.txt"))
            {
                sw.WriteLine("私は榑林昭太です。");
                sw.WriteLine("CL株式会社に勤めています。");
                sw.WriteLine("尊敬する人は平野さんです。");
            }
            Console.WriteLine("書き込みが完了しました");
        }
        catch
        {
            Console.WriteLine("書き込みに失敗しました");
        }
        Console.WriteLine();
    }
    static void question2()
    {
        Console.WriteLine("5.2.1.問題2-1のコンソール出力");
        string line = "";
        try
        {
            using (StreamReader sr = new StreamReader(@"c:\c#test\output.txt"))
            {
                for(int i = 1; i< 4; i++)
                {
                    Console.WriteLine($"{i}:{sr.ReadLine()}");
                }
            }
        }
        catch { Console.WriteLine("ファイルが見つかりません"); }
        Console.WriteLine();
    }
    static void question3()
    {
        Console.WriteLine("5.3.1.問題3-1のコンソール出力");
        try
        {
            using (StreamWriter sw = new StreamWriter(@"c:\c#test\append.txt", append: true))
            {
                DateTime dt = DateTime.Now;
                string date = dt.ToString("yyyy - MM - dd");
                sw.WriteLine($"{date} メモ内容");
            }
            Console.WriteLine("書き込みが完了しました");
        }
        catch
        {
            Console.WriteLine("書き込みに失敗しました");
        }

        Console.WriteLine();
    }
    static void question4()
    {
        Console.WriteLine("5.3.2.問題3-2のコンソール出力");
        try
        {
            using (StreamWriter sw = new StreamWriter(@"c:\c#test\append.txt",false))
            {
                sw.WriteLine("初期化しました");
            }
            Console.WriteLine("書き込みが完了しました");
            using (StreamReader sr = new StreamReader(@"c:\c#test\append.txt"))
                Console.WriteLine(sr.ReadToEnd());
        }
        catch
        {
            Console.WriteLine("書き込みに失敗しました");
        }

        Console.WriteLine();
    }
    static void question5()
    {
        Console.WriteLine("5.4.1.問題4-1のコンソール出力");
        try
        {
            Console.WriteLine("ファイル名を入力して下さい");
            string fileName = Console.ReadLine();
            try
            { 
                using (StreamReader sr = new StreamReader($@"{fileName}"))
                {
                    if (File.Exists($@"{fileName}"))
                    {
                        string line;
                        for (int i=1; (line = sr.ReadLine()) != null;i++)
                        {
                            Console.WriteLine($"{i}:{line}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("存在しません");
                    }
                }
            }
            catch { Console.WriteLine("例外が発生しました。"); }
        }
        catch { Console.WriteLine("存在しません"); }

        Console.WriteLine();
    }
    static void question6(string path, string fileName, string combine)
    {
        Console.WriteLine("5.5.1.問題5-1のコンソール出力");
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
            if (!File.Exists(combine))
            {
                using (FileStream fs = File.Create($"{combine}")) ;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("ファイル作成に失敗しました。", e.ToString());
        }
        try
        {
            using (StreamWriter sw = new StreamWriter(combine, append: true))
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
        Console.WriteLine();
    }
    static void question7(string path, string fileName, string combine)
    {
        Console.WriteLine("5.5.2.問題5-2のコンソール出力");
        string[] files = Directory.GetFiles(path, "*.txt");
        foreach (string file in files)
        {
            string textfile = Path.GetFileName(file);
            FileInfo fileSize = new FileInfo(file);
            DateTime lastWriteTime = File.GetLastWriteTime(file);
            Console.WriteLine($"ファイル名:{ textfile},ファイルサイズ{fileSize},更新日時{lastWriteTime}");
        };
        Console.WriteLine();
    }
    static void question8(string path)
    {
        string quickPath = $"{path}/quick.txt";
        Console.WriteLine("5.6.1.問題6-1のコンソール出力");
        if (!File.Exists(quickPath))
        {
            string[] createText = { "Hello", "And", "Welcome" };
            try
            {
                if (!File.Exists(quickPath))
                {
                    using (FileStream fs = File.Create(quickPath)) ;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ファイル作成に失敗しました。", e.ToString());
            }
            File.WriteAllLines(quickPath, createText, Encoding.UTF8);
        }

        string[] readText = File.ReadAllLines($"{path}/quick.txt", Encoding.UTF8);
        foreach (string s in readText)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine();
    }
    static void question9(string usersPath)
    {
        Console.WriteLine("5.7.1.問題7-1のコンソール出力");
        StreamReader sr = new StreamReader(usersPath);
        while (!sr.EndOfStream)
        {
            try
            {
                string line = sr.ReadLine();
                string[] values = line.Split(',');

                List<string> lists = new List<string>();
                lists.AddRange($"Name={values[0]},Age={values[1]}");

                foreach (string list in lists)
                {
                    System.Console.Write("{0} ", list);
                }
                System.Console.WriteLine();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("想定外の列数の場合なのでスキップします");
                continue;
            }
        }
        Console.WriteLine();
    }
    static void question10(string usersPath)
    {
        Console.WriteLine("5.7.2.問題7-2のコンソール出力");
        if (!File.Exists(usersPath))
        {
            try
            {
                if (!File.Exists(usersPath))
                {
                    using (FileStream fs = File.Create(usersPath)) ;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ファイル作成に失敗しました。", e.ToString());
            }
        }

        Console.WriteLine("ユーザー情報をName->Ageの順で入力して下さい");
        User user = new User(Console.ReadLine(),ageInput());
        static int ageInput()
        {
            try{ return int.Parse(Console.ReadLine()); }
            catch { return ageInput(); };
        }
        using (StreamWriter sw = new StreamWriter(usersPath, append: true))
        {
            sw.WriteLine($"{user.Name},{user.Age}");
            Console.WriteLine($"{user.Name},{user.Age}");
        }
        Console.WriteLine("書き込みが完了しました");



        Console.WriteLine();
    }
    static void question11(string usersPath)
    {
        Console.WriteLine("5.8.1.問題8-1のコンソール出力");
        List<User> lists = new List<User>();
        StreamReader sr = new StreamReader(usersPath);
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            string[] values = line.Split(',');

            lists.Add(new User(values[0], int.Parse(values[1])));

        }
        foreach (var list in lists)
        {
            Console.WriteLine(list.Name);
        }
        Console.WriteLine();
        var oderResult = lists.OrderByDescending(x => x.Age);
        foreach (var item in oderResult)
        {
            Console.WriteLine($"{item.Name}:{item.Age}");
        }

        Console.WriteLine();
    }
    static void question12()
    {
        Console.WriteLine("5.9.1.問題9-1のコンソール出力");
        string[] userName = ["taro", "hanako", "shota", "ryota"];
        List<User> users = new List<User>();
        for (int i = 0; i < userName.Length; i++)
        {
            users.Add(new User(userName[i], 10+i));
        }

        PrintUsersTable(users);

        static void PrintUsersTable(List<User> users)
        {
            string name = "Name";
            string age = "Age";
            Console.WriteLine($"{name,-6}{age,6}");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name,-6}{user.Age,6}");
            }
        }

        Console.WriteLine();
    }
    static void question13(string utf8Path)
    {
        Console.WriteLine("5.10.1.問題10-1のコンソール出力");
        using (StreamWriter sw = new StreamWriter(utf8Path, append: true, Encoding.UTF8))
        {
            sw.WriteLine($"日本語を含む行desu");
        }
        using (StreamReader sr = new StreamReader(utf8Path, Encoding.UTF8))
        {
            Console.WriteLine($"{sr.ReadLine()}が文字化けしないことを確認");
        }
        Console.WriteLine();
    }
    static void question14(string path, string appPath)
    {
        Console.WriteLine("5.11.1.問題11-1のコンソール出力");
        Console.WriteLine("起動しました");
        DateTime dt = DateTime.Now;
        string result = dt.ToString("yyyy-MM-dd HH:mm:ss");
        try
        {
            if (!File.Exists(appPath))
            {
                using (FileStream fs = File.Create(appPath)) ;
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(appPath, append:true))
                {
                    sw.WriteLine("起動しました");
                    sw.WriteLine($"{result} ユーザー登録成功(Taro)");
                    sw.WriteLine("終了します");
                }
            }
        }
        catch (Exception e)
        {
            Log("ERROR: " + e.Message, appPath);
        }
        static void Log(string message, string appPath)
        {
            using (StreamWriter sw = new StreamWriter(appPath, append: true))
            {
                sw.WriteLine(message);
            }
        }
        Console.WriteLine("終了します");

        Console.WriteLine();
    }
    static void question15(string addressPath ,string path)
    {
        Console.WriteLine("5.12.1.問題11-1のコンソール出力");
        //入力値の妥当性チェック（空文字やカンマを含む場合の扱いなど）を入れる。
        try
        {
            Console.WriteLine("アドレス帳アプリが起動しました。");
            List<Person> persons = new List<Person>();
            bool end = true;
            try
            {
                if (!File.Exists(addressPath))
                {
                    using (FileStream fs = File.Create(addressPath)) ;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ファイル作成に失敗しました。", e.ToString());
            }
            using (StreamReader sr = new StreamReader(addressPath, Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(',');

                    persons.Add(new Person(values[0], long.Parse(values[1]), values[2]));
                }
            }
            static int selectMode(string addressPath)
            {
                try { return int.Parse(Console.ReadLine()); }
                catch
                {
                    Console.WriteLine("数字以外が入力されました。再入力してください");
                    return selectMode(addressPath);
                }
            }
            while (end)
            {
                Console.WriteLine("行う操作を選択してください");
                Console.WriteLine("1:一覧表示 2:追加 3:検索（名前の部分一致）4:削除（完全一致）5:終了");
                int mode = selectMode(addressPath);

                switch (mode)
                {
                    case 1: Show(persons); break;
                    case 2: Add(persons); break;
                    case 3: Find(persons); break;
                    case 4: Delete(persons); break;
                    case 5: end = false; End(addressPath, persons,path); break;
                    default: Console.WriteLine("入力が不正です。"); break;
                }
                Console.WriteLine();
            }
        }
        catch
        {
            Console.WriteLine("例外が発生しましたがアプリが落ちないようにしています。");
            Console.WriteLine("アプリを再起動します。");
            question15(addressPath,path);
        }
        Console.WriteLine();
    }
}