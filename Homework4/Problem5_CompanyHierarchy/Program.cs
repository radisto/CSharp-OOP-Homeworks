using System;

class Program
{
    static void Main()
    {
        Employee peter = new Employee("x5623", "Peter", "Robinson", 3200, Department.Accounting);
        Console.WriteLine(peter);
        Employee david = new Employee("j7981", "David", "Johnson", 1250, Department.Production);
        Console.WriteLine(david);
        Employee ben = new Employee("i7710", "Benjamin", "Smith", 1800, Department.Sales);
        Console.WriteLine(ben);
        Employee will = new Employee("g9002", "William", "Miller", 2600, Department.Marketing);
        Console.WriteLine(will);
    }
}