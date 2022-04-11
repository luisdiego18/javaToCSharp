using javaToCSharp;

var OutFile = new FileOutput("animals.txt");
var InFile = new FileInput("animals.txt");

IList<ITalkable> zoo = new List<ITalkable>();

zoo.Add(new Dog(true, "Bean"));
zoo.Add(new Cat(9, "Charlie"));
zoo.Add(new Teacher(44, "Stacy Read"));

foreach (ITalkable item in zoo)
{
    Console.WriteLine($"{item.GetName()} says: {item.Talk()}");
    OutFile.WriteFile($"{item.GetName()} | {item.Talk()}");
}
