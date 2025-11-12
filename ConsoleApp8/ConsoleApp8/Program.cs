using System;

class Program
{
    static void Main()
    {
        question1();
    }
    abstract class Animal
    {
        public string Name { get; private set; }    // 名前
        public int Age { get; private set; }        // 年齢

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ShowProfile()
        {
            Console.WriteLine($"{Name},{Age}歳");
        }
        public override string ToString()
        {
            return $"[種別] 名前: {Name}, 年齢: {Age}";
        }
        public abstract void Speak();

    }
    class Horse : Animal
    {
        public Horse(string name, int age) : base(name,age) { }
        public override void Speak()
        {
            Console.WriteLine("ヒヒーン");
        }
    }
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }
        public override void Speak()
        {
            Console.WriteLine("ニャー");
        }
    }
    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) { }
        public override void Speak()
        {
            Console.WriteLine("ピヨピヨ");
        }
        public string Fly()
        {
            return "飛びました";
        }
    }
    static void question1()
    {
        Console.WriteLine("2.8.1.問題8-1のコンソール出力");
        Animal horse = new Horse("マキバオー", 4);        
        Console.WriteLine(horse);
        Animal cat = new Cat("tom", 2);
        Console.WriteLine(cat);
        Console.WriteLine();
    }
    static void question2()
    {
        Console.WriteLine("2.8.2.問題8-2のコンソール出力");
        var list = new List<Animal>();
        for(int i=1;i < 5; i++)
        {
            Animal horse = new Horse("a",1);
        }
        Animal horse = new Horse("マキバオー", 4);
        horse.Speak();
        Animal cat = new Cat("tom", 2);
        cat.Speak();
        Console.WriteLine();
    }
}