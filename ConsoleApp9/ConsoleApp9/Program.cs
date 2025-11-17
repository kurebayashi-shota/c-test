using System;
using System.Collections.Generic;
namespace ConsoleApp9
{
    namespace School
    {
        class Teacher
        {
            string name = "鵺野鳴介";
        }
        class Student
        {
            string name = "立野広";
        }
    };
    static void Question9()

    {
        ConsoleApp9.School.Teacher teacher = ConsoleApp9.School.Teacher();
    }

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
        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Student(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void ShowProfile()
            {
                Console.WriteLine(Name + " " + Age);
            }
        }
        enum Season { Spring, Summer, Autumn, Winter }
        public struct Point
        {
            public int X;
            public int Y;
            public void ShowPoint()
            {
                Console.WriteLine(X + " " + Y);
            }
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
        class Counter
        {
            public static int count = 0;
            public Counter()
            {
                count++;
            }
            public static void GetCount()
            {
                Console.WriteLine(count);
            }
        }
        static void question1()
        {
            Console.WriteLine("3.1.1.問題1-1のコンソール出力");
            Student student = new Student("taro", 5);
            student.ShowProfile();
            Console.WriteLine();
        }
        static void question2()
        {
            Console.WriteLine("3.2.1.問題2-1のコンソール出力");
            Season season = (Season)1;
            Console.WriteLine(season);
            Console.WriteLine();
        }
        static void question3()
        {
            Console.WriteLine("3.2.2.問題2-2のコンソール出力");
            Console.WriteLine("0:Spring, 1:Summer, 2:Autumn, 3:Winter");
            Season season = (Season)int.Parse(Console.ReadLine());
            Console.WriteLine(season);
            Console.WriteLine();
        }
        static void question4()
        {
            Console.WriteLine("3.3.1.問題3-1のコンソール出力");
            Point point = new Point(5, 10);
            point.ShowPoint();
            Console.WriteLine();
        }
        static void question5()
        {
            Console.WriteLine("3.4.1.問題4-1のコンソール出力");

            Counter counter1 = new Counter();
            Counter counter2 = new Counter();
            Counter counter3 = new Counter();
            Counter.GetCount();
            Console.WriteLine();
        }
        static void question6()
        {
            Console.WriteLine("3.5.1.問題5-1のコンソール出力");
            List<int> nums = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"整数{i + 1}を入力してください");
                nums.Add(int.Parse(Console.ReadLine()));
            }
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
        }
        static void question7()
        {
            Console.WriteLine("3.5.2.問題5-2のコンソール出力");
            List<string> names = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"名前{i + 1}を入力してください");
                names.Add(Console.ReadLine());
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
        }
        static void question8()
        {
            Console.WriteLine("3.6.1.問題6-1のコンソール出力");
            Dictionary<string, int> people = new Dictionary<string, int>();
            people.Add("一郎", 5);
            people.Add("次郎", 4);
            people.Add("三郎", 3);

            foreach (KeyValuePair<string, int> person in people)
            {
                Console.WriteLine($"{person.Key}さんは{person.Value}才です。");
            }

            Console.WriteLine();
        }
        static void question9()
        {
            Console.WriteLine("3.7.1.問題7-1のコンソール出力");
            //ConsoleApp9.Program.Teacher teacher = new ConsoleApp9.Program.Teacher();

            Console.WriteLine();
        }
    }
}