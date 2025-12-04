using System;
using System.IO;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
namespace ConsoleApp11;

class Program
{
    static void Main(string[] args)
    {
        string path = "data/logs";
        string fileName = "today.txt";
        string combine = Path.Combine(path, fileName);
        string usersPath = $"{path}/users.csv";

        question1();
        question2();
        question3();
        question4();
        question5();
        question6(path, fileName, combine);
        question7(path, fileName,combine);
        question8(path);
        question9(usersPath);
        question10(usersPath);
        question11(usersPath);
        question12();
        question13();
        question14();
        question15();
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
                using (StreamReader sr = new StreamReader(fileName))
                {
                    if (File.Exists(fileName))
                    {
                        Console.WriteLine("存在しません");
                    }
                    else
                    {
                        //内容を行番号付きで表示する。
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
        //users.csv を1行ずつ読み込み、各行を カンマ（,）で Split して、Name と Age を表示する。
        StreamReader sr = new StreamReader(usersPath);
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
        //例：Taro,20 → Name = Taro, Age = 20
        //想定外の列数の場合はスキップし、警告を出す。

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
        Console.WriteLine("5.9.1.問題7-1のコンソール出力");
        //List<User> を受け取り、ヘッダ行 と 各行の整形表示 を行うメソッド PrintUsersTable(List<User> users) を作成する。
        //列幅を揃えて見やすく表示する（例：Name は左寄せ、Age は右寄せ）。

        Console.WriteLine();
    }
    static void question13()
    {
        Console.WriteLine("5.10.1.問題10-1のコンソール出力");
        //日本語を含む行を UTF-8 で utf8.txt に書き込み、同じく UTF-8 で読み込んで表示する。
        //書き込み時・読み込み時に new StreamWriter(path, append: false, Encoding.UTF8) / new StreamReader(path, Encoding.UTF8) を指定する。
        //文字化けしないことを確認する。

        Console.WriteLine();
    }
    static void question14()
    {
        Console.WriteLine("5.11.1.問題11-1のコンソール出力");
        //メソッド Log(string message) を用意し、logs/app.log に 日付時刻＋メッセージ を 1 行追記する。
        //例：2025 - 09 - 03T10: 15:00 ユーザー登録成功(Taro)
        //アプリ起動時に「起動しました」、終了前に「終了します」を記録する。
        //例外発生時は catch で Log("ERROR: " + 例外メッセージ) を残す。

        Console.WriteLine();
    }
    static void question15()
    {
        Console.WriteLine("5.12.1.問題11-1のコンソール出力");
        //データ構造：Person クラス（Name, Phone, Email）。
        //データファイル：address.csv（ヘッダ無し、1 行 = 1 人、カンマ区切り）。
        //メニューを表示する：
        //一覧表示
        //追加
        //検索（名前の部分一致）
        //削除（完全一致）
        //終了
        //起動時：address.csv を読み込み List<Person> に格納。無ければ新規作成。
        //終了時：List<Person> を 全件 address.csv に上書き保存。
        //入力値の妥当性チェック（空文字やカンマを含む場合の扱いなど）を入れる。
        //例外発生時はメッセージを表示し、アプリが落ちないようにする。

        Console.WriteLine();
    }
}