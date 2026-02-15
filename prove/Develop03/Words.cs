public class Words
{
    private string _text;
    private int _length;
    private bool _hidden;

    public Words()
    {
        _text = "";
        _length = 0;
        _hidden = true;
    }
    public Words(string text, int length, bool hidden)
    {
        _text = text;
        _length = length;
        _hidden = hidden;
    }
    
    public static List<Words> HideWord(List<Words> words)
    {
        Random random = new Random();
        List<Words> new_words = words;
        int loop_guard = 0;
        for(int i = 0; i<(words.Count()/8); i++)
        {
            int random_index = random.Next(words.Count());
            if(words[random_index]._hidden == false){
                new_words[random_index]._hidden = true;
            }
            else
            {
                i--;
                loop_guard ++;
                if (loop_guard > 50)
                {
                    break;
                }
            }
        }
        return new_words;
    }
    public string GetText()
    {
        return _text + " ";
    }
    public int GetLength()
    {
        return _length;
    }
    public bool GetHidden()
    {
        return _hidden;
    }
}