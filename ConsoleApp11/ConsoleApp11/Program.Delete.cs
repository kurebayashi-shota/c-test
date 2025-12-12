using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
namespace ConsoleApp11;

public partial class Program
{
    static void Delete(List<Person> persons)
    {
        Console.WriteLine("削除");

        Console.WriteLine("削除前のリスト");
        foreach (Person item in persons)
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("削除する人の名前を入力してください");
        string input = Console.ReadLine();
        Person person = persons.FirstOrDefault(i => i.Name == input);
        Console.WriteLine($"{person}さんを削除しました。");
        persons.Remove(person);

        Console.WriteLine("削除後のリスト");
        foreach(Person item in persons)
        {
            Console.WriteLine(item.Name); 
        }
    }
}