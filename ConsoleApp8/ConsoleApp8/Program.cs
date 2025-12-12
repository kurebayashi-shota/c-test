using System;

class Program
{
    static void Main()
    {
        question1();
        question2();
        question3();
        question4();
        question5();
        question6();
        question7();
        question8();
        question9();
    }
    interface IPlayable
    {
        void Play();
    }
    abstract class Animal
    {
        public string Name { get; private set; }    // 名前
        public int Age { get; private set; }        // 年齢
        public virtual string Species { get; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            Species = "Animal";
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
        public virtual void Walk()
        {
            Console.WriteLine("トコトコ歩く");
        }
        public void Wark(int steps)
        {
            Console.WriteLine($"{steps}歩歩いた");
        }
        public string ShowKind()
        {
            return "動物です";
        }
        protected abstract void MoveCore();
        public void DoDaily()
        {
            ShowProfile();
            Speak();
            MoveCore();
        }
    }
    class Horse : Animal, IPlayable
    {
        public override string Species { get; }
        public Horse(string name, int age) : base(name,age)
        {
            Species = "Horse";
        }
        public override void Speak()
        {
            Console.WriteLine("ヒヒーン");
        }
        public override void Walk()
        {
            Console.WriteLine("パカパカ");
        }
        protected override void MoveCore()
        {
            Console.WriteLine("人を乗せられる");
        }
        void IPlayable.Play()
        {
            Console.WriteLine("ボールで遊ぶ");
        }
        public void Run()
        {
            Console.WriteLine("トコトコ");
        }

    }
    class Cat : Animal, IPlayable
    {
        public override string Species { get; }
        public Cat(string name, int age) : base(name, age)
        {
            Species = "Cat";
        }
        public override void Speak()
        {
            Console.WriteLine("ニャー");
        }
        public new string ShowKind()
        {
            return "猫です";
        }
        protected override void MoveCore()
        {
            Console.WriteLine("静かに歩く");
        }
        void IPlayable.Play()
        {
            Console.WriteLine("じゃれる");
        }
    }
    class Bird : Animal, IPlayable
    {
        public override string Species { get; }
        public Bird(string name, int age) : base(name, age)
        {
            Species = "Bird";
        }
        public override void Speak()
        {
            Console.WriteLine("ピヨピヨ");
        }
        public string Fly()
        {
            return "飛びました";
        }
        protected override void MoveCore()
        {
            Console.WriteLine("飛んで移動する");
        }
        void IPlayable.Play()
        {
            Console.WriteLine("羽ばたいて遊ぶ");
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
        List<Animal> animals = new List<Animal>();
        Horse horse = new Horse("マキバオー", 4);
        Cat cat = new Cat("トム", 2);
        Bird bird = new Bird("トゥイーティー", 10);
        {
            animals.Add(horse);
            animals.Add(cat);
            animals.Add(bird);
        };
        foreach(Animal animal in animals)
        {
            animal.Speak();
            if(animal is Bird)
            {
                Console.WriteLine(bird.Fly());
            }
        }
        Console.WriteLine();
    }
    static void question3()
    {
        Console.WriteLine("2.8.3.問題8-3のコンソール出力");
        Horse horse = new Horse("マキバオー", 4);
        horse.Walk();
        horse.Wark(3);
        Console.WriteLine();
    }
    static void question4()
    {
        Console.WriteLine("2.8.4.問題8-4のコンソール出力");
        List<Animal> animals = new List<Animal>();
        Horse horse = new Horse("マキバオー", 4);
        Cat cat = new Cat("トム", 2);
        Bird bird = new Bird("トゥイーティー", 10);
        {
            animals.Add(horse);
            animals.Add(cat);
            animals.Add(bird);
        }
        ;
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.Species);
            animal.ShowProfile();
        }
        Console.WriteLine();
    }
    static void question5()
    {
        Console.WriteLine("2.8.5.問題8-5のコンソール出力");
        Animal Cat = new Cat("トム", 2);
        Cat cat = new Cat("トム", 2);
        Console.WriteLine(Cat.ShowKind());
        Console.WriteLine(cat.ShowKind());
        Console.WriteLine();
    }
    static void question6()
    {
        Console.WriteLine("2.8.6.問題8-6のコンソール出力");
        Animal animal = new Horse("トム", 2);

        //明示的キャストで Run() を呼ぶ。
        Horse a = (Horse)animal;
        try{ a.Run(); }
        catch
        {
            //（失敗時の挙動）をコメントでまとめる。
            Console.WriteLine("明示的キャストで失敗しました。");
        }

        //as 演算子（a as Horse）と null チェックで Run() を呼ぶ。
        animal = a as Horse;
        if (animal == null)
        {
            //（失敗時の挙動）をコメントでまとめる。
            Console.WriteLine("as 演算子で失敗しました。");
        }
        else
        {
            a.Run();
        }

        //パターンマッチング（if (a is Horse d) ）で Run() を呼ぶ。
        if (a is Horse d)
        {
            Animal horse = (Animal)a;

            a.Run();
        }
        else
        {
            //（失敗時の挙動）をコメントでまとめる。
            Console.WriteLine("パターンマッチングで失敗しました。");
        }

        Console.WriteLine();
    }
    static void question7()
    {
        Console.WriteLine("2.8.7.問題8-7のコンソール出力");
        List<Animal> animals = new List<Animal>();
        Horse horse = new Horse("マキバオー", 4);
        Cat cat = new Cat("トム", 2);
        Bird bird = new Bird("トゥイーティー", 10);
        {
            animals.Add(horse);
            animals.Add(cat);
            animals.Add(bird);
        }
        ;
        foreach (Animal animal in animals)
        {
            animal.DoDaily();
        }
        Console.WriteLine();
    }
    static void question8()
    {
        Console.WriteLine("2.8.8.問題8-8のコンソール出力");
        List<IPlayable> animals = new List<IPlayable>();
        Horse horse = new Horse("マキバオー", 4);
        Cat cat = new Cat("トム", 2);
        Bird bird = new Bird("トゥイーティー", 10);
        {
            animals.Add(horse);
            animals.Add(cat);
            animals.Add(bird);
        }
        foreach (IPlayable animal in animals)
        {
            animal.Play();
        }
        Console.WriteLine();
    }
    static void question9()
    {
        Console.WriteLine("2.8.9.問題8-9のコンソール出力");
        List<Animal> animals = new List<Animal>();
        int horseCount = 0;
        int catCount = 0;
        int birdCount = 0;
        Console.WriteLine($"何匹入力しますか?");
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{i + 1}匹目の動物の種類、名前、年齢を半角スペース区切りで入力してください");
            Console.WriteLine("(例：Horse ポチ 3 / Cat ミケ 2 / Bird ピー 1)");
            string input = Console.ReadLine();
            string[] values = input.Split(" ");
            switch (values[0])
            {
                case "Horse": animals.Add(new Horse(values[1], int.Parse(values[2]))); horseCount++; break;
                case "Cat": animals.Add(new Cat(values[1], int.Parse(values[2]))); catCount++; break;
                case "Bird": animals.Add(new Bird(values[1], int.Parse(values[2]))); birdCount++; break;
            }
        }
        foreach (Animal animal in animals)
        {
            animal.Speak();
            animal.ShowProfile();
            if (animal is IPlayable a){ a.Play(); }
            else{ continue; }

        }
        Console.WriteLine($"集計-Horse:{horseCount}頭,Cat:{catCount}頭,Bird:{birdCount}羽");

        Console.WriteLine();
    }
}