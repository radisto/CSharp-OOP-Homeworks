using System.Collections.Generic;

interface IManager : IPerson
{
    List<Employee> Employees { get; }
}