public class Reference
{
    private string _book;
    private int _chapter;
    private int _startingVerse;
    private int _endingVerse;

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
