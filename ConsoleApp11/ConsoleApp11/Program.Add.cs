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
    static void Add(List<Person> persons)
    {
        Console.WriteLine("追加");
        Console.WriteLine("追加したい人の情報を名前->電話番号->メールアドレスの順で入力してください。");
        persons.Add(new Person(Console.ReadLine(), long.Parse(Console.ReadLine()), Console.ReadLine()));
        Console.WriteLine("追加しました。");
    }
}