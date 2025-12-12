using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Channels;
namespace VendingMachine;
public partial class Program
{
    static int LoadSales(string salesPath)
    {
        using (StreamReader sr = new StreamReader(salesPath))
        {
            return int.Parse(sr.ReadLine());
        }
    }
    static List<Item> LoadItems(string itemPath)
    {
        var list = new List<Item>();
        using (StreamReader sr = new StreamReader(itemPath))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] values = line.Split(',');
                list.Add(new Item(int.Parse(values[0]), values[1], int.Parse(values[2]), int.Parse(values[3])));
            }
        }
        return list;
    }
    static List<CoinCase> LoadChange(string changePath)
    {
        List<CoinCase> coinCase = new List<CoinCase>();

        using (StreamReader sr = new StreamReader(changePath))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] values = line.Split(',');
                coinCase.Add(new CoinCase(int.Parse(values[0]), int.Parse(values[1])));
            }
        }
        return coinCase;
    }
    static void WriteData(string path, string salesPath, string itemPath,string changePath, int sales, List<Item> list, List<CoinCase> coinCase)
    {
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
            if (!File.Exists(salesPath))
            {
                using (FileStream fs = File.Create($"{salesPath}"));
                using (FileStream fs = File.Create($"{itemPath}"));
                using (FileStream fs = File.Create($"{changePath}"));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("ファイル作成に失敗しました。", e.ToString());
        }
        try
        {
            using (StreamWriter sw = new StreamWriter(salesPath, false))
            {
                sw.WriteLine(sales);
            }
            using (StreamWriter sw = new StreamWriter(itemPath, false))
            {
                foreach(var item in list)
                {
                    sw.WriteLine($"{item.Id},{item.Name},{item.Price},{item.Count}");
                }
            }
            using (StreamWriter sw = new StreamWriter(changePath, false))
            {
                foreach (var item in coinCase)
                {
                    sw.WriteLine($"{item.pType},{item.pCount}");
                }
            }
            Console.WriteLine("書き込みが完了しました");
        }
        catch{ Console.WriteLine("書き込みに失敗しました"); }
    }
}