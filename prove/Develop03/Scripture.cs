
class Scripture
{
    
    string[] _scriptureList;

    public Scripture()
    {
        _scriptureList = ["In", "the", "beginning", "God", "created", "the", "heavens", "and", "the", "earth"];
    }

    public Scripture(string scripture)
    {
        _scriptureList = StringToList(scripture);
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
}