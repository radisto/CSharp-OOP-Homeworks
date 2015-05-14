using System;

class Person
{
    private string name;
    private int age;
    private string email;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Invalid name!");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new Exception("Invalid age!");
            }
            this.age = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (value != null && !value.Contains("@"))
            {
                throw new Exception("Invalid email!");
            }
            this.email = value;
        }
    }

    public Person(string name, int age, string email = null)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public override string ToString()
    {
        string result = string.Format("Name: {0}; Age: {1}", this.Name, this.Age);
        if (this.Email != null)
        {
            result += "; Email: " + this.Email;
        }
        return result;
    }
}

class PersonTest
{
    static void Main()
    {
        Person pesho = new Person("Pesho", 45);
        Console.WriteLine(pesho);
        Person gosho = new Person("Gosho", 64, "georgi50@aol.com");
        Console.WriteLine(gosho);
    }
}
