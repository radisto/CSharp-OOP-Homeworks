using System;

class Worker : Human
{
    public decimal WeekSalary { get; set; }

    public decimal WorkHoursPerDay { get; set; }

    public decimal MoneyPerHour { get; set; }

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay, decimal moneyPerHour = 0m)
        :base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
        this.MoneyPerHour = this.WeekSalary / 5 / this.WorkHoursPerDay;
    }

    public new void Print()
    {
        Console.WriteLine("$/hour: {0:0.00} Name: {1} {2}", this.MoneyPerHour, this.FirstName, this.LastName);
    }
}