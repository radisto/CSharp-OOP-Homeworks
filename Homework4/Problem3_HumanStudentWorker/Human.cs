using System;

class Human
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public void Print()
    {
        Console.WriteLine("Name: {0} {1}", this.FirstName, this.LastName);
    }
}