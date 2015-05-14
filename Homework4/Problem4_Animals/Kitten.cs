using System;

class Kitten : Cat
{
    public Kitten(string name, int age, Gender gender = Gender.female)
        : base(name, age, gender)
    {
        
    }
}