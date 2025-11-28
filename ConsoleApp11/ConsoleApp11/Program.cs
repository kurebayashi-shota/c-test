using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
namespace ConsoleApp11;

class Program
{
    static void Main(string[] args)
    {
        question1();
        question2();
        question3();
        question4();
        question5();
        //question6();
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
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch { Console.WriteLine("例外が発生しました。"); }
        }
        catch { Console.WriteLine("存在しません"); }

        Console.WriteLine();
    }
}