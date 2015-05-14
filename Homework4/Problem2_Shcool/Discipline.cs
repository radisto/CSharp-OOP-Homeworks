using System.Collections.Generic;

class Discipline : Detail
{
    public string Name { get; private set; }

    public int NumberOfLectures { get; private set; }

    public List<Student> Students { get; private set; }

    public string Details { get; private set; }
}