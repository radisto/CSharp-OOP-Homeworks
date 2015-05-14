using System;
using System.IO;
using System.Media;
using System.Reflection;

class Dog : Animal, ISound
{
    public Dog(string name, int age, Gender gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public void produceSound()
    {
        Assembly ass = Assembly.GetExecutingAssembly();
        string root = System.IO.Path.GetDirectoryName(ass.Location);
        var dogPath = Path.Combine(root, "dog.wav");
        var dogSound = new SoundPlayer(dogPath);
        dogSound.PlaySync();
    }
}