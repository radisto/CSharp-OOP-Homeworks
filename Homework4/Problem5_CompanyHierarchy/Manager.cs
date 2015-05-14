using System.Collections.Generic;

class Manager : IManager
{
    public string Id { get; private set; }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public List<Employee> Employees { get; private set; }

    public Manager(string id, string firstName, string lastName, List<Employee> employees)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Employees = employees;
    }
}