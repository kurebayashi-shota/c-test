using System;
namespace VendingMachine;
class CoinCase
{
    private int Type;
    private int Count = 0;
    public int pType
    {
        get { return Type; }
        set { Type = value; }
    }
    public int pCount
    {
        get { return Count; }
        set { Count = value; }
    }
    public CoinCase(int type, int count)
    {
        this.Type = type;
        this.Count = count;
    }
    public void AddCoins(int type, int count)
    {
        Count = Count + count;
    }
    public int GetCount(int type)
    {
        return Count;
    }
}
