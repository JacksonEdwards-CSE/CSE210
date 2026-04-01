
class Program
{
    
    public static void Main(string[] args)
    {

        // Questionmark Operator

        // int x = 10;

        // string name = (x > 10) ? "Bob" : "Betty";

        // Console.WriteLine(name);

        // string? nameTwo = null;

        // int? length = nameTwo?.Length;

        // Console.WriteLine(length);

        // Overloading Operators

        Console.Clear();

        Vector2D vector_1 = new Vector2D(10, 11);
        Vector2D vector_2 = new Vector2D(5, 5);
        
        Console.WriteLine(vector_1.DisplayVectorString());
        Console.WriteLine(vector_2.DisplayVectorString());

        Vector2D vector_3 = vector_1 - vector_2;

        Console.WriteLine(vector_3.DisplayVectorString());

        if (vector_1 != vector_2)
        {
            Console.WriteLine("They are not equal");
        }
    }
}