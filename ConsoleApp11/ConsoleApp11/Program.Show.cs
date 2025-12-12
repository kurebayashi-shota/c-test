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
    static void Show(List<Person> persons)
    {
        Console.WriteLine("登録されている人の一覧です。");
        foreach (Person person in persons)
        {
            Console.WriteLine($"名前:{person.Name}  電話番号:{person.Phone}  メールアドレス:{person.Email}");
        }
    }
}