using System;

abstract class Animal
{
    public string Name { get; set; }

    public int Age { get; set; }

    public Gender Gender { get; set; }

    public override string ToString()
    {
        return string.Format("Name: {0}; Age: {1}; Gender: {2}", this.Name, this.Age, this.Gender);
    }
}