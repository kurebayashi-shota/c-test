using System;
namespace ConsoleApp13;

class Program
{
    static void Main()
    {
        question1();
        question2();
    }
    abstract class Employee
    {
        public string Name { get; private set; }
        public decimal BaseSalary { get; private set; }
        public abstract decimal CalculateMonthlyPay();
        public Employee(string name, decimal baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }
    }

    class FullTimeEmployee: Employee
    {
        public override decimal CalculateMonthlyPay()
        {
            return BaseSalary;
        }
        public FullTimeEmployee(string name, decimal baseSalary) : base(name,baseSalary) { }
    }
    class PartTimeEmployee : Employee
    {
        decimal HourlyWage { get; }
        decimal WorkedHours { get; }
        public override decimal CalculateMonthlyPay()
        {
            return HourlyWage * WorkedHours;
        }
        public PartTimeEmployee(string name, decimal baseSalary) : base(name, baseSalary) { }
    }
    static void question1()
    {
        Console.WriteLine("7.1.1.問題1-1のコンソール出力");
        List<Employee> employeeList = new List<Employee>()
        {
            new FullTimeEmployee("田中",30),
            new FullTimeEmployee("鈴木",50),
            new PartTimeEmployee("佐藤",20),
            new FullTimeEmployee("榑林",100),
            new PartTimeEmployee("平野",15),
        };
        foreach(var employee in employeeList)
        {
            Console.WriteLine($"名前:{employee.Name},月給:{employee.BaseSalary}");
        }

        Console.WriteLine();
    }
    static void question2()
    {
        Console.WriteLine("7.2.1.問題2-1のコンソール出力");
        List<Employee> employeeList = new List<Employee>()
        {
            new FullTimeEmployee("田中",30),
            new FullTimeEmployee("鈴木",50),
            new PartTimeEmployee("佐藤",20),
            new FullTimeEmployee("榑林",100),
            new PartTimeEmployee("平野",15),
        };
        //Employee に共通の表示メソッド ShowProfile()（氏名と種別を表示）を実装し、
        //CalculateMonthlyPay() は抽象のままにする。
        //プログラム：すべての Employee に対して ShowProfile() と CalculateMonthlyPay() を順に実行する。

        Console.WriteLine();
    }
}