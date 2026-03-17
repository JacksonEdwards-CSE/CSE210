
class Program
{
    
    public static void Main()
    {

        Person myPerson = new Person("Jackson", "Edwards", 19, 155);
        Console.WriteLine(myPerson.GetPersonInformation());

        Doctor newDoctor = new Doctor("Stethescope", "John", "Doctor", 42, 195);
        Console.WriteLine(newDoctor.GetDoctorInformation());
    }
}
