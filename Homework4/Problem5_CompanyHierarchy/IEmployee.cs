﻿interface IEmployee : IPerson
{
    decimal Salary { get; }

    Department Department { get; }
}