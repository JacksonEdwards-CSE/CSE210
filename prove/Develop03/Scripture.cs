
class Scripture
{
    
    string[] _scriptureList;

    List<int> _scriptureLengthList;

    public Scripture()
    {
        _scriptureList = ["In", "the", "beginning", "God", "created", "the", "heavens", "and", "the", "earth."];

        _scriptureLengthList = GetScriptureLength();
    }

    public Scripture(string scripture)
    {
        _scriptureList = StringToList(scripture);
        _scriptureLengthList = GetScriptureLength();
    }

    private string[] StringToList(string scripture)
    {
        char splitCharacter = ' ';

        string[] scriptureList = scripture.Split(splitCharacter);
        return scriptureList;
    }

    public void GetScripture()
    {
        foreach (string word in _scriptureList)
        {
            Console.Write($"{word} ");   
        }
        Console.WriteLine();
    }

    public void HideWord()
    {
        Random random = new Random();

        if (_scriptureLengthList.Count > 0)
        {
            
        int scriptureLengthIndex = random.Next(_scriptureLengthList.Count);

        int hiddenWordIndex = _scriptureLengthList[scriptureLengthIndex];

        _scriptureLengthList.RemoveAt(scriptureLengthIndex);

        Word getHiddenWord = new Word(_scriptureList[hiddenWordIndex]);

        string hiddenWord = getHiddenWord.GetHiddenWord();

        _scriptureList[hiddenWordIndex] = hiddenWord;
        
        }

    }

    private List<int> GetScriptureLength()
    {
        int i = 0;
        List<int> scriptureLengthList = new List<int>();

        foreach (string word in _scriptureList)
        {
            scriptureLengthList.Add(i);
            i += 1;
        }

        return scriptureLengthList;

    }
}