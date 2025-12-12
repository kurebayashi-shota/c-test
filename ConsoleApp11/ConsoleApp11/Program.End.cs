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

    static void End(string addressPath, List<Person> persons ,string path)
    {
        Console.WriteLine("終了します。");
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
            if (File.Exists(addressPath))
            {
                using (StreamWriter sw = new StreamWriter(addressPath,false))
                {
                    foreach (var person in persons)
                    {
                        Console.WriteLine($"{person.Name}を書き込み");
                        sw.WriteLine($"{person.Name},{person.Phone},{person.Email}");
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("ファイル作成に失敗しました。", e.ToString());
        }
        Console.WriteLine("書き込みが完了しました");
    }
}