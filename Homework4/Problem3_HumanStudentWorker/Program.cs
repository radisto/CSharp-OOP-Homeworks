using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Student> studentList = new List<Student>();
        Student pesho = new Student("Peter", "Petrov", "123kkk5");
        studentList.Add(pesho);
        Student gosho = new Student("Georgi", "Georgiev", "763kmk1");
        studentList.Add(gosho);
        Student vanio = new Student("Ivan", "Ivanov", "163k3kl");
        studentList.Add(vanio);
        Student stefcho = new Student("Stefan", "Stefanov", "678akk8");
        studentList.Add(stefcho);
        Student marti = new Student("Martin", "Martinov", "936kak3");
        studentList.Add(marti);
        Student vasko = new Student("Vasil", "Vasilev", "22a33k9");
        studentList.Add(vasko);
        Student vladi = new Student("Vladimir", "Vladimirov", "3244kka");
        studentList.Add(vladi);
        Student bobi = new Student("Borislav", "Borislavov", "423kooj");
        studentList.Add(bobi);
        Student sasho = new Student("Aleksander", "Aleksandrov", "823kckj");
        studentList.Add(sasho);
        Student misho = new Student("Mihail", "Mihailov", "5x3k4kp");
        studentList.Add(misho);
        studentList = studentList.OrderBy(w => w.FacultyNumber).ToList();
        foreach (Student item in studentList)
        {
            item.Print();
        }

        List<Worker> workerList = new List<Worker>();
        Worker worker0 = new Worker("George", "Washington", 400, 7.5m);
        workerList.Add(worker0);
        Worker worker1 = new Worker("Thomas", "Jefferson", 380, 7);
        workerList.Add(worker1);
        Worker worker2 = new Worker("Abraham", "Lincoln", 375, 6.9m);
        workerList.Add(worker2);
        Worker worker3 = new Worker("Theodore", "Roosevelt", 420, 7.6m);
        workerList.Add(worker3);
        Worker worker4 = new Worker("John", "Kennedy", 455, 7.8m);
        workerList.Add(worker4);
        Worker worker5 = new Worker("Richard", "Nixon", 480, 7.2m);
        workerList.Add(worker5);
        Worker worker6 = new Worker("Ronald", "Reagan", 425, 7.25m);
        workerList.Add(worker6);
        Worker worker7 = new Worker("Bill", "Clinton", 410, 6.7m);
        workerList.Add(worker7);
        Worker worker8 = new Worker("George", "Bush", 440, 8);
        workerList.Add(worker8);
        Worker worker9 = new Worker("Barack", "Obama", 500, 6.5m);
        workerList.Add(worker9);
        workerList = workerList.OrderByDescending(w => w.MoneyPerHour).ToList();
        foreach (Worker item in workerList)
        {
            item.Print();
        }

        List<Human> humanList = new List<Human>();
        humanList.AddRange(studentList);
        humanList.AddRange(workerList);
        humanList = humanList.OrderBy(w => w.FirstName).ThenBy(x => x.LastName).ToList();

        foreach (Human item in humanList)
        {
            item.Print();
        }
    }
}