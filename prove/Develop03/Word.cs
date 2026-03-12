
class Word
{
    
    private string _word;

    public Word()
    {
        _word = "";
    }

    public Word(string word)
    {
        _word = word;
    }

    public string GetWord()
    {
        return _word;
    }

    public string GetHiddenWord()
    {

        int underscoreCount = 0;
        char underscore = '_';

        foreach (char letter in _word)
        {
            underscoreCount += 1;
        }

        string hiddenWord = new string (underscore, underscoreCount);

        return hiddenWord;
    }
}