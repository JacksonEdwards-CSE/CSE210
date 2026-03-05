
class Menu
{
    public Journal _journal = new Journal();
    public int _userChoice;

    public int ProcessMenu()
    {
            do
            {
                Console.Clear();
                Console.WriteLine("Please Select One Of The Following:\n1. Write an Entry\n2. Display Journal\n3. Load Journal\n4. Save Journal\n5. Quit\n");
                Console.WriteLine("Enter Your Choice:");
            
                _userChoice = int.Parse(Console.ReadLine());
            
            }while(_userChoice < 1 || _userChoice > 5);

            Console.WriteLine();

            return _userChoice;
    }

    public void WriteEntry()
    {
        _journal.WriteEntry();
        _journal.AppendEntry();
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