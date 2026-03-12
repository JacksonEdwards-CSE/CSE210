using System;

class Program
{
    static void Main(string[] args)
    {
        Word word = new Word("Bob");

        Console.WriteLine(word.GetWord());

        Console.WriteLine(word.GetHiddenWord());


        Reference defaultReference = new Reference();
        Console.WriteLine(defaultReference.GetReference());

        Reference secondReference = new Reference("John", 3, 5, 9);
        Console.WriteLine(secondReference.GetReference());

        Reference thirdReference = new Reference("Isaiah", 1, 18);
        Console.WriteLine(thirdReference.GetReference());

        Scripture defaultScripture = new Scripture();
        defaultScripture.GetScripture();

        Scripture secondScripture = new Scripture("And he dwelt in a tent.");
        secondScripture.GetScripture();

    }
}