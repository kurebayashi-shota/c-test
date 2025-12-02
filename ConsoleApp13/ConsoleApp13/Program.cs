using System;
namespace ConsoleApp13;

class Program
{
    static void Main()
    {
        question1();
        question2();
        question3();
    }
    interface IOvertimeEligible
    {
        void AddOvertimeHours(int hours) { }
        int GetOvertimeHours() {  return 0; }
    }
    abstract class Employee
    {
        public string Name { get; private set; }
        public decimal BaseSalary { get; private set; }
        public abstract string EmploymentType { get; }
        public abstract decimal CalculateMonthlyPay();
        public void ShowProfile()
        {
            Console.WriteLine($"名前:{ Name}, 種別:{ EmploymentType}");
        }
        public Employee(string name, decimal baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }
    }

    class FullTimeEmployee: Employee
    {
        public override string EmploymentType => "正社員";
        public override decimal CalculateMonthlyPay()
        {
            return BaseSalary;
        }
        public FullTimeEmployee(string name, decimal baseSalary) : base(name,baseSalary) { }
    }
    class PartTimeEmployee : Employee
    {
        public override string EmploymentType => "アルバイト";
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
        foreach(var employee in employeeList)
        {
            employee.ShowProfile();
            employee.CalculateMonthlyPay();
        }

        Console.WriteLine();
    }
    static void question3()
    {
        Console.WriteLine("7.3.1.問題3-1のコンソール出力");
        List<Employee> employeeList = new List<Employee>()
        {
            new FullTimeEmployee("田中",30),
            new FullTimeEmployee("鈴木",50),
            new PartTimeEmployee("佐藤",20),
            new FullTimeEmployee("榑林",100),
            new PartTimeEmployee("平野",15),
        };
        //IOvertimeEligible インターフェイスを作成しなさい。
        //void AddOvertimeHours(int hours)（残業時間を加算）
        //int GetOvertimeHours() を定義
        //FullTimeEmployee は IOvertimeEligible を実装し、CalculateMonthlyPay() で 残業手当（例：OvertimeHours * (BaseSalary / 160) * 1.25）を加算する。
        //プログラム：
        //FullTimeEmployee に残業時間を加えてから月給を表示する。

        Console.WriteLine();
    }
}