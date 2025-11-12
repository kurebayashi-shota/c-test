using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            question1();
            question2();
            question3();
            question4();
            question5();
            //question6();
            question7();
            question8();
            question9();
            question10();
        }
        class Dog
        {
            private string mName = "";    // 名前
            private int mAge;    // 年齢
            private string mVariety = "";    // 品種

            public string Name
            {
                get { return mName; }
                set { mName = value; }
            }
            public int Age
            {
                get { return mAge; }
                set { mAge = value; }
            }
            public string Variety
            {
                get { return mVariety; }
                set { mVariety = value; }
            }

            public void ShowProfile()
            {
                if (mVariety == "") { } else { Console.WriteLine(mVariety); }
                Console.WriteLine(mName);
                if (mAge > 0) Console.WriteLine(mAge);
            }

            public Dog(string mVariety)
            {
                this.mVariety = mVariety;
            }
            public Dog(){}
        }
        class CoinCase
        {
            private int Type;
            private int Count = 0;
            public int pType
            {
                get { return Type; }
                set { pType = Type; }
            }
            public CoinCase(int type)
            {
                this.Type = type;
            }
            public void AddCoins(int type, int count)
            {
                Count = Count + count;
            }
            public int GetCount(int type)
            {
                return Count;
            }
            public int GetAmount()
            {
                return Count*Type;
            }
        }
        //class Animal
        //{
        //    public string Name = "";    // 名前
        //    public int Age = 0;         // 年齢

        //    public void ShowProfile()
        //    {
        //        Console.WriteLine($"{Name},{Age}歳");
        //    }
        //}
        class Animal
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
            public Animal() { }
            public virtual void Speak()
            {
                Console.WriteLine("......");
            }
        }
        class Cat : Animal
        {
            public void Sleep()
            {
                Console.WriteLine("スースー");
            }
            public Cat() { }
            public Cat(string name, int age):base(name,age){}
            public override void Speak()
            {
                Console.WriteLine("ニャー");
            }
        }
        class Horse : Animal
        {
            public void Run()
            {
                Console.WriteLine("トコトコ");
            }
            public Horse(string name, int age) : base(name, age) { }
            public override void Speak()
            {
                Console.WriteLine("ヒヒーン");
            }
        }
        static void question1()
        {
            Console.WriteLine("2.7.1.問題7-1のコンソール出力");
            Dog dog = new Dog();
            dog.Name = "danny";
            dog.ShowProfile();
            Console.WriteLine("");
        }
        static void question2()
        {
            Console.WriteLine("2.7.2.問題7-2のコンソール出力");
            Dog dog = new Dog();
            dog.Name = "danny";
            dog.Age = 2;
            dog.ShowProfile();
            Console.WriteLine("");
        }
        static void question3()
        {
            Console.WriteLine("2.7.3.問題7-3のコンソール出力");
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            dog1.Name = "danny";
            dog2.Name = "Sophie";
            dog1.Age = 2;
            dog2.Age = 5;
            dog1.ShowProfile();
            dog2.ShowProfile();
            Console.WriteLine("");
        }
        static void question4()
        {
            Console.WriteLine("2.7.4.問題7-4のコンソール出力");
            Dog dog = new Dog("ドーベルマン");
            dog.Name = "danny";
            dog.Age = 2;
            dog.ShowProfile();
            Console.WriteLine("");
        }
        static void question5()
        {
            Console.WriteLine("2.7.5.問題7-5のコンソール出力");
            CoinCase coin500 = new CoinCase(500);
            CoinCase coin100 = new CoinCase(100);
            CoinCase coin50 = new CoinCase(50);
            CoinCase coin10 = new CoinCase(10);
            CoinCase coin5 = new CoinCase(5);
            CoinCase coin1 = new CoinCase(1);
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i}番目の金種を入力して下さい");
                Console.WriteLine($"例:{coin500.pType}=\\{coin500.pType},{coin100.pType}=\\{coin100.pType},{coin50.pType}=\\{coin50.pType},{coin10.pType}=\\{coin10.pType},{coin5.pType}=\\{coin5.pType},{coin1.pType}=\\{coin1.pType}");
                int type = int.Parse(Console.ReadLine());
                Console.WriteLine($"\\{type}の枚数を入力してください");
                int count = int.Parse(Console.ReadLine());
                switch (type)
                {
                    case 500: coin500.AddCoins(500,count);break;
                    case 100: coin100.AddCoins(100, count); break;
                    case 50: coin50.AddCoins(50, count); break;
                    case 10: coin10.AddCoins(10, count); break;
                    case 5: coin5.AddCoins(5, count); break;
                    case 1: coin1.AddCoins(1, count); break;
                    default: Console.WriteLine("無視します");break;
                }
            }
            Console.WriteLine
            (
                $"\\{coin500.pType}:{coin500.GetCount(500)}枚," +
                $"\\{coin100.pType}:{coin100.GetCount(100)}枚," +
                $"\\{coin50.pType}:{coin50.GetCount(50)}枚," +
                $"\\{coin10.pType}:{coin10.GetCount(10)}枚," +
                $"\\{coin5.pType}:{coin5.GetCount(5)}枚," +
                $"\\{coin1.pType}:{coin1.GetCount(1)}枚,"
            );
            int amount = coin500.GetAmount()
                        +coin100.GetAmount()
                        +coin50.GetAmount()
                        +coin10.GetAmount()
                        +coin5.GetAmount()
                        +coin1.GetAmount();
            Console.WriteLine
            (
                $"総額:\\{amount}"
            );

            Console.WriteLine("");
        }
        //static void question6()
        //{
        //    Console.WriteLine("2.7.6.問題7-6のコンソール出力");
        //    Cat cat = new Cat();
        //    cat.Name = "tom";
        //    cat.Age = 3;
        //    cat.ShowProfile();
        //    cat.Sleep();
        //    Console.WriteLine("");
        //}
        static void question7()
        {
            Console.WriteLine("2.7.7.問題7-7のコンソール出力");
            Cat cat = new Cat("tom",3);
            cat.ShowProfile();
            cat.Sleep();
            Console.WriteLine("");
        }
        static void question8()
        {
            Console.WriteLine("2.7.8.問題7-8のコンソール出力");
            Cat cat = new Cat("tom", 3);
            cat.ShowProfile();
            cat.Sleep();
            Horse house = new Horse("マキバオー", 4);
            house.ShowProfile();
            house.Run();
            Console.WriteLine("");
        }
        static void question9()
        {
            Console.WriteLine("2.7.9.問題7-9のコンソール出力");
            Cat cat = new Cat("tom", 3);
            cat.ShowProfile();
            cat.Speak();
            Horse house = new Horse("マキバオー", 4);
            house.ShowProfile();
            house.Speak();
            Console.WriteLine("");
        }
        static void question10()
        {
            Console.WriteLine("2.7.10.問題7-10のコンソール出力");
            Animal [] array = new Animal [4];
            for(int i = 0; i < array.Length; i++)
            {
                if (i%2 ==0)
                {
                    array[i] = new Cat("tom", 3);
                    array[i].ShowProfile();
                    array[i].Speak();
                }
                else
                {
                    array[i] = new Horse("マキバオー", 4);
                    array[i].ShowProfile();
                    array[i].Speak();
                }
            }
            Console.WriteLine("");
        }
    }
}