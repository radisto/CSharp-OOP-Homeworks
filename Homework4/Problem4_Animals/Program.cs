using System;

class Program
{
    static void Main()
    {
        Tomcat garfield = new Tomcat("Garfield", 3);
        Console.WriteLine(garfield);
        Dog rex = new Dog("Rex", 5, Gender.male);
        Console.WriteLine(rex);
        Frog kermit = new Frog("Kermit the Frog", 8, Gender.male);
        Console.WriteLine(kermit);
        Console.WriteLine("press 1 to play cat sound, 2 - dog sound, 3 - frog sound");
        int sound = int.Parse(Console.ReadLine());
        switch (sound)
        {
            case 1:
                garfield.produceSound();
                break;
            case 2:
                rex.produceSound();
                break;
            case 3:
                kermit.produceSound();
                break;
        }
    }
}