
class Journal
{
    
    public List<string> _entries = new List<string>();

    public string _entry;

    public string _emotion;

    public void WriteEntry()
    {
        Entry entry = new Entry();

        entry.GetDate();
        entry.GetPrompt();

        entry.Response();

        _entry = $"{entry._dateTime} - {entry._prompt}\n{entry._response}";
    }

    public void AppendEntry()
    {
        _entries.Add($"{_entry}\n");
    }
    
    public void DefineEmotion()
    {
        Emotion emotion = new Emotion();

        emotion.GetDate();

        emotion.GetCategory();

        emotion.GetSpecific();

        emotion.GetExplanation();

        _emotion = $"{emotion._dateTime} - Today I felt {emotion._categoryName} but more specifically I felt {emotion._specificName} because {emotion._explanation}";
    }

    public void AppendEmotion()
    {
        _entries.Add($"{_emotion}\n");
    }

    public void DisplayJournal()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
        Console.ReadLine();
    }

    public void ReadFile()
    {
        Console.WriteLine("What is the name of your journal file?(Be sure to include\".txt\")");
        string filename = Console.ReadLine();

        string[] journalFile = System.IO.File.ReadAllLines(filename);

        foreach (string entry in journalFile)
        {
            _entries.Add(entry);
        }
    }

    public void WriteFile()
    {
        Console.WriteLine("What is the name of your journal file?(Be sure to include\".txt\")");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(string entry in _entries)
            {
                outputFile.WriteLine(entry);   
                Console.WriteLine();    
            }
        }
    }
}