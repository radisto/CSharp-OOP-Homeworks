class Employee : IEmployee
{
    public string Id { get; private set; }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public decimal Salary { get; private set; }

    public Department Department { get; private set; }

    public Employee(string id, string firstName, string lastName, decimal salary, Department department)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Salary = salary;
        this.Department = department;
    }

    public override string ToString()
    {
        return string.Format("ID: {0}\nFirst name: {1}\nLast name: {2}\nSalary: ${3:0.00}\nDepartment: {4}\n",
            this.Id, this.FirstName, this.LastName, this.Salary, this.Department);
    }
}