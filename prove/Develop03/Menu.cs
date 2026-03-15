
class Menu
{

    int _choice;

    List<string> _bookList = new List<string>();
    List<int> _chapterList = new List<int>();
    List<int> _startVerseList = new List<int>();
    List<int> _endVerseList = new List<int>();
    List<string> _scriptureList = new List<string>();

    public Menu()
    {
        _bookList = ["Isaiah", "1 Nephi", "Proverbs"];
        _chapterList = [1, 3, 3];
        _startVerseList = [18, 7, 5];
        _endVerseList = [-1, -1, 6];
        _scriptureList = ["Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool.",
        "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."];
    }

    public void ProcessMenu()
    {

        Console.Clear();

        Console.WriteLine("Select a scripture to memorize:\n1) Isaiah 1:18\n2) 1 Nephi 3:7\n3) Proverbs 3:5-6");

        _choice = int.Parse(Console.ReadLine());
        
    }

    public void RunProgram()
    {
        string prompt;
        Reference Reference = new Reference(_bookList[_choice - 1], _chapterList[_choice - 1], _startVerseList[_choice - 1], _endVerseList[_choice - 1]);
        Scripture Scripture = new Scripture(_scriptureList[_choice - 1]);

        Console.Clear();

        Console.WriteLine(Reference.GetReference());

        Scripture.GetScripture();
        
        prompt = Console.ReadLine();

        do
        {
        
        Console.Clear();

        Console.WriteLine(Reference.GetReference());

        Scripture.HideWord();

        Scripture.HideWord();

        Scripture.HideWord();

        Scripture.GetScripture();
        
        prompt = Console.ReadLine();

        }while (prompt != "q");
    }
}