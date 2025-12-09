using System;
namespace VendingMachine;
class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public int Count { get; set; }

    public Item(int id, string name, int price, int count)
    {
        Id = id; Name = name;
        Name = name;
        Price = price;
        Count = count;
    }
}