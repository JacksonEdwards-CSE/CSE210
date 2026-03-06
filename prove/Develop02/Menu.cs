
class Menu
{
    public Journal _journal = new Journal();
    public int _userChoice;

    public int ProcessMenu()
    {
            do
            {
                Console.Clear();
                Console.WriteLine("Please Select One Of The Following:\n1. Write an Entry\n2. Define Your Emotion\n3. Display Journal\n4. Load Journal\n5. Save Journal\n6. Quit\n");
                Console.WriteLine("Enter Your Choice:");
            
                _userChoice = int.Parse(Console.ReadLine());
            
            }while(_userChoice < 1 || _userChoice > 6);

            Console.WriteLine();

            return _userChoice;
    }

    public void WriteEntry()
    {
        _journal.WriteEntry();
        _journal.AppendEntry();
    }

    public void DefineEmotion()
    {
        _journal.DefineEmotion();
        _journal.AppendEmotion();
    }

    public void DisplayJournal()
    {
        _journal.DisplayJournal();
    }

    public void ReadFile()
    {
        _journal.ReadFile();
    }

    public void WriteFile()
    {
        _journal.WriteFile();
    }
}