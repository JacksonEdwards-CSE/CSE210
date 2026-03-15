
class Reference
{
    string _book;
    int _chapter;
    int _startVerse;
    int _endVerse;

    public Reference()
    {
        _book = "Genesis";

        _chapter = 1;

        _startVerse = 1;

        _endVerse = -1;
    }

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;

        _chapter = chapter;

        _startVerse = startVerse;

        _endVerse = -1;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;

        _chapter = chapter;

        _startVerse = startVerse;

        _endVerse = endVerse;
    }

    public string GetReference()
    {
        if (_endVerse == -1)
            return $"{_book} {_chapter}:{_startVerse}";

        else
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}