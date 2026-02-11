public class Reference
{
    public string _book;
    public int _chapter;
    public int _startingVerse;
    public int _endingVerse;

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startingVerse = startVerse;
        _endingVerse = 0;
    }
    public Reference(string book, int chapter, int startVerse, int endingVerse)
    {
        _book = book;
        _chapter = chapter;
        _startingVerse = startVerse;
        _endingVerse = endingVerse;
    }

    public string GetReference()
    {
        if (_endingVerse != 0)
        {
            return $"{_book} {_chapter}:{_startingVerse}-{_endingVerse}" ;
        }
        else
        {
            return $"{_book} {_chapter}:{_startingVerse} ";
        }

    }

}
