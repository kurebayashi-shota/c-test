using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
namespace ConsoleApp11;

public partial class Program
{
    static void Find(List<Person> persons)
    {
        Console.WriteLine("検索したい人の名前を入力してください(部分一致)");
        string input = Console.ReadLine();
        Console.WriteLine("下記の人が一致しました。");
        foreach (Person person in persons)
        {
            var regex = new Regex(input);
            string personName = person.Name;
            if (regex.IsMatch(personName))
            {
                Console.WriteLine($"・{personName}さん");
            }
        }
    }
}