namespace javaToCSharp;

public class Teacher : Person, ITalkable
{    
    public Teacher(int age, string name) : base(name) => Age = age;

    public int Age { get; set; }

    public string Talk() => "Don't forget to do the assigned reading";
    
    public string GetName() => Name;
}