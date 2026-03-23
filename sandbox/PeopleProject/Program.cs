
class Program
{

    public static void ProcessPerson(Person person)
    {
            Console.WriteLine(person.GetPersonInformation());
    }
    
    public static void Main()
    {

        Person myPerson = new Person("Jackson", "Edwards", 19, 155);
        Console.WriteLine(myPerson.GetPersonInformation());

        Doctor newDoctor = new Doctor("Stethescope", "John", "Doctor", 42, 195);
        Console.WriteLine(newDoctor.GetPersonInformation());

        Police newPolice = new Police("Gun", "John", "Police", 31, 225);
        Console.WriteLine(newPolice.GetPersonInformation());

        newPolice.SetWeight(newPolice.GetWeight() + 5);
        newPolice.SetAge(newPolice.GetAge() + 1);
        Console.WriteLine(newPolice.GetPersonInformation());

        List<Person> myPeople = new List<Person>();
        myPeople.Add(myPerson);
        myPeople.Add(newDoctor);
        myPeople.Add(newPolice);

        foreach (Person person in myPeople)
        {
            ProcessPerson(person);
        }
    }
}
