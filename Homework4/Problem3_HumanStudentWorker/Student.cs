using System;

class Student : Human
{
    private string facultyNumber;

    public string FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }
        private set
        {
            if (value.Length < 5 || value.Length > 10)
            {
                throw new ArgumentOutOfRangeException("Faulty number must be between 5 and 10 digits/letters long");
            }
            this.facultyNumber = value;
        }
    }

    public Student(string firstName, string lastName, string facultyNumber)
        :base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public new void Print()
    {
        Console.WriteLine("No: {0} Name: {1} {2}", this.FacultyNumber, this.FirstName, this.LastName);
    }
}