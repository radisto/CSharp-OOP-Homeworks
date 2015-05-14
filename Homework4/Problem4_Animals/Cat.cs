using System;
using System.IO;
using System.Media;
using System.Reflection;

class Cat : Animal, ISound
{
    public Cat(string name, int age, Gender gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public void produceSound()
    {
        Assembly ass = Assembly.GetExecutingAssembly();
        string root = System.IO.Path.GetDirectoryName(ass.Location);
        var catPath = Path.Combine(root, "cat.wav");
        var catSound = new SoundPlayer(catPath);
        catSound.PlaySync();
    }
}
