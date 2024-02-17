namespace Generic_Linked_List;

class Program
{
    static void Main(string[] args)
    {
        var list = new LinkedList<Person>();
        list.Insert(new Person("1") {FirstName= "Bruno", LastName = "NotTelling"});
        list.Insert(new Person("6") {FirstName= "John", LastName = "Ulm"});
        list.Insert(new Person("2") {FirstName= "Nill", LastName = "Johnson"});
        list.Insert(new Person("3") {FirstName= "Brad", LastName = "Pitt"});
        list.Insert(new Person("4") {FirstName= "John", LastName = "Nilson"});
        list.Print();

        list.Delete(new Person("1") {FirstName = "Bruno", LastName = "NotTelling"});
        list.Print();
        foreach (var p in list.GetAll().Take(2)) {
            System.Console.WriteLine($"Yield: {p.ToString()}");
        }
        foreach (var p in list.GetWhere(person => person.FirstName == "John")) {
            System.Console.WriteLine($"Found by delegate: {p.ToString()}");
            
        }


    }
}
