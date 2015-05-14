using System;
using System.IO;
using System.Media;
using System.Reflection;

class Frog : Animal, ISound
{
    public Frog(string name, int age, Gender gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public void produceSound()
    {
        Assembly ass = Assembly.GetExecutingAssembly();
        string root = System.IO.Path.GetDirectoryName(ass.Location);
        var frogPath = Path.Combine(root, "frog.wav");
        var frogSound = new SoundPlayer(frogPath);
        frogSound.PlaySync();
    }
}